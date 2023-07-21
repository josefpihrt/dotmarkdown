// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using System;
using DotMarkdown.Docusaurus;

namespace DotMarkdown.Linq.Docusaurus;

[DebuggerDisplay("{Kind}{DebuggerDisplay,nq} {Text,nq}")]
public abstract class MDocusaurusAdmonition : MElement
{
    protected MDocusaurusAdmonition(string text, string? title = null)
    {
        Text = text;
        Title = title;
    }

    protected MDocusaurusAdmonition(MDocusaurusAdmonition other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Text = other.Text;
        Title = other.Title;
    }

    public string Text { get; set; }

    public string? Title { get; }

    public abstract AdmonitionStyle Style { get; }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    private string DebuggerDisplay => $" Docusaurus {Style} {Title}";

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteDocusaurusAdmonition(Text, Style, Title);
    }
}
