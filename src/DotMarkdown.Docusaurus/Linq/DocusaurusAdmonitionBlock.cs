// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Text;
using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

[DebuggerDisplay("{Kind}{DebuggerDisplay,nq} {Text,nq}")]
public abstract class DocusaurusAdmonitionBlock : MContainer
{
    protected DocusaurusAdmonitionBlock(object? content) : base(content)
    {
    }

    protected DocusaurusAdmonitionBlock(params object[]? content) : base(content)
    {
    }

    protected DocusaurusAdmonitionBlock(DocusaurusAdmonitionBlock other) : base(other)
    {
        Title = other.Title;
    }

    public static DocusaurusAdmonitionBlock Create(AdmonitionKind kind, object? content)
    {
        return kind switch
        {
            AdmonitionKind.Note => new DocusaurusNoteBlock(content),
            AdmonitionKind.Tip => new DocusaurusTipBlock(content),
            AdmonitionKind.Info => new DocusaurusInfoBlock(content),
            AdmonitionKind.Caution => new DocusaurusCautionBlock(content),
            AdmonitionKind.Danger => new DocusaurusDangerBlock(content),
            _ => throw new ArgumentException($"Unknown {nameof(DotMarkdown.Docusaurus.AdmonitionKind)} '{kind}'.", nameof(kind)),
        };
    }

    public static DocusaurusAdmonitionBlock Create(AdmonitionKind kind, params object[]? content)
    {
        return Create(kind, (object?)content);
    }

    public string? Title { get; set; }

    public abstract AdmonitionKind AdmonitionKind { get; }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    private string DebuggerDisplay => $" Docusaurus {AdmonitionKind} {Title}";

    public override void WriteTo(MarkdownWriter writer)
    {
        if (writer is DocusaurusMarkdownWriter docusaurusWriter)
        {
            docusaurusWriter.WriteStartDocusaurusAdmonition(AdmonitionKind, Title);
            WriteContentTo(docusaurusWriter);
            docusaurusWriter.WriteEndDocusaurusAdmonition();
        }
        else
        {
            writer.WriteStartDocusaurusAdmonition(AdmonitionKind, Title);
            WriteContentTo(writer);
            writer.WriteEndDocusaurusAdmonition();
        }
    }
}
