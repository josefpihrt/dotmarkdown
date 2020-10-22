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

            string indentation = null;
            var pendingIndentation = false;
            int offset = 0;

            while (true)
            {
                fixed (char* pSrcStart = value)
                {
                    offset += WriteStringUnsafe(pSrcStart + offset, pSrcStart + value.Length);
                }

                if (pendingIndentation)
                {
                    WriteRawUnsafe(indentation);
                    pendingIndentation = false;
                }
                else
                {
                    break;
                }
            }

            int WriteStringUnsafe(char* pSrcStart, char* pSrcEnd)
            {
                fixed (char* pDstStart = _bufChars)
                {
                    char* pDst = pDstStart + _bufPos;
                    char* pSrc = pSrcStart;

                    int ch = 0;
                    do
                    {
                        char* pDstEnd = pDst + (pSrcEnd - pSrc);

                        if (pDstEnd > pDstStart + _bufLen)
                            pDstEnd = pDstStart + _bufLen;

                        while (pDst < pDstEnd)
                        {
                            ch = *pSrc;

                            if (ch == 10
                                || ch == 13
                                || Escaper.ShouldBeEscaped((char)ch))
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
                                                pDst = WriteRaw(NewLineChars, pDst);
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

                                    if (IsPendingIndentation())
                                        pendingIndentation = true;

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

                                                pDst = WriteRaw(NewLineChars, pDst);
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

                                    if (IsPendingIndentation())
                                        pendingIndentation = true;

                                    break;
                                }
                            case '>':
                            case '<':
                                {
                                    string escapedChar = EscapeChar(ch);
                                    pDst = WriteRaw(escapedChar, pDst);
                                    break;
                                }
                            default:
                                {
                                    *pDst = MarkdownCharEscaper.DefaultEscapingChar;
                                    pDst++;
                                    Length++;
                                    *pDst = (char)ch;
                                    pDst++;
                                    Length++;
                                    break;
                                }
                        }

                        pSrc++;

                    } while (!pendingIndentation);

                    _bufPos = (int)(pDst - pDstStart);

                    return (int)(pSrc - pSrcStart);
                }

                char* WriteRaw(string text, char* pDst)
                {
                    fixed (char* pDstStart = _bufChars)
                    {
                        _bufPos = (int)(pDst - pDstStart);
                        WriteRawUnsafe(text);
                        return pDstStart + _bufPos;
                    }
                }
            }

            bool IsPendingIndentation()
            {
                if (indentation == null)
                    indentation = base.GetIndentation();

                return indentation.Length > 0;
            }
        }

        public override void WriteRaw(string data)
        {
            try
            {
                BeforeWriteRaw();

                if (!string.IsNullOrEmpty(data))
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
            WriteRawUnsafe(value);
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