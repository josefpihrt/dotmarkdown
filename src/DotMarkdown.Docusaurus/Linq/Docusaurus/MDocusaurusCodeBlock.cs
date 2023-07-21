// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using System;
using DotMarkdown.Docusaurus;

namespace DotMarkdown.Linq.Docusaurus;

[DebuggerDisplay("{Kind}{InfoDebuggerDisplay,nq} {Text,nq}")]
public class MDocusaurusCodeBlock : MElement
{
    private string? _info;

    public MDocusaurusCodeBlock(string text, string? info = null, string? textInfo = null, bool showLineNumbers = false)
    {
        Text = text;
        Info = info;
        TextInfo = textInfo;
        ShowLineNumbers = showLineNumbers;
    }

    public MDocusaurusCodeBlock(MDocusaurusCodeBlock other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Text = other.Text;
        _info = other.Info;
        TextInfo = other.TextInfo;
        ShowLineNumbers = other.ShowLineNumbers;
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

    public string? TextInfo { get; }

    public bool ShowLineNumbers { get; }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    private string InfoDebuggerDisplay => (!string.IsNullOrEmpty(Info)) ? " " + Info : "";

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteDocusaurusCodeBlock(Text, Info, TextInfo, ShowLineNumbers);
    }

    internal override MElement Clone()
    {
        return new MDocusaurusCodeBlock(this);
    }
}
