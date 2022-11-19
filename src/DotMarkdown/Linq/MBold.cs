// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq;

public class MBold : MInline
{
    public MBold()
    {
    }

    public MBold(object content)
        : base(content)
    {
    }

    public MBold(params object[] content)
        : base(content)
    {
    }

    public MBold(MBold other)
        : base(other)
    {
    }

    public override MarkdownKind Kind => MarkdownKind.Bold;

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteStartBold();
        WriteContentTo(writer);
        writer.WriteEndBold();
    }

    internal override MElement Clone()
    {
        return new MBold(this);
    }
}
