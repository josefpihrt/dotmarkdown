// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text;

namespace DotMarkdown.Docusaurus;

public static class MarkdownWriterExtensions
{
    public static void WriteDocusaurusCodeBlock(this MarkdownWriter writer, string text, string? info = null, string? textInfo = null, bool showLineNumbers = false)
    {
        if (writer is null)
            throw new ArgumentNullException(nameof(writer));

        if (!string.IsNullOrEmpty(info)
            || !string.IsNullOrEmpty(textInfo)
            || showLineNumbers)
        {
            StringBuilder sb = StringBuilderCache.GetInstance();

            if (!string.IsNullOrEmpty(info))
                sb.Append(info);

            if (showLineNumbers)
            {
                if (sb.Length > 0)
                    sb.Append(' ');

                sb.Append("showLineNumbers");
            }

            if (!string.IsNullOrEmpty(textInfo))
            {
                if (sb.Length > 0)
                    sb.Append(' ');

                sb.Append("title=\"");
                sb.Append(textInfo);
                sb.Replace("\"", "\\\"", sb.Length - textInfo!.Length, textInfo.Length);
                sb.Append('"');
            }

            info = StringBuilderCache.GetStringAndFree(sb);
        }

        writer.WriteFencedCodeBlock(text, info);
    }

    public static void WriteDocusaurusNote(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionKind.Note, title);
    }

    public static void WriteDocusaurusTip(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionKind.Tip, title);
    }

    public static void WriteDocusaurusInfo(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionKind.Info, title);
    }

    public static void WriteDocusaurusCaution(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionKind.Caution, title);
    }

    public static void WriteDocusaurusDanger(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionKind.Danger, title);
    }

    public static void WriteDocusaurusAdmonition(this MarkdownWriter writer, string text, AdmonitionKind kind, string? title = null)
    {
        if (writer is null)
            throw new ArgumentNullException(nameof(writer));

        string info = kind switch
        {
            AdmonitionKind.Note => "note",
            AdmonitionKind.Tip => "tip",
            AdmonitionKind.Info => "info",
            AdmonitionKind.Caution => "caution",
            AdmonitionKind.Danger => "danger",
            _ => throw new ArgumentException($"Unknown {nameof(AdmonitionKind)} '{kind}'", nameof(kind))
        };

        if (!string.IsNullOrEmpty(title))
            info += $" {title}";

        writer.WriteFencedBlock(text, ":::", MarkdownCharEscaper.Default, info: info, blankLinesAroundContent: true);
    }
}
