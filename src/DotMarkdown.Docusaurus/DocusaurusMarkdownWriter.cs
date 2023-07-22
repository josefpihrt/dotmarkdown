// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace DotMarkdown.Docusaurus;

public sealed class DocusaurusMarkdownWriter : MarkdownWriter
{
    public DocusaurusMarkdownWriter(MarkdownWriter writer, DocusaurusMarkdownFormat? format = null)
    {
        Writer = writer ?? throw new ArgumentNullException(nameof(writer));
        DocusaurusFormat = format ?? DocusaurusMarkdownFormat.Default;
    }

    public MarkdownWriter Writer { get; }

    public DocusaurusMarkdownFormat DocusaurusFormat { get; }

    public void WriteDocusaurusCodeBlock(
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

            language = StringBuilderCache.GetStringAndFree(sb);
        }

        WriteFencedCodeBlock(text, language);
    }

    public void WriteStartDocusaurusAdmonition(AdmonitionKind kind, string? title = null)
    {
        string info = kind.GetText();

        if (!string.IsNullOrEmpty(title))
            info += $" {title}";

        WriteStartFencedBlock(":::", info);

        if (DocusaurusFormat.AdmonitionBlankLines)
            WriteLine();
    }

    public void WriteEndDocusaurusAdmonition()
    {
        if (DocusaurusFormat.AdmonitionBlankLines)
        {
            WriteLine();
            WriteLine();
        }

        WriteEndFencedBlock(":::");
    }

    public override WriteState WriteState => Writer.WriteState;

    public override void Flush() => Writer.Flush();

    public override void WriteAutolink(string url) => Writer.WriteAutolink(url);

    public override void WriteCharEntity(char value) => Writer.WriteCharEntity(value);

    public override void WriteComment(string text) => Writer.WriteComment(text);

    public override void WriteEndBlockQuote() => Writer.WriteEndBlockQuote();

    public override void WriteEndBold() => Writer.WriteEndBold();

    public override void WriteEndBulletItem() => Writer.WriteEndBulletItem();

    public override void WriteEndHeading() => Writer.WriteEndHeading();

    public override void WriteEndItalic() => Writer.WriteEndItalic();

    public override void WriteEndLink(string url, string? title = null) => Writer.WriteEndLink(url, title);

    public override void WriteEndOrderedItem() => Writer.WriteEndOrderedItem();

    public override void WriteEndStrikethrough() => Writer.WriteEndStrikethrough();

    public override void WriteEndTable() => Writer.WriteEndTable();

    public override void WriteEndTableCell() => Writer.WriteEndTableCell();

    public override void WriteEndTableRow() => Writer.WriteEndTableRow();

    public override void WriteEndTaskItem() => Writer.WriteEndTaskItem();

    public override void WriteEntityRef(string name) => Writer.WriteEntityRef(name);

    public override void WriteFencedCodeBlock(string text, string? info = null) => Writer.WriteFencedCodeBlock(text, info);

    public override void WriteHorizontalRule(HorizontalRuleStyle style, int count = 3, string? separator = " ") => Writer.WriteHorizontalRule(style, count, separator);

    public override void WriteImage(string text, string url, string? title = null) => Writer.WriteImage(text, url, title);

    public override void WriteImageReference(string text, string label) => Writer.WriteImageReference(text, label);

    public override void WriteIndentedCodeBlock(string text) => Writer.WriteIndentedCodeBlock(text);

    public override void WriteInlineCode(string text) => Writer.WriteInlineCode(text);

    public override void WriteLabel(string label, string url, string? title = null) => Writer.WriteLabel(label, url, title);

    public override void WriteLine() => Writer.WriteLine();

    public override void WriteLinkReference(string text, string? label = null) => Writer.WriteLinkReference(text, label);

    public override void WriteRaw(string data) => Writer.WriteRaw(data);

    public override void WriteStartBlockQuote() => Writer.WriteStartBlockQuote();

    public override void WriteStartBold() => Writer.WriteStartBold();

    public override void WriteStartBulletItem() => Writer.WriteStartBulletItem();

    public override void WriteStartHeading(int level) => Writer.WriteStartHeading(level);

    public override void WriteStartItalic() => Writer.WriteStartItalic();

    public override void WriteStartLink() => Writer.WriteStartLink();

    public override void WriteStartOrderedItem(int number) => Writer.WriteStartOrderedItem(number);

    public override void WriteStartStrikethrough() => Writer.WriteStartStrikethrough();

    public override void WriteStartTable(int columnCount) => Writer.WriteStartTable(columnCount);

    public override void WriteStartTable(IReadOnlyList<TableColumnInfo> columns) => Writer.WriteStartTable(columns);

    public override void WriteStartTableCell() => Writer.WriteStartTableCell();

    public override void WriteStartTableRow() => Writer.WriteStartTableRow();

    public override void WriteStartTaskItem(bool isCompleted = false) => Writer.WriteStartTaskItem(isCompleted);

    public override void WriteString(string text) => Writer.WriteString(text);

    public override void WriteTableHeaderSeparator() => Writer.WriteTableHeaderSeparator();

    internal override void WriteStartFencedBlock(string fence, string? info = null) => Writer.WriteStartFencedBlock(fence, info);

    internal override void WriteEndFencedBlock(string fence) => Writer.WriteEndFencedBlock(fence);
}
