// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using DotMarkdown.Linq.Docusaurus;
using DotMarkdown.Tests;
using Xunit;
using static DotMarkdown.Linq.Docusaurus.DocusaurusMarkdownFactory;
using static DotMarkdown.Tests.MarkdownSamples;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

public static class DocusaurusMarkdownWriterTests
{
    [Theory]
    [InlineData("```", null)]
    [InlineData("```", CodeFenceStyle.Backtick)]
    [InlineData("~~~", CodeFenceStyle.Tilde)]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_CodeFenceStyle(string syntax, CodeFenceStyle? style)
    {
        MarkdownWriter mw = CreateBuilderWithCodeFenceOptions(style);

        MDocusaurusCodeBlock block = DocusaurusCodeBlock(Chars, DefaultText, "file.txt", showLineNumbers: true);
        block.WriteTo(mw);

        Assert.Equal(
            syntax + DefaultText + " showLineNumbers title=\"file.txt\"" + NewLine + Chars + NewLine + syntax + NewLine2,
            mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_CodeBlockOptionsNone()
    {
        MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.None);

        MDocusaurusCodeBlock block = DocusaurusCodeBlock(Chars, DefaultText, "file.txt", showLineNumbers: true);

        mw.Write(DefaultText);
        mw.Write(block);
        mw.Write(block);
        mw.Write(DefaultText);

        const string codeBlockMarkdown = "```" + DefaultText + " showLineNumbers title=\"file.txt\"" + NewLine + Chars + NewLine + "```" + NewLine;

        Assert.Equal(
            DefaultText + NewLine + codeBlockMarkdown + codeBlockMarkdown + DefaultText,
            mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_CodeBlockOptionsEmptyLineBefore()
    {
        MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.EmptyLineBefore);

        MDocusaurusCodeBlock block = DocusaurusCodeBlock(Chars, DefaultText, "file.txt", showLineNumbers: true);

        mw.Write(DefaultText);
        mw.Write(block);
        mw.Write(block);
        mw.Write(DefaultText);

        const string codeBlockMarkdown = "```" + DefaultText + " showLineNumbers title=\"file.txt\"" + NewLine + Chars + NewLine + "```" + NewLine;

        Assert.Equal(
            DefaultText + NewLine2 + codeBlockMarkdown + NewLine + codeBlockMarkdown + DefaultText,
            mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_CodeBlockOptionsEmptyLineAfter()
    {
        MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.EmptyLineAfter);

        MDocusaurusCodeBlock block = DocusaurusCodeBlock(Chars, DefaultText, "file.txt", showLineNumbers: true);

        mw.Write(DefaultText);
        mw.Write(block);
        mw.Write(block);
        mw.Write(DefaultText);

        const string codeBlockMarkdown = "```" + DefaultText + " showLineNumbers title=\"file.txt\"" + NewLine + Chars + NewLine + "```" + NewLine;

        Assert.Equal(
            DefaultText + NewLine + codeBlockMarkdown + NewLine + codeBlockMarkdown + NewLine + DefaultText,
            mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_CodeBlockOptionsEmptyLineBeforeAndAfter()
    {
        MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.EmptyLineBeforeAndAfter);

        MDocusaurusCodeBlock block = DocusaurusCodeBlock(Chars, DefaultText, "file.txt", showLineNumbers: true);

        mw.Write(DefaultText);
        mw.Write(block);
        mw.Write(block);
        mw.Write(DefaultText);

        const string codeBlockMarkdown = "```" + DefaultText + " showLineNumbers title=\"file.txt\"" + NewLine + Chars + NewLine + "```" + NewLine;

        Assert.Equal(
            DefaultText + NewLine2 + codeBlockMarkdown + NewLine + codeBlockMarkdown + NewLine + DefaultText,
            mw.ToStringAndClear());
    }
}
