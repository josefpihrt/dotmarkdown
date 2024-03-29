﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Tests;

namespace DotMarkdown.Docusaurus.Tests;

internal static class Extensions
{
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
