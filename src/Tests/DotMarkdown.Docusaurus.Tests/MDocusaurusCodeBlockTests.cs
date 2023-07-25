// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;
using static DotMarkdown.Docusaurus.Tests.DocusaurusTestHelpers;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

public static class MDocusaurusCodeBlockTests
{
    [Fact]
    public static void MDocusaurusCodeBlock_Equals()
    {
        DocusaurusCodeBlock block = CreateDocusaurusCodeBlock();

        Assert.True(block.Equals((object)block));
    }

    [Fact]
    public static void MDocusaurusCodeBlock_NotEquals()
    {
        DocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        DocusaurusCodeBlock block2 = block.Modify();

        Assert.False(block.Equals((object)block2));
    }

    [Fact]
    public static void MDocusaurusCodeBlock_GetHashCode_Equal()
    {
        DocusaurusCodeBlock block = CreateDocusaurusCodeBlock();

        Assert.Equal(block.GetHashCode(), block.GetHashCode());
    }

    [Fact]
    public static void MDocusaurusCodeBlock_GetHashCode_NotEqual()
    {
        DocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        DocusaurusCodeBlock block2 = block.Modify();

        Assert.NotEqual(block.GetHashCode(), block2.GetHashCode());
    }

    [Fact]
    public static void MDocusaurusCodeBlock_OperatorEquals()
    {
        DocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        DocusaurusCodeBlock block2 = block;

        Assert.True(block == block2);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_OperatorNotEquals()
    {
        DocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        DocusaurusCodeBlock block2 = block.Modify();

        Assert.True(block != block2);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_Constructor_AssignText()
    {
        string text = CodeBlockText();
        var block = new DocusaurusCodeBlock(text: text, language: CodeBlockInfo());

        Assert.Equal(text, block.Text);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_Constructor_AssignInfo()
    {
        string info = CodeBlockInfo();
        var block = new DocusaurusCodeBlock(text: CodeBlockText(), language: info);

        Assert.Equal(info, block.Language);
    }
}
