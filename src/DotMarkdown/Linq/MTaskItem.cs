// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace DotMarkdown.Linq;

[DebuggerDisplay("{Kind} {ToStringDebuggerDisplay(),nq}")]
public class MTaskItem : MBlockContainer
{
    public MTaskItem(bool isCompleted)
    {
        IsCompleted = isCompleted;
    }

    public MTaskItem(bool isCompleted, object content)
        : base(content)
    {
        IsCompleted = isCompleted;
    }

    public MTaskItem(bool isCompleted, params object[] content)
        : base(content)
    {
        IsCompleted = isCompleted;
    }

    public MTaskItem(MTaskItem other)
        : base(other)
    {
        IsCompleted = other.IsCompleted;
    }

    public bool IsCompleted { get; set; }

    public override MarkdownKind Kind => MarkdownKind.TaskItem;

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteStartTaskItem(IsCompleted);
        WriteContentTo(writer);
        writer.WriteEndTaskItem();
    }

    internal override MElement Clone()
    {
        return new MTaskItem(this);
    }
}
