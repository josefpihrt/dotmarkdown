// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Linq.MFactory;
using static DotMarkdown.Tests.MarkdownSamples;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public class MarkdownWriterTests
    {
        private const string Value = Chars;
        private const string ValueEscaped = CharsEscaped;

        [Theory]
        [InlineData("**", null)]
        [InlineData("**", EmphasisStyle.Asterisk)]
        [InlineData("__", EmphasisStyle.Underscore)]
        public void MarkdownWriter_AppendBold(string syntax, EmphasisStyle? boldStyle)
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateBuilderWithBoldStyle(boldStyle);
            mw.WriteBold(x);

            Assert.Equal(syntax + y + syntax, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("**", null)]
        [InlineData("**", EmphasisStyle.Asterisk)]
        [InlineData("__", EmphasisStyle.Underscore)]
        public void MarkdownWriter_Append_Bold(string syntax, EmphasisStyle? boldStyle)
        {
            const string x = Chars;
            const string y = CharsEscaped;

            MarkdownWriter mw = CreateBuilderWithBoldStyle(boldStyle);
            mw.Write(Bold(x));

            Assert.Equal(syntax + y + syntax, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("*", null)]
        [InlineData("*", EmphasisStyle.Asterisk)]
        [InlineData("_", EmphasisStyle.Underscore)]
        public void MarkdownWriter_AppendItalic(string syntax, EmphasisStyle? ItalicStyle)
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateBuilderWithItalicStyle(ItalicStyle);
            mw.WriteItalic(x);

            Assert.Equal(syntax + y + syntax, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("*", null)]
        [InlineData("*", EmphasisStyle.Asterisk)]
        [InlineData("_", EmphasisStyle.Underscore)]
        public void MarkdownWriter_Append_Italic(string syntax, EmphasisStyle? italicStyle)
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateBuilderWithItalicStyle(italicStyle);
            mw.Write(Italic(x));

            Assert.Equal(syntax + y + syntax, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendStrikethrough()
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateWriter();
            mw.WriteStrikethrough(x);

            Assert.Equal("~~" + y + "~~", mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_Strikethrough()
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateWriter();
            mw.Write(Strikethrough(x));

            Assert.Equal("~~" + y + "~~", mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendCode()
        {
            const string x = CharsEnclosedWithBacktick;
            const string y = CharsEnclosedWithBacktickDoubled;
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode(x);

            Assert.Equal("` " + y + " `", mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendCode_String()
        {
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode("`");

            Assert.Equal("` `` `", mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_InlineCode()
        {
            const string x = CharsEnclosedWithBacktick;
            const string y = CharsEnclosedWithBacktickDoubled;
            MarkdownWriter mw = CreateWriter();
            mw.Write(InlineCode(x));

            Assert.Equal("` " + y + " `", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading2 | HeadingOptions.EmptyLineAfter)]
        public void MarkdownWriter_AppendHeading1(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading1(Value);

            Assert.Equal($"# {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading1 | HeadingOptions.EmptyLineAfter)]
        public void MarkdownWriter_AppendHeading2(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading2(Value);

            Assert.Equal($"## {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading1 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading2 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.Underline | HeadingOptions.EmptyLineAfter)]
        public void MarkdownWriter_AppendHeading3(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading3(Value);

            Assert.Equal($"### {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading1 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading2 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.Underline | HeadingOptions.EmptyLineAfter)]
        public void MarkdownWriter_AppendHeading4(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading4(Value);

            Assert.Equal($"#### {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading1 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading2 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.Underline | HeadingOptions.EmptyLineAfter)]
        public void MarkdownWriter_AppendHeading5(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading5(Value);

            Assert.Equal($"##### {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading1 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading2 | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.Underline | HeadingOptions.EmptyLineAfter)]
        public void MarkdownWriter_AppendHeading6(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading6(Value);

            Assert.Equal($"###### {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void MarkdownWriter_AppendHeading(int level)
        {
            MarkdownWriter mw = CreateWriter(new MarkdownFormat(headingOptions: HeadingOptions.None));
            mw.WriteHeading(level, Value);

            Assert.Equal($"{new string('#', level)} {ValueEscaped}{NewLine}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public void MarkdownWriter_AppendHeading_Throws(int level)
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHeading(level, Value));
        }

        [Fact]
        public void MarkdownWriter_AppendHeading_Params()
        {
            MarkdownWriter mw = CreateWriter(new MarkdownFormat(headingOptions: HeadingOptions.None));
        }

        [Theory]
        [InlineData(HeadingOptions.UnderlineHeading1)]
        [InlineData(HeadingOptions.Underline)]
        public void MarkdownWriter_AppendHeading_UnderlineH1(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading1(Value);

            Assert.Equal(ValueEscaped + NewLine + new string('=', ValueEscaped.Length) + NewLine, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(HeadingOptions.UnderlineHeading2)]
        [InlineData(HeadingOptions.Underline)]
        public void MarkdownWriter_AppendHeading_UnderlineH2(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading2(Value);

            Assert.Equal(ValueEscaped + NewLine + new string('-', ValueEscaped.Length) + NewLine, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendHeading_EmptyLineBefore()
        {
            string text = HeadingText();
            const string s = "# " + CharsEscaped + NewLine;
            MHeading heading = Heading(1, Chars);
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(HeadingOptions.EmptyLineBefore);
            mw.WriteString(text);
            mw.Write(heading);
            mw.Write(heading);
            mw.Write(text);

            Assert.Equal(
                text + NewLine2 + s + NewLine + s + text,
                mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendHeading_EmptyLineAfter()
        {
            string text = HeadingText();
            const string s = "# " + CharsEscaped + NewLine;
            MHeading heading = Heading(1, Chars);
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(HeadingOptions.EmptyLineAfter);
            mw.WriteString(text);
            mw.Write(heading);
            mw.Write(heading);
            mw.Write(text);

            Assert.Equal(
                text + NewLine + s + NewLine + s + NewLine + text,
                mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendHeading_EmptyLineBeforeAfter()
        {
            string text = HeadingText();
            const string s = "# " + CharsEscaped + NewLine;
            MHeading heading = Heading(1, Chars);
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(HeadingOptions.EmptyLineBeforeAndAfter);
            mw.Write(text);
            mw.Write(heading);
            mw.Write(heading);
            mw.Write(text);

            Assert.Equal(
                text + NewLine2 + s + NewLine + s + NewLine + text,
                mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void MarkdownWriter_AppendHorizontalRule_Throws(int count)
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHorizontalRule(style: HorizontalRuleStyle.Asterisk, count: count, separator: ""));
            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHorizontalRule(style: HorizontalRuleStyle.Hyphen, count: count, separator: ""));
            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHorizontalRule(style: HorizontalRuleStyle.Underscore, count: count, separator: ""));
        }

        [Fact]
        public void MarkdownWriter_AppendImage()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "ImageText";
            const string url = "ImageUrl";
            const string title = "ImageTitle";

            MImage image = Image(text + Chars, url + CharsWithoutSpaces, title + Chars);

            string expected = $"![{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped} \"{title + CharsDoubleQuoteEscaped}\")";

            mw.WriteImage(image.Text, image.Url, image.Title);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendImage_NoTitle()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "ImageText";
            const string url = "ImageUrl";

            MImage image = Image(text + Chars, url + CharsWithoutSpaces);

            string expected = $"![{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped})";

            mw.WriteImage(image.Text, image.Url);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_Image()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "ImageText";
            const string url = "ImageUrl";
            const string title = "ImageTitle";

            MImage image = Image(text + Chars, url + CharsWithoutSpaces, title + Chars);

            string expected = $"![{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped} \"{title + CharsDoubleQuoteEscaped}\")";

            mw.Write(image);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_Image_NoTitle()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "ImageText";
            const string url = "ImageUrl";

            MImage image = Image(text + Chars, url + CharsWithoutSpaces);

            string expected = $"![{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped})";

            mw.Write(image);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendImage_Throws()
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentNullException>(() => mw.WriteImage(text: null, url: "Url"));
            Assert.Throws<ArgumentNullException>(() => mw.WriteImage(text: "Text", url: null));
        }

        [Fact]
        public void MarkdownWriter_AppendLink()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "LinkText";
            const string url = "LinkUrl";
            const string title = "LinkTitle";

            MLink image = Link(text + Chars, url + CharsWithoutSpaces, title + Chars);

            string expected = $"[{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped} \"{title + CharsDoubleQuoteEscaped}\")";

            mw.WriteLink(image.Text, image.Url, image.Title);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_AppendLink_NoTitle()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "LinkText";
            const string url = "LinkUrl";

            MLink image = Link(text + Chars, url + CharsWithoutSpaces);

            string expected = $"[{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped})";

            mw.WriteLink(image.Text, image.Url);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_Link()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "LinkText";
            const string url = "LinkUrl";
            const string title = "LinkTitle";

            MLink image = Link(text + Chars, url + CharsWithoutSpaces, title + Chars);

            string expected = $"[{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped} \"{title + CharsDoubleQuoteEscaped}\")";

            Assert.Equal(expected, mw.Write2(image).ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_Link_NoTitle()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "LinkText";
            const string url = "LinkUrl";

            MLink image = Link(text + Chars, url + CharsWithoutSpaces);

            string expected = $"[{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped})";

            mw.Write(image);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("*", null)]
        [InlineData("*", BulletListStyle.Asterisk)]
        [InlineData("-", BulletListStyle.Minus)]
        [InlineData("+", BulletListStyle.Plus)]
        public void MarkdownWriter_AppendListItem(string syntax, BulletListStyle? style)
        {
            MarkdownWriter mw = CreateBuilderWithListItemStyle(style);
            const string text = "ListItemText";
            string expected = syntax + $" {text + CharsEscaped}" + NewLine;
            MBulletItem item = BulletItem(text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("*", null)]
        [InlineData("*", BulletListStyle.Asterisk)]
        [InlineData("-", BulletListStyle.Minus)]
        [InlineData("+", BulletListStyle.Plus)]
        public void MarkdownWriter_Append_ListItem(string syntax, BulletListStyle? style)
        {
            MarkdownWriter mw = CreateBuilderWithListItemStyle(style);
            const string text = "ListItemText";
            string expected = syntax + $" {text + CharsEscaped}" + NewLine;
            MBulletItem item = BulletItem(text + Chars);

            mw.Write(item);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void MarkdownWriter_AppendOrderedListItem(int number)
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "OrderedListItemText";

            string expected = number + $". {text + CharsEscaped}" + NewLine;
            MOrderedItem item = OrderedItem(number, text + Chars);

            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void MarkdownWriter_Append_OrderedListItem(int number)
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "OrderedListItemText";

            string expected = number + $". {text + CharsEscaped}" + NewLine;
            MOrderedItem item = OrderedItem(number, text + Chars);
            mw.Write(item);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(-2)]
        [InlineData(-1)]
        public void MarkdownWriter_AppendOrderedListItem_Throws(int number)
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteOrderedItem(number, StringValue()));
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public void MarkdownWriter_AppendTaskListItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [ ] ";
            string expected = start + text2 + CharsEscaped + NewLine;
            MTaskItem item = TaskItem(false, text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public void MarkdownWriter_Append_TaskListItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [ ] ";
            string expected = start + text2 + CharsEscaped + NewLine;
            MTaskItem item = TaskItem(false, text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public void MarkdownWriter_Append_TaskListItem_NotCompleted(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [ ] ";
            string expected = start + text2 + CharsEscaped + NewLine;
            MTaskItem item = TaskItem(false, text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public void MarkdownWriter_Append_TaskListItem_Completed(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [x] ";
            string expected = start + text2 + CharsEscaped + NewLine;
            MTaskItem item = TaskItem(true, text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public void MarkdownWriter_AppendCompletedTaskListItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [x] ";
            string expected = start + text2 + CharsEscaped + NewLine;
            MTaskItem item = CompletedTaskItem(text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public void MarkdownWriter_Append_CompletedTaskListItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [x] ";
            string expected = start + text2 + CharsEscaped + NewLine;
            MTaskItem item = CompletedTaskItem(text + Chars);
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("```", null)]
        [InlineData("```", CodeFenceStyle.Backtick)]
        [InlineData("~~~", CodeFenceStyle.Tilde)]
        public void MarkdownWriter_Append_CodeBlock_CodeFenceStyle(string syntax, CodeFenceStyle? style)
        {
            MarkdownWriter mw = CreateBuilderWithCodeFenceOptions(style);

            MFencedCodeBlock block = FencedCodeBlock(Chars, DefaultText);
            block.WriteTo(mw);

            Assert.Equal(
                syntax + DefaultText + NewLine + Chars + NewLine + syntax + NewLine2,
                mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_CodeBlock_CodeBlockOptionsNone()
        {
            MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.None);

            MFencedCodeBlock block = FencedCodeBlock(Chars, DefaultText);

            mw.Write(DefaultText);
            mw.Write(block);
            mw.Write(block);
            mw.Write(DefaultText);

            Assert.Equal(
                DefaultText + NewLine + CodeBlockMarkdown + CodeBlockMarkdown + DefaultText,
                mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_CodeBlock_CodeBlockOptionsEmptyLineBefore()
        {
            MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.EmptyLineBefore);

            MFencedCodeBlock block = FencedCodeBlock(Chars, DefaultText);

            mw.Write(DefaultText);
            mw.Write(block);
            mw.Write(block);
            mw.Write(DefaultText);

            Assert.Equal(
                DefaultText + NewLine2 + CodeBlockMarkdown + NewLine + CodeBlockMarkdown + DefaultText,
                mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_CodeBlock_CodeBlockOptionsEmptyLineAfter()
        {
            MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.EmptyLineAfter);

            MFencedCodeBlock block = FencedCodeBlock(Chars, DefaultText);

            mw.Write(DefaultText);
            mw.Write(block);
            mw.Write(block);
            mw.Write(DefaultText);

            Assert.Equal(
                DefaultText + NewLine + CodeBlockMarkdown + NewLine + CodeBlockMarkdown + NewLine + DefaultText,
                mw.ToStringAndClear());
        }

        [Fact]
        public void MarkdownWriter_Append_CodeBlock_CodeBlockOptionsEmptyLineBeforeAndAfter()
        {
            MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.EmptyLineBeforeAndAfter);

            MFencedCodeBlock block = FencedCodeBlock(Chars, DefaultText);

            mw.Write(DefaultText);
            mw.Write(block);
            mw.Write(block);
            mw.Write(DefaultText);

            Assert.Equal(
                DefaultText + NewLine2 + CodeBlockMarkdown + NewLine + CodeBlockMarkdown + NewLine + DefaultText,
                mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(Chars, "> " + CharsEscaped + NewLine)]
        [InlineData(Chars + NewLine + Chars, "> " + CharsEscaped + NewLine + "> " + CharsEscaped + NewLine)]
        public void MarkdownWriter_AppendBlockQuote(string text1, string text2)
        {
            MarkdownWriter mw = CreateWriter();

            mw.WriteBlockQuote(text1);

            Assert.Equal(text2, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(Chars, "> " + CharsEscaped + NewLine)]
        [InlineData(Chars + NewLine + Chars, "> " + CharsEscaped + NewLine + "> " + CharsEscaped + NewLine)]
        public void MarkdownWriter_Append_BlockQuote(string text1, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            MBlockQuote blockQuote = BlockQuote(text1);

            mw.Write(blockQuote);

            Assert.Equal(text2, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("&#x", "X", null)]
        [InlineData("&#x", "X", CharEntityFormat.Hexadecimal)]
        [InlineData("&#", null, CharEntityFormat.Decimal)]
        public void MarkdownWriter_AppendHtmlEntity(string syntax, string format, CharEntityFormat? htmlEntityFormat)
        {
            MarkdownWriter mw = CreateBuilderWithHtmlEntityFormat(htmlEntityFormat);

            char ch = CharEntityChar();

            MCharEntity entity = CharEntity(ch);
            mw.WriteCharEntity(ch);

            Assert.Equal(syntax + ((int)ch).ToString(format, CultureInfo.InvariantCulture) + ";", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("&#x", "X", null)]
        [InlineData("&#x", "X", CharEntityFormat.Hexadecimal)]
        [InlineData("&#", null, CharEntityFormat.Decimal)]
        public void MarkdownWriter_Append_HtmlEntity(string syntax, string format, CharEntityFormat? htmlEntityFormat)
        {
            MarkdownWriter mw = CreateBuilderWithHtmlEntityFormat(htmlEntityFormat);

            char ch = CharEntityChar();

            MCharEntity charEntity = CharEntity(ch);

            mw.Write(charEntity);

            string s = ((int)ch).ToString(format, CultureInfo.InvariantCulture);

            Assert.Equal(syntax + ((int)ch).ToString(format, CultureInfo.InvariantCulture) + ";", mw.ToStringAndClear());
        }
    }
}
