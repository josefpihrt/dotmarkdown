// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;
using DotMarkdown.Tests;
using DotMarkdown.Linq.Docusaurus;

namespace DotMarkdown.Docusaurus.Tests;

internal static class Extensions
{
    private static readonly Regex _newLineRegex = new("\r?\n");

    public static string NormalizeNewLine(this string value)
    {
        return _newLineRegex.Replace(value, "\n");
    }

    public static MDocusaurusCodeBlock Modify(this MDocusaurusCodeBlock block)
    {
        return new MDocusaurusCodeBlock(block.Text.Modify(), block.Info!.Modify());
    }
}
