// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq.Docusaurus;
using DotMarkdown.Tests;
using Xunit;
using static DotMarkdown.Linq.Docusaurus.DocusaurusMarkdownFactory;
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

        string expected = $@"{syntax}{DefaultText} showLineNumbers title=""file.txt""
{Chars}
{syntax}

";

        Assert.Equal(expected.NormalizeNewLine(), mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_CodeBlockOptionsNone()
    {
        MarkdownWriter mw = CreateBuilderWithCodeBlockOptions(CodeBlockOptions.None);

        mw.Write(DefaultText);
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText, "file1.txt", showLineNumbers: true));
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText, "file2.txt", showLineNumbers: false));
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText));
        mw.Write(DefaultText);

        string expected = $@"{DefaultText}
```{DefaultText} showLineNumbers title=""file1.txt""
{Chars}
```
```{DefaultText} title=""file2.txt""
{Chars}
```
```{DefaultText}
{Chars}
```
{DefaultText}";

        Assert.Equal(expected.NormalizeNewLine(), mw.ToStringAndClear());
    }

    [Theory]
    [InlineData(AdmonitionKind.Note, "note")]
    [InlineData(AdmonitionKind.Tip, "tip")]
    [InlineData(AdmonitionKind.Info, "info")]
    [InlineData(AdmonitionKind.Caution, "caution")]
    [InlineData(AdmonitionKind.Danger, "danger")]
    public static void MarkdownWriter_Write_DocusaurusAdmonition(AdmonitionKind kind, string kindText)
    {
        MarkdownWriter mw = CreateBuilderWithCodeFenceOptions(CodeFenceStyle.Tilde);

        MDocusaurusAdmonition admonition = DocusaurusAdmonition(kind, Chars, "Title");
        admonition.WriteTo(mw);

        string expected = $@":::{kindText} Title

{CharsEscaped}

:::

";

        Assert.Equal(expected.NormalizeNewLine(), mw.ToStringAndClear());
    }
}
