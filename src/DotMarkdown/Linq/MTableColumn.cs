// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace DotMarkdown.Linq;

//MTableHeaderCell
[DebuggerDisplay("{Kind} {Alignment} {ToStringDebuggerDisplay(),nq}")]
public class MTableColumn : MContainer
{
    public MTableColumn(HorizontalAlignment alignment)
    {
        Alignment = alignment;
    }

    public MTableColumn(HorizontalAlignment alignment, object content)
        : base(content)
    {
        Alignment = alignment;
    }

    public MTableColumn(HorizontalAlignment alignment, params object[] content)
        : base(content)
    {
        Alignment = alignment;
    }

    public MTableColumn(MTableColumn other)
        : base(other)
    {
        Alignment = other.Alignment;
    }

    public HorizontalAlignment Alignment { get; set; }

    public override MarkdownKind Kind => MarkdownKind.TableColumn;

    public override void WriteTo(MarkdownWriter writer)
    {
        WriteContentTo(writer);
    }

    internal override MElement Clone()
    {
        return new MTableColumn(this);
    }
}
