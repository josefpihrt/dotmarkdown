// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

[DebuggerDisplay("{Kind}{InfoDebuggerDisplay,nq} {Text,nq}")]
public class DocusaurusCodeBlock : MElement
{
    private string? _info;

    public DocusaurusCodeBlock(string text, string? language = null, string? title = null, bool? includeLineNumbers = false)
    {
        Text = text;
        Info = language;
        Title = title;
        IncludeLineNumbers = includeLineNumbers;
    }

    public DocusaurusCodeBlock(DocusaurusCodeBlock other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Text = other.Text;
        _info = other.Info;
        Title = other.Title;
        IncludeLineNumbers = other.IncludeLineNumbers;
    }

    public string Text { get; set; }

    public string? Info
    {
        get { return _info; }
        set
        {
            Error.ThrowOnInvalidFencedCodeBlockInfo(value);

            _info = value;
        }
    }

    public string? Title { get; }

    public bool? IncludeLineNumbers { get; }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    private string InfoDebuggerDisplay => (!string.IsNullOrEmpty(Info)) ? " " + Info : "";

    public override void WriteTo(MarkdownWriter writer)
    {
        if (writer is DocusaurusMarkdownWriter docusaurusWriter)
        {
            docusaurusWriter.WriteDocusaurusCodeBlock(Text, Info, Title, IncludeLineNumbers);
        }
        else
        {
            writer.WriteDocusaurusCodeBlock(Text, Info, Title, IncludeLineNumbers ?? DocusaurusMarkdownFormat.Default.CodeLineNumbers);
        }
    }

    internal override MElement Clone()
    {
        return new DocusaurusCodeBlock(this);
    }
}
