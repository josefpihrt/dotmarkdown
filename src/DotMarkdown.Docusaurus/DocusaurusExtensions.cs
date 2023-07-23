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

        var pendingStart = true;
        foreach ((string key, object? value) in labels)
        {
            if (string.IsNullOrEmpty(key)
                || key.Contains(":"))
            {
                throw new InvalidOperationException("Docusarus front matter label is missing or invalid.");
            }

            if (value is null)
                continue;

            if (value is string stringValue)
            {
                WriteFrontMatterLabel(writer, ref pendingStart, key, stringValue);
            }
            else if (value is object[] arr)
            {
                var isFirst = true;
                foreach (object item in arr)
                    writer.WriteFrontMatterLabel(ref pendingStart, ref isFirst, key, item);
            }
            else if (value is IEnumerable enumerable)
            {
                var isFirst = true;
                foreach (object item in enumerable)
                    writer.WriteFrontMatterLabel(ref pendingStart, ref isFirst, key, item);
            }
            else
            {
                WriteFrontMatterLabel(writer, ref pendingStart, key, value);
            }
        }

        if (!pendingStart)
            writer.WriteEndFencedBlock("---");
    }

    private static void WriteFrontMatterLabel(MarkdownWriter writer, ref bool pendingStart, string key, object value)
    {
        if (pendingStart)
        {
            writer.WriteStartFencedBlock("---");
            pendingStart = false;
        }
        else
        {
            writer.WriteLine();
        }

        writer.WriteRaw(key);
        writer.WriteRaw(": ");
        writer.WriteFrontMatterValue(value);
    }

    private static void WriteFrontMatterLabel(
        this MarkdownWriter writer,
        ref bool pendingStart,
        ref bool isFirst,
        string key,
        object value)
    {
        if (value is null)
            return;

        if (pendingStart)
        {
            writer.WriteStartFencedBlock("---");
            pendingStart = false;
        }
        else
        {
            writer.WriteLine();
        }

        if (isFirst)
        {
            writer.WriteRaw(key);
            writer.WriteRaw(":");
            writer.WriteLine();
        }

        writer.WriteRaw("  - ");
        writer.WriteFrontMatterValue(value);
        isFirst = false;
    }

    private static void WriteFrontMatterValue(this MarkdownWriter writer, object value)
    {
        if (value is string s)
        {
            writer.WriteFrontMatterValue(s);
        }
        else
        {
            writer.WriteString(value.ToString());
        }
    }

    private static void WriteFrontMatterValue(this MarkdownWriter writer, string value)
    {
        writer.WriteRaw("\"");
        writer.WriteRaw(value.Replace("\"", "\\\""));
        writer.WriteRaw("\"");
    }

    internal static void WriteDocusaurusCodeBlock(
        this MarkdownWriter writer,
        string text,
        string? language = null,
        string? title = null,
        bool includeLineNumbers = false)
    {
        if (string.IsNullOrEmpty(title)
            && !includeLineNumbers)
        {
            writer.WriteFencedCodeBlock(text, language);
            return;
        }

        StringBuilder sb = StringBuilderCache.GetInstance();

        if (!string.IsNullOrEmpty(language))
            sb.Append(language);

        if (includeLineNumbers)
            sb.Append(" showLineNumbers");

        if (!string.IsNullOrEmpty(title))
        {
            sb.Append(" title=\"");
            sb.Append(title);
            sb.Replace("\"", "\\\"", sb.Length - title!.Length, title.Length);
            sb.Append('"');
        }

        writer.WriteFencedCodeBlock(text, StringBuilderCache.GetStringAndFree(sb));
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
