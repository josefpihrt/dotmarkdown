// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Linq.MFactory;
using static DotMarkdown.Tests.MarkdownSamples;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests;

public static class MarkdownWriterTests
{
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
}
