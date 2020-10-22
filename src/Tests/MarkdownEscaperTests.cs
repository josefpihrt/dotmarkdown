// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Tests
{
    public static class MarkdownEscaperTests
    {
        [Fact]
        public static void MarkdownEscaper_Escape_Chars()
        {
            Assert.Equal(CharsEscaped, MarkdownEscaper.Escape(Chars));
            Assert.Equal(CharsEscaped + NewLine + CharsEscaped, MarkdownEscaper.Escape(Chars + NewLine + Chars));
        }

        [Theory]
        [InlineData("\\", true)]
        [InlineData("`", true)]
        [InlineData("*", true)]
        [InlineData("_", true)]
        [InlineData("{", true)]
        [InlineData("}", true)]
        [InlineData("[", true)]
        [InlineData("]", true)]
        [InlineData("(", true)]
        [InlineData(")", true)]
        [InlineData("#", true)]
        [InlineData("+", true)]
        [InlineData("-", true)]
        [InlineData(".", true)]
        [InlineData("!", true)]
        [InlineData("<", true)]
        [InlineData(">", false)]
        [InlineData("\"", false)]
        [InlineData("'", false)]
        public static void MarkdownEscaper_Escape_SingleChar(string value, bool shouldBeEscaped)
        {
            Assert.Equal((shouldBeEscaped) ? "\\" + value : value, MarkdownEscaper.Escape(value));
        }

        [Theory]
        [InlineData("\\", false)]
        [InlineData("`", false)]
        [InlineData("*", false)]
        [InlineData("_", false)]
        [InlineData("{", false)]
        [InlineData("}", false)]
        [InlineData("[", false)]
        [InlineData("]", false)]
        [InlineData("(", false)]
        [InlineData(")", false)]
        [InlineData("#", false)]
        [InlineData("+", false)]
        [InlineData("-", false)]
        [InlineData(".", false)]
        [InlineData("!", false)]
        [InlineData("<", false)]
        [InlineData(">", false)]
        [InlineData("\"", false)]
        [InlineData("'", false)]
        public static void MarkdownEscaper_Escape_NoEscape(string value, bool shouldBeEscaped)
        {
            Assert.Equal(
                (shouldBeEscaped) ? "\\" + value : value,
                MarkdownEscaper.Escape(value, shouldBeEscaped: ch => false, escapingChar: '\\'));
        }

        [Theory]
        [InlineData('\\', true)]
        [InlineData('`', true)]
        [InlineData('*', true)]
        [InlineData('_', true)]
        [InlineData('{', true)]
        [InlineData('}', true)]
        [InlineData('[', true)]
        [InlineData(']', true)]
        [InlineData('(', true)]
        [InlineData(')', true)]
        [InlineData('#', true)]
        [InlineData('+', true)]
        [InlineData('-', true)]
        [InlineData('.', true)]
        [InlineData('!', true)]
        [InlineData('<', true)]
        [InlineData('>', false)]
        [InlineData('"', false)]
        [InlineData('\'', false)]
        public static void MarkdownEscaper_ShouldBeEscaped(char ch, bool shouldBeEscaped)
        {
            Assert.Equal(MarkdownEscaper.ShouldBeEscaped(ch), shouldBeEscaped);
        }

        [Theory]
        [InlineData('\\', false)]
        [InlineData('`', true)]
        [InlineData('*', false)]
        [InlineData('_', false)]
        [InlineData('{', false)]
        [InlineData('}', false)]
        [InlineData('[', true)]
        [InlineData(']', true)]
        [InlineData('(', false)]
        [InlineData(')', false)]
        [InlineData('#', false)]
        [InlineData('+', false)]
        [InlineData('-', false)]
        [InlineData('.', false)]
        [InlineData('!', false)]
        [InlineData('<', true)]
        [InlineData('>', false)]
        [InlineData('"', false)]
        [InlineData('\'', false)]
        public static void MarkdownEscaper_ShouldBeEscapedInLinkText(char ch, bool shouldBeEscaped)
        {
            Assert.Equal(MarkdownEscaper.ShouldBeEscapedInLinkText(ch), shouldBeEscaped);
        }

        [Theory]
        [InlineData('\\', false)]
        [InlineData('`', false)]
        [InlineData('*', false)]
        [InlineData('_', false)]
        [InlineData('{', false)]
        [InlineData('}', false)]
        [InlineData('[', false)]
        [InlineData(']', false)]
        [InlineData('(', true)]
        [InlineData(')', true)]
        [InlineData('#', false)]
        [InlineData('+', false)]
        [InlineData('-', false)]
        [InlineData('.', false)]
        [InlineData('!', false)]
        [InlineData('<', false)]
        [InlineData('>', false)]
        [InlineData('"', false)]
        [InlineData('\'', false)]
        public static void MarkdownEscaper_ShouldBeEscapedInLinkUrl(char ch, bool shouldBeEscaped)
        {
            Assert.Equal(MarkdownEscaper.ShouldBeEscapedInLinkUrl(ch), shouldBeEscaped);
        }

        [Theory]
        [InlineData('\\', false)]
        [InlineData('`', false)]
        [InlineData('*', false)]
        [InlineData('_', false)]
        [InlineData('{', false)]
        [InlineData('}', false)]
        [InlineData('[', false)]
        [InlineData(']', false)]
        [InlineData('(', false)]
        [InlineData(')', false)]
        [InlineData('#', false)]
        [InlineData('+', false)]
        [InlineData('-', false)]
        [InlineData('.', false)]
        [InlineData('!', false)]
        [InlineData('<', false)]
        [InlineData('>', false)]
        [InlineData('"', true)]
        [InlineData('\'', false)]
        public static void MarkdownEscaper_ShouldBeEscapedInLinkTitle(char ch, bool shouldBeEscaped)
        {
            Assert.Equal(MarkdownEscaper.ShouldBeEscapedInLinkTitle(ch), shouldBeEscaped);
        }
    }
}
