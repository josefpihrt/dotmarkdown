// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Tests;

internal static class MarkdownWriterExtensions
{
    public static string? ToStringAndClear(this MarkdownWriter mw)
    {
        string? s = mw.ToString();
        ((MarkdownStringWriter)mw).GetStringBuilder().Clear();
        return s;
    }

    public static MarkdownWriter Write2(this MarkdownWriter writer, object value)
    {
        writer.Write(value);

        return writer;
    }
}
