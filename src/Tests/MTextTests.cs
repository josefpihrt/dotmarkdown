// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public class MTextTests
    {
        [Fact]
        public void MText_Equals()
        {
            MText markdownText = CreateMarkdownText();

            Assert.True(markdownText.Equals((object)markdownText));
        }

        [Fact]
        public void MText_GetHashCode_Equal()
        {
            MText markdownText = CreateMarkdownText();

            Assert.Equal(markdownText.GetHashCode(), markdownText.GetHashCode());
        }

        [Fact]
        public void MText_OperatorEquals()
        {
            MText markdownText = CreateMarkdownText();
            MText markdownText2 = markdownText;

            Assert.True(markdownText == markdownText2);
        }

        [Fact]
        public void MText_Constructor_AssignText()
        {
            string text = MarkdownTextText();
            var markdownText = new MText(value: text);

            Assert.Equal(text, markdownText.Value);
        }
    }
}
