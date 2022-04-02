// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace DotMarkdown.Linq
{
    internal static class TableAnalyzer
    {
        public static List<TableColumnInfo> Analyze(
            IEnumerable<MElement> rows,
            MarkdownWriterSettings settings,
            IFormatProvider formatProvider)
        {
            using (IEnumerator<MElement> en = rows.GetEnumerator())
            {
                if (!en.MoveNext())
                    return null;

                using (var writer = new MarkdownStringWriter(formatProvider: formatProvider, settings: settings))
                    return Analyze(en, settings, writer);
            }
        }

        private static List<TableColumnInfo> Analyze(
            IEnumerator<MElement> en,
            MarkdownWriterSettings settings,
            MarkdownStringWriter writer)
        {
            var columns = new List<TableColumnInfo>();

            MElement header = en.Current;

            if (header is MContainer container)
            {
                WriteHeaderCells(container, settings, writer, columns);
            }
            else
            {
                writer.Write(header);
                columns.Add(TableColumnInfo.Create(header, writer));
            }

            if (settings.Format.FormatTableContent)
            {
                int index = writer.Length;

                while (en.MoveNext())
                {
                    int columnCount = columns.Count;

                    MElement row = en.Current;

                    if (row is MContainer rowContainer)
                    {
                        int i = 0;
                        foreach (MElement cell in rowContainer.Elements())
                        {
                            writer.Write(cell);
                            columns[i] = columns[i].UpdateWidthIfGreater(writer.Length - index);
                            index = writer.Length;
                            i++;

                            if (i == columnCount)
                                break;
                        }
                    }
                    else
                    {
                        writer.Write(row);
                        columns[0] = columns[0].UpdateWidthIfGreater(writer.Length - index);
                        index = writer.Length;
                    }
                }
            }

            return columns;
        }

        private static void WriteHeaderCells(
            MContainer header,
            MarkdownWriterSettings settings,
            MarkdownStringWriter writer,
            List<TableColumnInfo> columns)
        {
            int index = 0;

            var isFirst = true;
            bool isLast;

            int i = 0;

            using (IEnumerator<MElement> en = header.Elements().GetEnumerator())
            {
                if (en.MoveNext())
                {
                    MElement curr = en.Current;

                    isLast = !en.MoveNext();

                    WriteHeaderCell(curr);

                    if (!isLast)
                    {
                        isFirst = false;

                        do
                        {
                            curr = en.Current;
                            isLast = !en.MoveNext();
                            i++;

                            WriteHeaderCell(curr);
                        }
                        while (!isLast);
                    }
                }
            }

            void WriteHeaderCell(MElement cellContent)
            {
                if (isFirst
                    || isLast
                    || settings.Format.FormatTableHeader)
                {
                    writer.Write(cellContent);
                }

                columns.Add(TableColumnInfo.Create(cellContent, writer, index));
                index = writer.Length;
            }
        }
    }
}
