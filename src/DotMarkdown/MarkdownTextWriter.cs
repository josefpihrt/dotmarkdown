// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DotMarkdown.Linq;

namespace DotMarkdown
{
    internal class MarkdownTextWriter : MarkdownBaseWriter, ITableAnalyzer
    {
        private const int BufferSize = 1024 * 6;
        private const int BufferOverflow = 32;

        private TextWriter _writer;
        private bool _noWrite;

        private readonly char[] _bufChars;
        private int _bufPos;
        private readonly int _bufLen = BufferSize;

        public MarkdownTextWriter(TextWriter writer, MarkdownWriterSettings settings = null)
            : base(settings)
        {
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));

            _bufChars = new char[_bufLen + BufferOverflow];
        }

        protected internal override int Length { get; set; }

        public override void WriteString(string text)
        {
            try
            {
                BeforeWriteString();

                if (string.IsNullOrEmpty(text))
                    return;

                WriteStringUnsafe(text);
            }
            catch
            {
                _state = State.Error;
                throw;
            }
        }

        private unsafe void WriteStringUnsafe(string value)
        {
            Debug.Assert(value != null);

            fixed (char* pSrcStart = value)
            {
                WriteStringUnsafe(pSrcStart, pSrcStart + value.Length);
            }
        }

        private unsafe void WriteStringUnsafe(char* pSrcStart, char* pSrcEnd)
        {
            fixed (char* pDstStart = _bufChars)
            {
                char* pDst = pDstStart + _bufPos;
                char* pSrc = pSrcStart;

                int ch = 0;
                while (true)
                {
                    char* pDstEnd = pDst + (pSrcEnd - pSrc);

                    if (pDstEnd > pDstStart + _bufLen)
                        pDstEnd = pDstStart + _bufLen;

                    while (pDst < pDstEnd)
                    {
                        ch = *pSrc;

                        if (ch == 10
                            || ch == 13
                            || ShouldBeEscaped((char)ch))
                        {
                            break;
                        }

                        pSrc++;
                        *pDst = (char)ch;
                        pDst++;
                        Length++;
                    }

                    if (pSrc >= pSrcEnd)
                        break;

                    if (pDst >= pDstEnd)
                    {
                        _bufPos = (int)(pDst - pDstStart);
                        FlushBuffer();
                        pDst = pDstStart;
                        continue;
                    }

                    switch (ch)
                    {
                        case (char)10:
                            {
                                OnBeforeWriteLine();

                                switch (NewLineHandling)
                                {
                                    case NewLineHandling.Replace:
                                        {
                                            pDst = WriteNewLineUnsafe(pDst);
                                            break;
                                        }
                                    case NewLineHandling.None:
                                        {
                                            *pDst = (char)ch;
                                            pDst++;
                                            Length++;
                                            break;
                                        }
                                }

                                OnAfterWriteLine();
                                WriteIndentation();
                                break;
                            }
                        case (char)13:
                            {
                                OnBeforeWriteLine();

                                switch (NewLineHandling)
                                {
                                    case NewLineHandling.Replace:
                                        {
                                            if (pSrc < pSrcEnd
                                                && pSrc[1] == '\n')
                                            {
                                                pSrc++;
                                            }

                                            pDst = WriteNewLineUnsafe(pDst);
                                            break;
                                        }
                                    case NewLineHandling.None:
                                        {
                                            *pDst = (char)ch;
                                            pDst++;
                                            Length++;
                                            break;
                                        }
                                }

                                OnAfterWriteLine();
                                WriteIndentation();
                                break;
                            }
                        default:
                            {
                                *pDst = EscapingChar;
                                pDst++;
                                Length++;
                                *pDst = (char)ch;
                                pDst++;
                                Length++;
                                break;
                            }
                    }

                    pSrc++;
                }

                _bufPos = (int)(pDst - pDstStart);
            }

            char* WriteNewLineUnsafe(char* pDst)
            {
                fixed (char* pDstStart = _bufChars)
                {
                    _bufPos = (int)(pDst - pDstStart);
                    WriteRawUnsafe(NewLineChars);
                    return pDstStart + _bufPos;
                }
            }
        }

        public override void WriteRaw(string data)
        {
            BeforeWriteRaw();

            if (string.IsNullOrEmpty(data))
                return;

            try
            {
                WriteRawUnsafe(data);
            }
            catch
            {
                _state = State.Error;
                throw;
            }
        }

        private unsafe void WriteRawUnsafe(string s)
        {
            fixed (char* pSrcStart = s)
            {
                WriteRawUnsafe(pSrcStart, pSrcStart + s.Length);
            }
        }

        private unsafe void WriteRawUnsafe(char* pSrcStart, char* pSrcEnd)
        {
            fixed (char* pDstStart = _bufChars)
            {
                char* pDst = pDstStart + _bufPos;
                char* pSrc = pSrcStart;

                while (true)
                {
                    char* pDstEnd = pDst + (pSrcEnd - pSrc);

                    if (pDstEnd > pDstStart + _bufLen)
                        pDstEnd = pDstStart + _bufLen;

                    while (pDst < pDstEnd)
                    {
                        *pDst = *pSrc;
                        pSrc++;
                        pDst++;
                        Length++;
                    }

                    if (pSrc >= pSrcEnd)
                        break;

                    if (pDst >= pDstEnd)
                    {
                        _bufPos = (int)(pDst - pDstStart);
                        FlushBuffer();
                        pDst = pDstStart;
                    }
                }

                _bufPos = (int)(pDst - pDstStart);
            }
        }

        protected override void WriteNewLineChars()
        {
            WriteRawUnsafe(NewLineChars);
        }

        protected override void WriteIndentation(string value)
        {
            try
            {
                WriteRawUnsafe(value);
            }
            catch
            {
                _state = State.Error;
                throw;
            }
        }

        public override void WriteValue(int value)
        {
            WriteString(value.ToString(_writer.FormatProvider));
        }

        public override void WriteValue(long value)
        {
            WriteString(value.ToString(_writer.FormatProvider));
        }

        public override void WriteValue(float value)
        {
            WriteString(value.ToString(_writer.FormatProvider));
        }

        public override void WriteValue(double value)
        {
            WriteString(value.ToString(_writer.FormatProvider));
        }

        public override void WriteValue(decimal value)
        {
            WriteString(value.ToString(_writer.FormatProvider));
        }

        public override void Flush()
        {
            FlushBuffer();

            _writer?.Flush();
        }

        protected virtual void FlushBuffer()
        {
            try
            {
                if (!_noWrite)
                    _writer.Write(_bufChars, 0, _bufPos);
            }
            catch
            {
                _noWrite = true;
                throw;
            }
            finally
            {
                _bufPos = 0;
            }
        }

        public override void Close()
        {
            try
            {
                FlushBuffer();
            }
            finally
            {
                _noWrite = true;

                if (_writer != null)
                {
                    try
                    {
                        _writer.Flush();
                    }
                    finally
                    {
                        try
                        {
                            if (Settings.CloseOutput)
                                _writer.Dispose();
                        }
                        finally
                        {
                            _writer = null;
                        }
                    }
                }
            }
        }

        public IReadOnlyList<TableColumnInfo> AnalyzeTable(IEnumerable<MElement> rows)
        {
            return TableAnalyzer.Analyze(rows, Settings, _writer.FormatProvider)?.AsReadOnly();
        }
    }
}