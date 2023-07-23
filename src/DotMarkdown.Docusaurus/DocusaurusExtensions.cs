// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Text;
using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus;

public static class DocusaurusExtensions
{
    public static string ToString(this MElement element, DocusaurusMarkdownFormat docusaurusFormat)
    {
        return ToString(element, default(MarkdownWriterSettings), docusaurusFormat);
    }

    public static string ToString(this MElement element, MarkdownFormat format, DocusaurusMarkdownFormat docusaurusFormat)
    {
        return ToString(element, MarkdownWriterSettings.From(format), docusaurusFormat);
    }

    public static string ToString(this MElement element, MarkdownWriterSettings? settings, DocusaurusMarkdownFormat docusaurusFormat)
    {
        StringBuilder sb = StringBuilderCache.GetInstance();

        using (var writer = new MarkdownStringWriter(sb, settings))
        {
            using (var docusaurusWriter = new DocusaurusMarkdownWriter(writer, docusaurusFormat))
            {
                element.WriteTo(docusaurusWriter);

                return StringBuilderCache.GetStringAndFree(writer.GetStringBuilder());
            }
        }
    }

    internal static void WriteDocusaurusFrontMatter(this MarkdownWriter writer, params (string key, object? value)[] labels)
    {
        if (writer.WriteState != WriteState.Start)
            throw new InvalidOperationException("Docusaurus front matter can be written only at the beginning of the document.");

        if (labels is null || labels.Length == 0)
            return;

        writer.WriteStartFencedBlock("---");

        var isFirst = true;
        foreach ((string key, object value) in labels)
        {
            if (isFirst)
            {
                isFirst = false;
            }
            else
            {
                writer.WriteLine();
            }

            if (string.IsNullOrEmpty(key)
                || key.Contains(":"))
            {
                throw new InvalidOperationException("Docusarus front matter label is missing or invalid.");
            }

            if (value is string s)
            {
                writer.WriteRaw(key);
                writer.WriteRaw(": ");
                writer.WriteFrontMatterValue(s);
            }
            else if (value is object[] arr)
            {
                var isFirst2 = true;
                foreach (object item in arr)
                    writer.WriteFrontMatter(ref isFirst2, key, item);
            }
            else if (value is IEnumerable enumerable)
            {
                var isFirst2 = true;
                foreach (object item in enumerable)
                    writer.WriteFrontMatter(ref isFirst2, key, item);
            }
            else if (value is not null)
            {
                writer.WriteRaw(key);
                writer.WriteRaw(": ");
                writer.WriteFrontMatterValue(value);
            }
        }

        writer.WriteEndFencedBlock("---");
    }

    private static void WriteFrontMatter(this MarkdownWriter writer, ref bool isFirst, string key, object value)
    {
        if (value is null)
            return;

        if (isFirst)
        {
            writer.WriteRaw(key);
            writer.WriteRaw(":");
        }

        writer.WriteLine();
        writer.WriteRaw("  - ");
        writer.WriteFrontMatterValue(value);
        isFirst = false;
    }

    private static void WriteFrontMatterValue(this MarkdownWriter writer, object value)
    {
        writer.WriteFrontMatterValue(value.ToString());
    }

    private static void WriteFrontMatterValue(this MarkdownWriter writer, string value)
    {
        writer.WriteString(value.Replace(":", "\":\""));
    }

    internal static void WriteDocusaurusCodeBlock(
        this MarkdownWriter writer,
        string text,
        string? language = null,
        string? title = null,
        bool includeLineNumbers = false)
    {
        if (!string.IsNullOrEmpty(language)
            || !string.IsNullOrEmpty(title)
            || includeLineNumbers)
        {
            StringBuilder sb = StringBuilderCache.GetInstance();

            if (!string.IsNullOrEmpty(language))
                sb.Append(language);

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

            writer.WriteFencedCodeBlock(text, StringBuilderCache.GetStringAndFree(sb));
        }
        else
        {
            writer.WriteFencedCodeBlock(text, language);
        }
    }

    internal static void WriteStartDocusaurusAdmonition(this MarkdownWriter writer, AdmonitionKind kind, string? title = null, bool includeBlankLine = true)
    {
        string info = kind.GetText();

        if (!string.IsNullOrEmpty(title))
            info += $" {title}";

        writer.WriteStartFencedBlock(":::", info);

        if (includeBlankLine)
            writer.WriteLine();
    }

    internal static void WriteEndDocusaurusAdmonition(this MarkdownWriter writer, bool includeBlankLine = true)
    {
        writer.WriteLine(includeBlankLine);
        writer.WriteEndFencedBlock(":::");
    }

    internal static string GetText(this AdmonitionKind kind)
    {
        return kind switch
        {
            AdmonitionKind.Note => "note",
            AdmonitionKind.Tip => "tip",
            AdmonitionKind.Info => "info",
            AdmonitionKind.Caution => "caution",
            AdmonitionKind.Danger => "danger",
            _ => throw new ArgumentException($"Unknown {nameof(AdmonitionKind)} '{kind}'", nameof(kind))
        };
    }
}
