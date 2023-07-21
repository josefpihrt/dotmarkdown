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
        WriteDocusaurusAdmonition(writer, text, AdmonitionStyle.Note, title);
    }

    public static void WriteDocusaurusTip(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionStyle.Tip, title);
    }

    public static void WriteDocusaurusInfo(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionStyle.Info, title);
    }

    public static void WriteDocusaurusCaution(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionStyle.Caution, title);
    }

    public static void WriteDocusaurusDanger(this MarkdownWriter writer, string text, string? title = null)
    {
        WriteDocusaurusAdmonition(writer, text, AdmonitionStyle.Danger, title);
    }

    public static void WriteDocusaurusAdmonition(this MarkdownWriter writer, string text, AdmonitionStyle admonitionStyle, string? title = null)
    {
        if (writer is null)
            throw new ArgumentNullException(nameof(writer));

        string info = admonitionStyle switch
        {
            AdmonitionStyle.Note => "note",
            AdmonitionStyle.Tip => "tip",
            AdmonitionStyle.Info => "info",
            AdmonitionStyle.Caution => "caution",
            AdmonitionStyle.Danger => "danger",
            _ => throw new ArgumentException($"Unknown {nameof(AdmonitionStyle)} '{admonitionStyle}'", nameof(admonitionStyle))
        };

        info += title;

        writer.WriteFencedBlock(text, ":::", info);
    }
}
