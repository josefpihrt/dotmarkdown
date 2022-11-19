// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace DotMarkdown.Linq;

[DebuggerDisplay("{Kind} {Level} {ToStringDebuggerDisplay(),nq}")]
public class MHeading : MContainer
{
    private int _level;

    public MHeading(int level)
    {
        Level = level;
    }

    public MHeading(int level, object content)
        : base(content)
    {
        Level = level;
    }

    public MHeading(int level, params object[] content)
        : base(content)
    {
        Level = level;
    }

    public MHeading(MHeading other)
        : base(other)
    {
        _level = other.Level;
    }

    public int Level
    {
        get { return _level; }
        set
        {
            Error.ThrowOnInvalidHeadingLevel(value);

            _level = value;
        }
    }

    public override MarkdownKind Kind => MarkdownKind.Heading;

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteStartHeading(Level);
        WriteContentTo(writer);
        writer.WriteEndHeading();
    }

    internal override MElement Clone()
    {
        return new MHeading(this);
    }
}
