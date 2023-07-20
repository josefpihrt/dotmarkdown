// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;

namespace DotMarkdown.Linq;

public class MTable : MContainer
{
    public MTable()
    {
    }

    public MTable(object content)
        : base(content)
    {
    }

    public MTable(params object[] content)
        : base(content)
    {
    }

    public MTable(MContainer other)
        : base(other)
    {
    }

    public override MarkdownKind Kind => MarkdownKind.Table;

    public override void WriteTo(MarkdownWriter writer)
    {
        IEnumerable<MElement> rows = Elements();

        IReadOnlyList<TableColumnInfo>? columns = (writer as ITableAnalyzer)?.AnalyzeTable(rows);

        if (columns is not null)
        {
            writer.WriteStartTable(columns);
        }
        else
        {
            MElement header = rows.FirstOrDefault();

            if (header is null)
                return;

            int columnCount = (header as MContainer)?.Elements().Count() ?? 1;

            writer.WriteStartTable(columnCount);
        }

        using (IEnumerator<MElement> en = rows.GetEnumerator())
        {
            if (en.MoveNext())
            {
                writer.WriteTableRow(en.Current);
                writer.WriteTableHeaderSeparator();

                while (en.MoveNext())
                    writer.WriteTableRow(en.Current);
            }
        }

        writer.WriteEndTable();
    }

    internal override MElement Clone()
    {
        return new MTable(this);
    }

    internal override void ValidateElement(MElement element)
    {
        if (element.Kind == MarkdownKind.TableRow)
            return;

        base.ValidateElement(element);
    }
}
