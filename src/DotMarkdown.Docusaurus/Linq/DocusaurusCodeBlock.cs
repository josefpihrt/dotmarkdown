// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

[DebuggerDisplay("Docusaurus CodeBlock {Language,nq} {Text,nq}")]
public class DocusaurusCodeBlock : MElement
{
    private string? _language;

    public DocusaurusCodeBlock(string text, string? language = null, string? title = null, bool? includeLineNumbers = null)
    {
        Text = text;
        Language = language;
        Title = title;
        IncludeLineNumbers = includeLineNumbers;
    }

    public DocusaurusCodeBlock(DocusaurusCodeBlock other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Text = other.Text;
        _language = other.Language;
        Title = other.Title;
        IncludeLineNumbers = other.IncludeLineNumbers;
    }

    public string Text { get; set; }

    public string? Language
    {
        get { return _language; }
        set
        {
            Error.ThrowOnInvalidFencedCodeBlockInfo(value);

            _language = value;
        }
    }

    public string? Title { get; }

    public bool? IncludeLineNumbers { get; }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    public override void WriteTo(MarkdownWriter writer)
    {
        if (writer is DocusaurusMarkdownWriter docusaurusWriter)
        {
            docusaurusWriter.WriteDocusaurusCodeBlock(Text, Language, Title, IncludeLineNumbers ?? docusaurusWriter.DocusaurusFormat.IncludeCodeLineNumbers);
        }
        else
        {
            writer.WriteDocusaurusCodeBlock(Text, Language, Title, IncludeLineNumbers ?? DocusaurusMarkdownFormat.Default.IncludeCodeLineNumbers);
        }
    }

    internal override MElement Clone()
    {
        return new DocusaurusCodeBlock(this);
    }
}
