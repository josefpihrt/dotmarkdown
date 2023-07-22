// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;
using DotMarkdown.Docusaurus.Linq;
using DotMarkdown.Tests;

namespace DotMarkdown.Docusaurus.Tests;

internal static class Extensions
{
    private static readonly Regex _newLineRegex = new("\r?\n");

    public static string NormalizeNewLine(this string value)
    {
        return _newLineRegex.Replace(value, "\n");
    }

    public static DocusaurusCodeBlock Modify(this DocusaurusCodeBlock block)
    {
        return new DocusaurusCodeBlock(block.Text.Modify(), block.Language!.Modify());
    }

    public static string? ToStringAndClear(this DocusaurusMarkdownWriter mw)
    {
        string? s = mw.Writer.ToString();
        ((MarkdownStringWriter)mw.Writer).GetStringBuilder().Clear();
        return s;
    }
}
