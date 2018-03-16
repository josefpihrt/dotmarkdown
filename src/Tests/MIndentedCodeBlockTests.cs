// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Tests
{
    public static class MIndentedCodeBlockTests
    {
        [Fact]
        public static void MIndentedCodeBlock_Equals()
        {
            MIndentedCodeBlock block = CreateIndentedCodeBlock();

            Assert.True(block.Equals((object)block));
        }

        [Fact]
        public static void MIndentedCodeBlock_NotEquals()
        {
            MIndentedCodeBlock block = CreateIndentedCodeBlock();
            MIndentedCodeBlock block2 = block.Modify();

            Assert.False(block.Equals((object)block2));
        }

        [Fact]
        public static void MIndentedCodeBlock_GetHashCode_Equal()
        {
            MIndentedCodeBlock block = CreateIndentedCodeBlock();

            Assert.Equal(block.GetHashCode(), block.GetHashCode());
        }

        [Fact]
        public static void MIndentedCodeBlock_GetHashCode_NotEqual()
        {
            MIndentedCodeBlock block = CreateIndentedCodeBlock();
            MIndentedCodeBlock block2 = block.Modify();

            Assert.NotEqual(block.GetHashCode(), block2.GetHashCode());
        }

        [Fact]
        public static void MIndentedCodeBlock_OperatorEquals()
        {
            MIndentedCodeBlock block = CreateIndentedCodeBlock();
            MIndentedCodeBlock block2 = block;

            Assert.True(block == block2);
        }

        [Fact]
        public static void MIndentedCodeBlock_OperatorNotEquals()
        {
            MIndentedCodeBlock block = CreateIndentedCodeBlock();
            MIndentedCodeBlock block2 = block.Modify();

            Assert.True(block != block2);
        }

        [Fact]
        public static void MIndentedCodeBlock_Constructor_AssignText()
        {
            string text = IndentedCodeBlockText();
            var block = new MIndentedCodeBlock(text: text);

            Assert.Equal(text, block.Text);
        }
    }
}
