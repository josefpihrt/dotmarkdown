// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace DotMarkdown.Linq
{
    public static class MFactory
    {
        public static MDocument Document()
        {
            return new MDocument();
        }

        public static MDocument Document(object content)
        {
            return new MDocument(content);
        }

        public static MDocument Document(params object[] content)
        {
            return new MDocument(content);
        }

        public static MDocument Document(MDocument other)
        {
            return new MDocument(other);
        }

        public static MRaw Raw(string text)
        {
            return new MRaw(text);
        }

        public static MRaw Raw(MRaw other)
        {
            return new MRaw(other);
        }

        public static MBold Bold()
        {
            return new MBold();
        }

        public static MBold Bold(object content)
        {
            return new MBold(content);
        }

        public static MBold Bold(params object[] content)
        {
            return new MBold(content);
        }

        public static MBold Bold(MBold other)
        {
            return new MBold(other);
        }

        public static MItalic Italic()
        {
            return new MItalic();
        }

        public static MItalic Italic(object content)
        {
            return new MItalic(content);
        }

        public static MItalic Italic(params object[] content)
        {
            return new MItalic(content);
        }

        public static MItalic Italic(MItalic other)
        {
            return new MItalic(other);
        }

        public static MStrikethrough Strikethrough()
        {
            return new MStrikethrough();
        }

        public static MStrikethrough Strikethrough(object content)
        {
            return new MStrikethrough(content);
        }

        public static MStrikethrough Strikethrough(params object[] content)
        {
            return new MStrikethrough(content);
        }

        public static MStrikethrough Strikethrough(MStrikethrough other)
        {
            return new MStrikethrough(other);
        }

        public static MInlineCode InlineCode(string text)
        {
            return new MInlineCode(text);
        }

        public static MInlineCode InlineCode(MInlineCode other)
        {
            return new MInlineCode(other);
        }

        public static MInline Inline()
        {
            return new MInline();
        }

        public static MInline Inline(object content)
        {
            return new MInline(content);
        }

        public static MInline Inline(params object[] content)
        {
            return new MInline(content);
        }

        public static MInline Inline(MInline other)
        {
            return new MInline(other);
        }

        public static MInline Join(object separator, params object[] values)
        {
            return Join(separator, (IEnumerable<MElement>)values);
        }

        public static MInline Join(object separator, IEnumerable<object> values)
        {
            return new MInline(GetContent());

            IEnumerable<object> GetContent()
            {
                bool addSeparator = false;

                foreach (object value in values)
                {
                    if (addSeparator)
                    {
                        yield return separator;
                    }
                    else
                    {
                        addSeparator = true;
                    }

                    yield return value;
                }
            }
        }

        public static MHeading Heading(int level)
        {
            return new MHeading(level);
        }

        public static MHeading Heading(int level, object content)
        {
            return new MHeading(level, content);
        }

        public static MHeading Heading(int level, params object[] content)
        {
            return new MHeading(level, content);
        }

        public static MHeading Heading(MHeading other)
        {
            return new MHeading(other);
        }

        public static MHeading Heading1()
        {
            return Heading(1);
        }

        public static MHeading Heading1(object content)
        {
            return Heading(1, content);
        }

        public static MHeading Heading1(params object[] content)
        {
            return Heading(1, content);
        }

        public static MHeading Heading2()
        {
            return Heading(2);
        }

        public static MHeading Heading2(object content)
        {
            return Heading(2, content);
        }

        public static MHeading Heading2(params object[] content)
        {
            return Heading(2, content);
        }

        public static MHeading Heading3()
        {
            return Heading(3);
        }

        public static MHeading Heading3(object content)
        {
            return Heading(3, content);
        }

        public static MHeading Heading3(params object[] content)
        {
            return Heading(3, content);
        }

        public static MHeading Heading4()
        {
            return Heading(4);
        }

        public static MHeading Heading4(object content)
        {
            return Heading(4, content);
        }

        public static MHeading Heading4(params object[] content)
        {
            return Heading(4, content);
        }

        public static MHeading Heading5()
        {
            return Heading(5);
        }

        public static MHeading Heading5(object content)
        {
            return Heading(5, content);
        }

        public static MHeading Heading5(params object[] content)
        {
            return Heading(5, content);
        }

        public static MHeading Heading6()
        {
            return Heading(6);
        }

        public static MHeading Heading6(object content)
        {
            return Heading(6, content);
        }

        public static MHeading Heading6(params object[] content)
        {
            return Heading(6, content);
        }

        public static MBulletItem BulletItem()
        {
            return new MBulletItem();
        }

        public static MBulletItem BulletItem(object content)
        {
            return new MBulletItem(content);
        }

        public static MBulletItem BulletItem(params object[] content)
        {
            return new MBulletItem(content);
        }

        public static MBulletItem BulletItem(MBulletItem other)
        {
            return new MBulletItem(other);
        }

        public static MOrderedItem OrderedItem(int number)
        {
            return new MOrderedItem(number);
        }

        public static MOrderedItem OrderedItem(int number, object content)
        {
            return new MOrderedItem(number, content);
        }

        public static MOrderedItem OrderedItem(int number, params object[] content)
        {
            return new MOrderedItem(number, content);
        }

        public static MOrderedItem OrderedItem(MOrderedItem other)
        {
            return new MOrderedItem(other);
        }

        public static MTaskItem TaskItem(bool isCompleted)
        {
            return new MTaskItem(isCompleted);
        }

        public static MTaskItem TaskItem(bool isCompleted, object content)
        {
            return new MTaskItem(isCompleted, content);
        }

        public static MTaskItem TaskItem(bool isCompleted, params object[] content)
        {
            return new MTaskItem(isCompleted, content);
        }

        public static MTaskItem TaskItem(MTaskItem other)
        {
            return new MTaskItem(other);
        }

        public static MTaskItem CompletedTaskItem()
        {
            return TaskItem(isCompleted: true);
        }

        public static MTaskItem CompletedTaskItem(object content)
        {
            return TaskItem(isCompleted: true, content: content);
        }

        public static MTaskItem CompletedTaskItem(params object[] content)
        {
            return TaskItem(isCompleted: true, content: content);
        }

        public static MBulletList BulletList()
        {
            return new MBulletList();
        }

        public static MBulletList BulletList(object content)
        {
            return new MBulletList(content);
        }

        public static MBulletList BulletList(params object[] content)
        {
            return new MBulletList(content);
        }

        public static MBulletList BulletList(MBulletList other)
        {
            return new MBulletList(other);
        }

        public static MOrderedList OrderedList()
        {
            return new MOrderedList();
        }

        public static MOrderedList OrderedList(object content)
        {
            return new MOrderedList(content);
        }

        public static MOrderedList OrderedList(params object[] content)
        {
            return new MOrderedList(content);
        }

        public static MOrderedList OrderedList(MOrderedList other)
        {
            return new MOrderedList(other);
        }

        public static MTaskList TaskList()
        {
            return new MTaskList();
        }

        public static MTaskList TaskList(object content)
        {
            return new MTaskList(content);
        }

        public static MTaskList TaskList(params object[] content)
        {
            return new MTaskList(content);
        }

        public static MTaskList TaskList(MTaskList other)
        {
            return new MTaskList(other);
        }

        public static MImage Image(string text, string url, string title = null)
        {
            return new MImage(text, url, title);
        }

        public static MImage Image(MImage other)
        {
            return new MImage(other);
        }

        public static MLink Link(object content, string url, string title = null)
        {
            return new MLink(content, url, title);
        }

        public static MLink Link(MLink other)
        {
            return new MLink(other);
        }

        public static MElement LinkOrText(string text, string url, string title = null)
        {
            if (!string.IsNullOrEmpty(url))
                return new MLink(text, url, title);

            return new MText(text);
        }

        public static MAutolink Autolink(string url)
        {
            return new MAutolink(url);
        }

        public static MAutolink Autolink(MAutolink other)
        {
            return new MAutolink(other);
        }

        public static MElement LinkOrAutolink(string text, string url, string title = null)
        {
            if (!string.IsNullOrEmpty(text))
                return new MLink(text, url, title);

            return new MAutolink(url);
        }

        public static MFencedCodeBlock FencedCodeBlock(string value, string info = null)
        {
            return new MFencedCodeBlock(value, info);
        }

        public static MFencedCodeBlock FencedCodeBlock(MFencedCodeBlock other)
        {
            return new MFencedCodeBlock(other);
        }

        public static MIndentedCodeBlock IndentedCodeBlock(string value)
        {
            return new MIndentedCodeBlock(value);
        }

        public static MIndentedCodeBlock IndentedCodeBlock(MIndentedCodeBlock other)
        {
            return new MIndentedCodeBlock(other);
        }

        public static MBlockQuote BlockQuote()
        {
            return new MBlockQuote();
        }

        public static MBlockQuote BlockQuote(object content)
        {
            return new MBlockQuote(content);
        }

        public static MBlockQuote BlockQuote(params object[] content)
        {
            return new MBlockQuote(content);
        }

        public static MBlockQuote BlockQuote(MBlockQuote other)
        {
            return new MBlockQuote(other);
        }

        public static MHorizontalRule HorizontalRule()
        {
            return HorizontalRule(HorizontalRuleFormat.Default);
        }

        public static MHorizontalRule HorizontalRule(in HorizontalRuleFormat format)
        {
            return new MHorizontalRule(format);
        }

        public static MHorizontalRule HorizontalRule(HorizontalRuleStyle style, int count = HorizontalRuleFormat.DefaultCount, string separator = HorizontalRuleFormat.DefaultSeparator)
        {
            return new MHorizontalRule(style, count, separator);
        }

        public static MCharEntity CharEntity(char value)
        {
            return new MCharEntity(value);
        }

        public static MCharEntity CharEntity(MCharEntity other)
        {
            return new MCharEntity(other);
        }

        public static MEntityRef EntityRef(string name)
        {
            return new MEntityRef(name);
        }

        public static MEntityRef EntityRef(MEntityRef other)
        {
            return new MEntityRef(other);
        }

        public static MEntityRef NonBreakingSpace() => MEntityRef.CreateTrusted("nbsp");

        public static MEntityRef LessThan() => MEntityRef.CreateTrusted("lt");

        public static MEntityRef GreaterThan() => MEntityRef.CreateTrusted("gt");

        public static MEntityRef Ampersand() => MEntityRef.CreateTrusted("amp");

        public static MEntityRef SingleQuote() => MEntityRef.CreateTrusted("apos");

        public static MEntityRef DoubleQuote() => MEntityRef.CreateTrusted("quot");

        public static MTable Table()
        {
            return new MTable();
        }

        public static MTable Table(object content)
        {
            return new MTable(content);
        }

        public static MTable Table(params object[] content)
        {
            return new MTable(content);
        }

        public static MTable Table(MTable other)
        {
            return new MTable(other);
        }

        public static MTableColumn TableColumn(HorizontalAlignment alignment)
        {
            return new MTableColumn(alignment);
        }

        public static MTableColumn TableColumn(HorizontalAlignment alignment, object content)
        {
            return new MTableColumn(alignment, content);
        }

        public static MTableColumn TableColumn(HorizontalAlignment alignment, params object[] content)
        {
            return new MTableColumn(alignment, content);
        }

        public static MTableColumn TableColumn(MTableColumn other)
        {
            return new MTableColumn(other);
        }

        public static MTableRow TableRow()
        {
            return new MTableRow();
        }

        public static MTableRow TableRow(object content)
        {
            return new MTableRow(content);
        }

        public static MTableRow TableRow(params object[] content)
        {
            return new MTableRow(content);
        }

        public static MTableRow TableRow(MTableRow other)
        {
            return new MTableRow(other);
        }
    }
}
