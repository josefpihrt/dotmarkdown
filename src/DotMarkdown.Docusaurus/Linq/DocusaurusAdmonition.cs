﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

[DebuggerDisplay("{Kind}{DebuggerDisplay,nq} {Text,nq}")]
public abstract class DocusaurusAdmonition : MElement
{
    protected DocusaurusAdmonition(string text, string? title = null)
    {
        Text = text;
        Title = title;
    }

    protected DocusaurusAdmonition(DocusaurusAdmonition other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Text = other.Text;
        Title = other.Title;
    }

    public static DocusaurusAdmonition Create(AdmonitionKind kind, string text, string? title = null)
    {
        return kind switch
        {
            AdmonitionKind.Note => new DocusaurusNoteBlock(text, title),
            AdmonitionKind.Tip => new DocusaurusTipBlock(text, title),
            AdmonitionKind.Info => new DocusaurusInfoBlock(text, title),
            AdmonitionKind.Caution => new DocusaurusCautionBlock(text, title),
            AdmonitionKind.Danger => new DocusaurusDangerBlock(text, title),
            _ => throw new ArgumentException($"Unknown {nameof(DotMarkdown.Docusaurus.AdmonitionKind)} '{kind}'.", nameof(kind)),
        };
    }

    public string Text { get; set; }

    public string? Title { get; }

    public abstract AdmonitionKind AdmonitionKind { get; }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    private string DebuggerDisplay => $" Docusaurus {AdmonitionKind} {Title}";

    public override void WriteTo(MarkdownWriter writer)
    {
        if (writer is DocusaurusMarkdownWriter docusaurusWriter)
        {
            docusaurusWriter.WriteDocusaurusAdmonition(AdmonitionKind, Text, Title);
        }
        else
        {
            writer.WriteDocusaurusAdmonition(AdmonitionKind, Text, Title);
        }
    }
}