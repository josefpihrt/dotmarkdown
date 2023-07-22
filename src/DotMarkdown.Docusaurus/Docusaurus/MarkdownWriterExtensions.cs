// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text;

namespace DotMarkdown.Docusaurus;

public static class MarkdownWriterExtensions
{
    public static void WriteDocusaurusCodeBlock(
        this MarkdownWriter writer,
        string text,
        string? info = null,
        string? title = null,
        bool includeLineNumbers = false)
    {
        if (writer is null)
            throw new ArgumentNullException(nameof(writer));

        if (!string.IsNullOrEmpty(info)
            || !string.IsNullOrEmpty(title)
            || includeLineNumbers)
        {
            StringBuilder sb = StringBuilderCache.GetInstance();

            if (!string.IsNullOrEmpty(info))
                sb.Append(info);

            if (includeLineNumbers)
            {
                if (sb.Length > 0)
                    sb.Append(' ');

                sb.Append("showLineNumbers");
            }

            if (!string.IsNullOrEmpty(title))
            {
                if (sb.Length > 0)
                    sb.Append(' ');

                sb.Append("title=\"");
                sb.Append(title);
                sb.Replace("\"", "\\\"", sb.Length - title!.Length, title.Length);
                sb.Append('"');
            }

            info = StringBuilderCache.GetStringAndFree(sb);
        }

        writer.WriteFencedCodeBlock(text, info);
    }

    public static void WriteDocusaurusNoteBlock(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, "note", text, title);
    }

    public static void WriteDocusaurusTipBlock(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, "tip", text, title);
    }

    public static void WriteDocusaurusInfoBlock(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, "info", text, title);
    }

    public static void WriteDocusaurusCautionBlock(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, "caution", text, title);
    }

    public static void WriteDocusaurusDangerBlock(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, "danger", text, title);
    }

    public static void WriteDocusaurusAdmonition(this MarkdownWriter writer, AdmonitionKind kind, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, kind.GetText(), text, title);
    }

    internal static void WriteDocusaurusAdmonition(this MarkdownWriter writer, string admonition, string text, string? title = null, bool includeBlankLines = true)
    {
        if (writer is null)
            throw new ArgumentNullException(nameof(writer));

        string info = admonition;

        if (!string.IsNullOrEmpty(title))
            info += $" {title}";

        writer.WriteFencedBlock(text, ":::", MarkdownCharEscaper.Default, info: info, blankLinesAroundContent: includeBlankLines);
    }
}
