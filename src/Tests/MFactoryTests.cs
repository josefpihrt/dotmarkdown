// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public static class MFactoryTests
    {
        [Fact]
        public static void MFactory_RawText()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Raw(text).Value);
        }

        [Fact]
        public static void MFactory_InlineCode()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.InlineCode(text).Text);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public static void MFactory_Heading(int level)
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading(level, text).content);
            Assert.Equal(level, MFactory.Heading(level, text).Level);
        }

        [Fact]
        public static void MFactory_Heading1()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading1(text).content);
            Assert.Equal(1, MFactory.Heading1(text).Level);
        }

        [Fact]
        public static void MFactory_Heading2()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading2(text).content);
            Assert.Equal(2, MFactory.Heading2(text).Level);
        }

        [Fact]
        public static void MFactory_Heading3()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading3(text).content);
            Assert.Equal(3, MFactory.Heading3(text).Level);
        }

        [Fact]
        public static void MFactory_Heading4()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading4(text).content);
            Assert.Equal(4, MFactory.Heading4(text).Level);
        }

        [Fact]
        public static void MFactory_Heading5()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading5(text).content);
            Assert.Equal(5, MFactory.Heading5(text).Level);
        }

        [Fact]
        public static void MFactory_Heading6()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.Heading6(text).content);
            Assert.Equal(6, MFactory.Heading6(text).Level);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(7)]
        public static void MFactory_Heading_Throws(int level)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MFactory.Heading(level, "x"));
        }

        [Fact]
        public static void MFactory_ListItem()
        {
            string text = MarkdownTextText();
            Assert.Equal(text, MFactory.BulletItem(text).content);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public static void MFactory_OrderedListItem(int number)
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.OrderedItem(number, text).content);
            Assert.Equal(number, MFactory.OrderedItem(number, null).Number);
        }

        [Fact]
        public static void MFactory_TaskListItem_DefaultValues()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.TaskItem(false, text).content);
            Assert.False(MFactory.TaskItem(false, text).IsCompleted);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public static void MFactory_TaskListItem(bool isCompleted)
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.TaskItem(isCompleted, text).content);
            Assert.Equal(isCompleted, MFactory.TaskItem(isCompleted, text).IsCompleted);
        }

        [Fact]
        public static void MFactory_CompletedTaskListItem()
        {
            string text = MarkdownTextText();

            Assert.Equal(text, MFactory.CompletedTaskItem(text).content);
            Assert.True(MFactory.CompletedTaskItem(text).IsCompleted);
        }

        [Fact]
        public static void MFactory_Image_DefaultValues()
        {
            string text = LinkText();
            string url = LinkUrl();
            string title = LinkTitle();

            MImage image = MFactory.Image(text, url);

            Assert.Equal(text, image.Text);
            Assert.Equal(url, image.Url);
            Assert.Null(image.Title);
        }

        [Fact]
        public static void MFactory_Image()
        {
            string text = LinkText();
            string url = LinkUrl();
            string title = LinkTitle();

            MImage image = MFactory.Image(text, url);

            image = MFactory.Image(text, url, title);

            Assert.Equal(text, image.Text);
            Assert.Equal(url, image.Url);
            Assert.Equal(title, image.Title);
        }

        [Fact]
        public static void MFactory_Link_DefaultValues()
        {
            string text = LinkText();
            string url = LinkUrl();
            string title = LinkTitle();

            MLink link = MFactory.Link(text, url);

            Assert.Equal(text, link.content);
            Assert.Equal(url, link.Url);
            Assert.Null(link.Title);
        }

        [Fact]
        public static void MFactory_Link()
        {
            string text = LinkText();
            string url = LinkUrl();
            string title = LinkTitle();

            MLink link = MFactory.Link(text, url, title);

            Assert.Equal(text, link.content);
            Assert.Equal(url, link.Url);
            Assert.Equal(title, link.Title);
        }

        [Fact]
        public static void MFactory_LinkOrText_Link()
        {
            string text = LinkText();
            string url = LinkUrl();

            Assert.IsType<MLink>(MFactory.LinkOrText(text, url));
        }

        [Fact]
        public static void MFactory_LinkOrText_Text()
        {
            string text = LinkText();
            string url = LinkUrl();

            Assert.IsType<MText>(MFactory.LinkOrText(text, url: ""));
            Assert.IsType<MText>(MFactory.LinkOrText(text, url: null));
        }

        [Fact]
        public static void MFactory_Autolink()
        {
            string url = LinkUrl();

            MAutolink autolink = MFactory.Autolink(url);

            Assert.Equal(url, autolink.Url);
        }

        [Fact]
        public static void MFactory_LinkOrAutolink_Link()
        {
            string text = LinkText();
            string url = LinkUrl();

            Assert.IsType<MLink>(MFactory.LinkOrAutolink(text, url));
        }

        [Fact]
        public static void MFactory_LinkOrAutolink_Autolink()
        {
            string text = LinkText();
            string url = LinkUrl();

            Assert.IsType<MAutolink>(MFactory.LinkOrAutolink(text: "", url: url));
            Assert.IsType<MAutolink>(MFactory.LinkOrAutolink(text: null, url: url));
        }

        [Fact]
        public static void MFactory_CodeBlock_DefaultValues()
        {
            string text = CodeBlockText();
            string info = CodeBlockInfo();

            MFencedCodeBlock block = MFactory.FencedCodeBlock(text);

            Assert.Equal(text, block.Text);
            Assert.Null(block.Info);
        }

        [Fact]
        public static void MFactory_CodeBlock()
        {
            string text = CodeBlockText();
            string info = CodeBlockInfo();

            MFencedCodeBlock block = MFactory.FencedCodeBlock(text, info);

            Assert.Equal(text, block.Text);
            Assert.Equal(info, block.Info);
        }

        [Fact]
        public static void MFactory_IndentedCodeBlock()
        {
            string text = IndentedCodeBlockText();

            MIndentedCodeBlock block = MFactory.IndentedCodeBlock(text);

            Assert.Equal(text, block.Text);
        }

        [Fact]
        public static void MFactory_BlockQuote()
        {
            string text = BlockQuoteText();

            MBlockQuote block = MFactory.BlockQuote(text);

            Assert.Equal(text, block.content);
        }

        [Theory]
        [InlineData(HorizontalRuleStyle.Asterisk)]
        [InlineData(HorizontalRuleStyle.Hyphen)]
        [InlineData(HorizontalRuleStyle.Underscore)]
        public static void MFactory_HorizontalRule_DefaultValues(HorizontalRuleStyle style)
        {
            for (int i = 3; i <= 5; i++)
            {
                Assert.Equal(style, MFactory.HorizontalRule(style, count: i).Style);
                Assert.Equal(i, MFactory.HorizontalRule(style, count: i).Count);
                Assert.Equal(" ", MFactory.HorizontalRule(style, count: i).Separator);
            }
        }

        [Theory]
        [InlineData(HorizontalRuleStyle.Asterisk)]
        [InlineData(HorizontalRuleStyle.Hyphen)]
        [InlineData(HorizontalRuleStyle.Underscore)]
        public static void MFactory_HorizontalRule(HorizontalRuleStyle style)
        {
            for (int i = 3; i <= 5; i++)
            {
                Assert.Equal(style, MFactory.HorizontalRule(style, count: i, separator: " ").Style);
                Assert.Equal(i, MFactory.HorizontalRule(style, count: i, separator: " ").Count);
                Assert.Null(MFactory.HorizontalRule(style, count: i, separator: null).Separator);
                Assert.Equal("", MFactory.HorizontalRule(style, count: i, separator: "").Separator);
                Assert.Equal("  ", MFactory.HorizontalRule(style, count: i, separator: "  ").Separator);
            }
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public static void MFactory_HorizontalRule_Throws(int count)
        {
            MarkdownWriter mb = CreateWriter();

            Assert.Throws<ArgumentOutOfRangeException>(() => mb.Write(MFactory.HorizontalRule(style: HorizontalRuleStyle.Asterisk, count: count, separator: " ")));
            Assert.Throws<ArgumentOutOfRangeException>(() => mb.Write(MFactory.HorizontalRule(style: HorizontalRuleStyle.Hyphen, count: count, separator: " ")));
            Assert.Throws<ArgumentOutOfRangeException>(() => mb.Write(MFactory.HorizontalRule(style: HorizontalRuleStyle.Underscore, count: count, separator: " ")));
        }

        [Fact]
        public static void MFactory_HtmlEntity()
        {
            var ch = (char)IntValue(1, 0xFFFF);

            MCharEntity entity = MFactory.CharEntity(ch);

            Assert.Equal(ch, entity.Value);
        }
    }
}
