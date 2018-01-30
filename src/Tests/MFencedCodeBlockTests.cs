// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Tests
{
    public class MFencedCodeBlockTests
    {
        [Fact]
        public void MFencedCodeBlock_Equals()
        {
            MFencedCodeBlock block = CreateCodeBlock();

            Assert.True(block.Equals((object)block));
        }

        [Fact]
        public void MFencedCodeBlock_NotEquals()
        {
            MFencedCodeBlock block = CreateCodeBlock();
            MFencedCodeBlock block2 = block.Modify();

            Assert.False(block.Equals((object)block2));
        }

        [Fact]
        public void MFencedCodeBlock_GetHashCode_Equal()
        {
            MFencedCodeBlock block = CreateCodeBlock();

            Assert.Equal(block.GetHashCode(), block.GetHashCode());
        }

        [Fact]
        public void MFencedCodeBlock_GetHashCode_NotEqual()
        {
            MFencedCodeBlock block = CreateCodeBlock();
            MFencedCodeBlock block2 = block.Modify();

            Assert.NotEqual(block.GetHashCode(), block2.GetHashCode());
        }

        [Fact]
        public void MFencedCodeBlock_OperatorEquals()
        {
            MFencedCodeBlock block = CreateCodeBlock();
            MFencedCodeBlock block2 = block;

            Assert.True(block == block2);
        }

        [Fact]
        public void MFencedCodeBlock_OperatorNotEquals()
        {
            MFencedCodeBlock block = CreateCodeBlock();
            MFencedCodeBlock block2 = block.Modify();

            Assert.True(block != block2);
        }

        [Fact]
        public void MFencedCodeBlock_Constructor_AssignText()
        {
            string text = CodeBlockText();
            var block = new MFencedCodeBlock(text: text, info: CodeBlockInfo());

            Assert.Equal(text, block.Text);
        }

        [Fact]
        public void MFencedCodeBlock_Constructor_AssignInfo()
        {
            string info = CodeBlockInfo();
            var block = new MFencedCodeBlock(text: CodeBlockText(), info: info);

            Assert.Equal(info, block.Info);
        }
    }
}
