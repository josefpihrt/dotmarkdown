// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.RegularExpressions;

namespace DotMarkdown.Tests;

internal static class TestExtensions
{
    private static readonly Regex _newLineRegex = new("\r?\n");

    public static string NormalizeNewLine(this string value)
    {
        return _newLineRegex.Replace(value, "\n");
    }
}
