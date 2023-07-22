// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using DotMarkdown.Linq.Docusaurus;
using DotMarkdown.Tests;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;
using static DotMarkdown.Docusaurus.Tests.DocusaurusTestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

public static class MDocusaurusCodeBlockTests
{
    [Fact]
    public static void MDocusaurusCodeBlock_Equals()
    {
        MDocusaurusCodeBlock block = CreateDocusaurusCodeBlock();

        Assert.True(block.Equals((object)block));
    }

    [Fact]
    public static void MDocusaurusCodeBlock_NotEquals()
    {
        MDocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        MDocusaurusCodeBlock block2 = block.Modify();

        Assert.False(block.Equals((object)block2));
    }

    [Fact]
    public static void MDocusaurusCodeBlock_GetHashCode_Equal()
    {
        MDocusaurusCodeBlock block = CreateDocusaurusCodeBlock();

        Assert.Equal(block.GetHashCode(), block.GetHashCode());
    }

    [Fact]
    public static void MDocusaurusCodeBlock_GetHashCode_NotEqual()
    {
        MDocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        MDocusaurusCodeBlock block2 = block.Modify();

        Assert.NotEqual(block.GetHashCode(), block2.GetHashCode());
    }

    [Fact]
    public static void MDocusaurusCodeBlock_OperatorEquals()
    {
        MDocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        MDocusaurusCodeBlock block2 = block;

        Assert.True(block == block2);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_OperatorNotEquals()
    {
        MDocusaurusCodeBlock block = CreateDocusaurusCodeBlock();
        MDocusaurusCodeBlock block2 = block.Modify();

        Assert.True(block != block2);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_Constructor_AssignText()
    {
        string text = CodeBlockText();
        var block = new MDocusaurusCodeBlock(text: text, info: CodeBlockInfo());

        Assert.Equal(text, block.Text);
    }

    [Fact]
    public static void MDocusaurusCodeBlock_Constructor_AssignInfo()
    {
        string info = CodeBlockInfo();
        var block = new MDocusaurusCodeBlock(text: CodeBlockText(), info: info);

        Assert.Equal(info, block.Info);
    }
}
