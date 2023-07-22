// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Docusaurus.Linq;
using DotMarkdown.Tests;
using Xunit;
using static DotMarkdown.Docusaurus.Linq.DocusaurusMarkdownFactory;
using static DotMarkdown.Docusaurus.Tests.DocusaurusTestHelpers;
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
        DocusaurusMarkdownWriter mw = CreateWriterWithFenceStyle(style);

        DocusaurusCodeBlock block = DocusaurusCodeBlock(Chars, DefaultText, "file.txt", showLineNumbers: true);
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
        DocusaurusMarkdownWriter mw = CreateWriterWithCodeBlockOptions(CodeBlockOptions.None);

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

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusCodeBlock_LineNumbers()
    {
        DocusaurusMarkdownWriter mw = CreateWriterWithLineNumbers(includeLineNumbers: true);

        mw.Write(DefaultText);
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText, showLineNumbers: null));
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText, showLineNumbers: true));
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText, showLineNumbers: false));
        mw.Write(DocusaurusCodeBlock(Chars, DefaultText, "file1.txt"));
        mw.Write(DefaultText);

        string expected = $@"{DefaultText}

```{DefaultText} showLineNumbers
{Chars}
```

```{DefaultText} showLineNumbers
{Chars}
```

```{DefaultText}
{Chars}
```

```{DefaultText} title=""file1.txt""
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
        DocusaurusMarkdownWriter mw = CreateWriterWithFenceStyle(CodeFenceStyle.Tilde);

        DocusaurusAdmonitionBlock admonition = DocusaurusAdmonitionBlock(kind, Chars);
        admonition.Title = "Title";
        admonition.WriteTo(mw);

        string expected = $@":::{kindText} Title

{CharsEscaped}

:::

";

        Assert.Equal(expected.NormalizeNewLine(), mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusAdmonition_NoTitle()
    {
        DocusaurusMarkdownWriter mw = CreateWriterWithBlankLines(admonitionBlankLines: false);

        DocusaurusAdmonitionBlock admonition = DocusaurusAdmonitionBlock(AdmonitionKind.Note, Chars);
        admonition.WriteTo(mw);

        string expected = $@":::note
{CharsEscaped}
:::

";

        Assert.Equal(expected.NormalizeNewLine(), mw.ToStringAndClear());
    }

    [Fact]
    public static void MarkdownWriter_Write_DocusaurusAdmonition_NoBlankLines()
    {
        DocusaurusMarkdownWriter mw = CreateWriterWithBlankLines(admonitionBlankLines: false);

        DocusaurusAdmonitionBlock admonition = DocusaurusAdmonitionBlock(AdmonitionKind.Note, Chars);
        admonition.Title = "Title";
        admonition.WriteTo(mw);

        string expected = $@":::note Title
{CharsEscaped}
:::

";

        Assert.Equal(expected.NormalizeNewLine(), mw.ToStringAndClear());
    }
}
