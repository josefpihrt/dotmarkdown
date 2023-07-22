// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using DotMarkdown.Tests;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

public static class MDocusaurusCodeBlockTests
{
    [Fact]
    public static void MDocusaurusCodeBlock_Equals()
    {
        MFencedCodeBlock block = CreateCodeBlock();

        Assert.True(block.Equals((object)block));
    }

    [Fact]
    public static void MDocusaurusCodeBlock_NotEquals()
    {
        MFencedCodeBlock block = CreateCodeBlock();
        MFencedCodeBlock block2 = block.Modify();

        Assert.False(block.Equals((object)block2));
    }

    [Fact]
    public static void MDocusaurusCodeBlock_GetHashCode_Equal()
    {
        MFencedCodeBlock block = CreateCodeBlock();

        Assert.Equal(block.GetHashCode(), block.GetHashCode());
    }

    [Fact]
    public static void MDocusaurusCodeBlock_GetHashCode_NotEqual()
    {
        MFencedCodeBlock block = CreateCodeBlock();
        MFencedCodeBlock block2 = block.Modify();

        Assert.NotEqual(block.GetHashCode(), block2.GetHashCode());
    }

    [Fact]
    public static void MDocusaurusCodeBlock_OperatorEquals()
    {
        MFencedCodeBlock block = CreateCodeBlock();
        MFencedCodeBlock block2 = block;

        Assert.True(block == block2);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_OperatorNotEquals()
    {
        MFencedCodeBlock block = CreateCodeBlock();
        MFencedCodeBlock block2 = block.Modify();

        Assert.True(block != block2);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_Constructor_AssignText()
    {
        string text = CodeBlockText();
        var block = new MFencedCodeBlock(text: text, info: CodeBlockInfo());

        Assert.Equal(text, block.Text);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_Constructor_AssignInfo()
    {
        string info = CodeBlockInfo();
        var block = new MFencedCodeBlock(text: CodeBlockText(), info: info);

        Assert.Equal(info, block.Info);
    }
}
