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
    public static class MarkdownWriterTests
    {
        private const string Value = Chars;
        private const string ValueEscaped = CharsEscaped;

        [Theory]
        [InlineData("**", null)]
        [InlineData("**", EmphasisStyle.Asterisk)]
        [InlineData("__", EmphasisStyle.Underscore)]
        public static void MarkdownWriter_WriteBold(string syntax, EmphasisStyle? boldStyle)
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
        public static void MarkdownWriter_Write_Bold(string syntax, EmphasisStyle? boldStyle)
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
        public static void MarkdownWriter_WriteItalic(string syntax, EmphasisStyle? ItalicStyle)
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
        public static void MarkdownWriter_Write_Italic(string syntax, EmphasisStyle? italicStyle)
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateBuilderWithItalicStyle(italicStyle);
            mw.Write(Italic(x));

            Assert.Equal(syntax + y + syntax, mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteStrikethrough()
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateWriter();
            mw.WriteStrikethrough(x);

            Assert.Equal("~~" + y + "~~", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_Write_Strikethrough()
        {
            const string x = Chars;
            const string y = CharsEscaped;
            MarkdownWriter mw = CreateWriter();
            mw.Write(Strikethrough(x));

            Assert.Equal("~~" + y + "~~", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteInlineCode_WithBacktick()
        {
            const string x = CharsEnclosedWithBacktick;
            const string y = CharsEnclosedWithBacktick;
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode(x);

            Assert.Equal("`` " + y + " ``", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteInlineCode_WithoutBacktick()
        {
            const string x = CharsWithoutBacktick;
            const string y = CharsWithoutBacktick;
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode(x);

            Assert.Equal("`" + y + "`", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteInlineCode()
        {
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode("`");

            Assert.Equal("`` ` ``", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteInlineCode2()
        {
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode("`` ` ``");

            Assert.Equal("``` `` ` `` ```", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteInlineCode3()
        {
            MarkdownWriter mw = CreateWriter();
            mw.WriteInlineCode("`` ``` ``");

            Assert.Equal("` `` ``` `` `", mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_Write_InlineCode()
        {
            const string x = CharsEnclosedWithBacktick;
            const string y = CharsEnclosedWithBacktick;
            MarkdownWriter mw = CreateWriter();
            mw.Write(InlineCode(x));

            Assert.Equal("`` " + y + " ``", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading2 | HeadingOptions.EmptyLineAfter)]
        public static void MarkdownWriter_WriteHeading1(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading1(Value);

            Assert.Equal($"# {ValueEscaped}{NewLine2}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null)]
        [InlineData(HeadingOptions.None | HeadingOptions.EmptyLineAfter)]
        [InlineData(HeadingOptions.UnderlineHeading1 | HeadingOptions.EmptyLineAfter)]
        public static void MarkdownWriter_WriteHeading2(HeadingOptions? options)
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
        public static void MarkdownWriter_WriteHeading3(HeadingOptions? options)
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
        public static void MarkdownWriter_WriteHeading4(HeadingOptions? options)
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
        public static void MarkdownWriter_WriteHeading5(HeadingOptions? options)
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
        public static void MarkdownWriter_WriteHeading6(HeadingOptions? options)
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
        public static void MarkdownWriter_WriteHeading(int level)
        {
            MarkdownWriter mw = CreateWriter(new MarkdownFormat(headingOptions: HeadingOptions.None));
            mw.WriteHeading(level, Value);

            Assert.Equal($"{new string('#', level)} {ValueEscaped}{NewLine}", mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public static void MarkdownWriter_WriteHeading_Throws(int level)
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHeading(level, Value));
        }

        [Fact]
        public static void MarkdownWriter_WriteHeading_Params()
        {
            MarkdownWriter mw = CreateWriter(new MarkdownFormat(headingOptions: HeadingOptions.None));
        }

        [Theory]
        [InlineData(HeadingOptions.UnderlineHeading1)]
        [InlineData(HeadingOptions.Underline)]
        public static void MarkdownWriter_WriteHeading_UnderlineH1(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading1(Value);

            Assert.Equal(ValueEscaped + NewLine + new string('=', ValueEscaped.Length) + NewLine, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(HeadingOptions.UnderlineHeading2)]
        [InlineData(HeadingOptions.Underline)]
        public static void MarkdownWriter_WriteHeading_UnderlineH2(HeadingOptions? options)
        {
            MarkdownWriter mw = CreateBuilderWithHeadingOptions(options);
            mw.WriteHeading2(Value);

            Assert.Equal(ValueEscaped + NewLine + new string('-', ValueEscaped.Length) + NewLine, mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteHeading_EmptyLineBefore()
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
        public static void MarkdownWriter_WriteHeading_EmptyLineAfter()
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
        public static void MarkdownWriter_WriteHeading_EmptyLineBeforeAfter()
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
        public static void MarkdownWriter_WriteHorizontalRule_Throws(int count)
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHorizontalRule(style: HorizontalRuleStyle.Asterisk, count: count, separator: ""));
            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHorizontalRule(style: HorizontalRuleStyle.Hyphen, count: count, separator: ""));
            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteHorizontalRule(style: HorizontalRuleStyle.Underscore, count: count, separator: ""));
        }

        [Fact]
        public static void MarkdownWriter_WriteImage()
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
        public static void MarkdownWriter_WriteImage_NoTitle()
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
        public static void MarkdownWriter_Write_Image()
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
        public static void MarkdownWriter_Write_Image_NoTitle()
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
        public static void MarkdownWriter_WriteImage_Throws()
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentNullException>(() => mw.WriteImage(text: null, url: "Url"));
            Assert.Throws<ArgumentNullException>(() => mw.WriteImage(text: "Text", url: null));
        }

        [Fact]
        public static void MarkdownWriter_WriteLink()
        {
            MarkdownWriter mw = CreateWriter();

            const string linkText = "LinkText";
            const string linkUrl = "LinkUrl";
            const string linkTitle = "LinkTitle";

            const string text = linkText + Chars;
            const string url = linkUrl + CharsWithoutSpaces;
            const string title = linkTitle + Chars;

            string expected = $"[{linkText + CharsSquareBracketsBacktickLessThanEscaped}]({linkUrl + CharsWithoutSpacesParenthesesEscaped} \"{linkTitle + CharsDoubleQuoteEscaped}\")";

            mw.WriteLink(text, url, title);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteLink_NoTitle()
        {
            MarkdownWriter mw = CreateWriter();

            const string linkText = "LinkText";
            const string linkUrl = "LinkUrl";

            const string text = linkText + Chars;
            const string url = linkUrl + CharsWithoutSpaces;

            string expected = $"[{linkText + CharsSquareBracketsBacktickLessThanEscaped}]({linkUrl + CharsWithoutSpacesParenthesesEscaped})";

            mw.WriteLink(text, url);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_WriteLink_TextWithContent()
        {
            MarkdownWriter mw = CreateWriter();

            string expected = $"[**b** *i* ~~s~~ `c` {CharsSquareBracketsBacktickLessThanEscaped}](u{CharsWithoutSpacesParenthesesEscaped} \"t{CharsDoubleQuoteEscaped}\")";

            mw.WriteStartLink();
            mw.WriteBold("b");
            mw.WriteString(" ");
            mw.WriteItalic("i");
            mw.WriteString(" ");
            mw.WriteStrikethrough("s");
            mw.WriteString(" ");
            mw.WriteInlineCode("c");
            mw.WriteString(" ");
            mw.WriteString(Chars);
            mw.WriteEndLink($"u{CharsWithoutSpaces}", $"t{Chars}");

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_Write_Link()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "LinkText";
            const string url = "LinkUrl";
            const string title = "LinkTitle";

            MLink link = Link(text + Chars, url + CharsWithoutSpaces, title + Chars);

            string expected = $"[{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped} \"{title + CharsDoubleQuoteEscaped}\")";

            Assert.Equal(expected, mw.Write2(link).ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_Write_Link_NoTitle()
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "LinkText";
            const string url = "LinkUrl";

            MLink link = Link(text + Chars, url + CharsWithoutSpaces);

            string expected = $"[{text + CharsSquareBracketsBacktickLessThanEscaped}]({url + CharsWithoutSpacesParenthesesEscaped})";

            mw.Write(link);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("*", null)]
        [InlineData("*", BulletListStyle.Asterisk)]
        [InlineData("-", BulletListStyle.Minus)]
        [InlineData("+", BulletListStyle.Plus)]
        public static void MarkdownWriter_WriteBulletItem(string syntax, BulletListStyle? style)
        {
            MarkdownWriter mw = CreateBuilderWithBulletItemStyle(style);
            const string text = "BulletItemText";
            string expected = syntax + " " + text + CharsEscaped + NewLine + "  " + syntax + " " + text + NewLine;
            MBulletItem item = BulletItem(text + Chars, BulletItem(text));
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("*", null)]
        [InlineData("*", BulletListStyle.Asterisk)]
        [InlineData("-", BulletListStyle.Minus)]
        [InlineData("+", BulletListStyle.Plus)]
        public static void MarkdownWriter_Write_BulletItem(string syntax, BulletListStyle? style)
        {
            MarkdownWriter mw = CreateBuilderWithBulletItemStyle(style);
            const string text = "BulletItemText";
            string expected = syntax + " " + text + CharsEscaped + NewLine + "  " + syntax + " " + text + NewLine;
            MBulletItem item = BulletItem(text + Chars, BulletItem(text));

            mw.Write(item);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(0, "   ")]
        [InlineData(1, "   ")]
        [InlineData(10, "    ")]
        [InlineData(100, "     ")]
        public static void MarkdownWriter_WriteOrderedItem(int number, string indentation)
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "OrderedItemText";

            string expected = number + ". " + text + CharsEscaped + NewLine + indentation + number + ". " + text + NewLine;
            MOrderedItem item = OrderedItem(number, text + Chars, OrderedItem(number, text));

            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(0, "   ")]
        [InlineData(1, "   ")]
        [InlineData(10, "    ")]
        [InlineData(100, "     ")]
        public static void MarkdownWriter_Write_OrderedItem(int number, string indentation)
        {
            MarkdownWriter mw = CreateWriter();

            const string text = "OrderedItemText";

            string expected = number + ". " + text + CharsEscaped + NewLine + indentation + number + ". " + text + NewLine;
            MOrderedItem item = OrderedItem(number, text + Chars, OrderedItem(number, text));
            mw.Write(item);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(-2)]
        [InlineData(-1)]
        public static void MarkdownWriter_WriteOrderedItem_Throws(int number)
        {
            MarkdownWriter mw = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mw.WriteOrderedItem(number, StringValue()));
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public static void MarkdownWriter_WriteTaskItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [ ] ";
            string expected = start + text2 + CharsEscaped + NewLine + "  " + start + text2 + NewLine;
            MTaskItem item = TaskItem(false, text + Chars, TaskItem(false, text));
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public static void MarkdownWriter_Write_TaskItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [ ] ";
            string expected = start + text2 + CharsEscaped + NewLine + "  " + start + text2 + NewLine;
            MTaskItem item = TaskItem(false, text + Chars, TaskItem(false, text));
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public static void MarkdownWriter_Write_TaskItem_Completed(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [x] ";
            string expected = start + text2 + CharsEscaped + NewLine + "  " + start + text2 + NewLine;
            MTaskItem item = TaskItem(true, text + Chars, TaskItem(true, text));
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(Chars, CharsEscaped)]
        public static void MarkdownWriter_WriteCompletedTaskItem(string text, string text2)
        {
            MarkdownWriter mw = CreateWriter();
            const string start = "- [x] ";
            string expected = start + text2 + CharsEscaped + NewLine + "  " + start + text2 + NewLine;
            MTaskItem item = CompletedTaskItem(text + Chars, CompletedTaskItem(text));
            item.WriteTo(mw);

            Assert.Equal(expected, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData("```", null)]
        [InlineData("```", CodeFenceStyle.Backtick)]
        [InlineData("~~~", CodeFenceStyle.Tilde)]
        public static void MarkdownWriter_Write_CodeBlock_CodeFenceStyle(string syntax, CodeFenceStyle? style)
        {
            MarkdownWriter mw = CreateBuilderWithCodeFenceOptions(style);

            MFencedCodeBlock block = FencedCodeBlock(Chars, DefaultText);
            block.WriteTo(mw);

            Assert.Equal(
                syntax + DefaultText + NewLine + Chars + NewLine + syntax + NewLine2,
                mw.ToStringAndClear());
        }

        [Fact]
        public static void MarkdownWriter_Write_CodeBlock_CodeBlockOptionsNone()
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
        public static void MarkdownWriter_Write_CodeBlock_CodeBlockOptionsEmptyLineBefore()
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
        public static void MarkdownWriter_Write_CodeBlock_CodeBlockOptionsEmptyLineAfter()
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
        public static void MarkdownWriter_Write_CodeBlock_CodeBlockOptionsEmptyLineBeforeAndAfter()
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
        public static void MarkdownWriter_WriteBlockQuote(string text1, string text2)
        {
            MarkdownWriter mw = CreateWriter();

            mw.WriteBlockQuote(text1);

            Assert.Equal(text2, mw.ToStringAndClear());
        }

        [Theory]
        [InlineData(Chars, "> " + CharsEscaped + NewLine)]
        [InlineData(Chars + NewLine + Chars, "> " + CharsEscaped + NewLine + "> " + CharsEscaped + NewLine)]
        public static void MarkdownWriter_Write_BlockQuote(string text1, string text2)
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
        public static void MarkdownWriter_WriteHtmlEntity(string syntax, string format, CharEntityFormat? htmlEntityFormat)
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
        public static void MarkdownWriter_Write_HtmlEntity(string syntax, string format, CharEntityFormat? htmlEntityFormat)
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
