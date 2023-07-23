// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Docusaurus.Linq;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

internal static class DocusaurusTestHelpers
{
    public static DocusaurusMarkdownWriter CreateWriterWithLineNumbers(bool includeLineNumbers = false)
    {
        return CreateDocusaurusWriter(CreateWriter(), new DocusaurusMarkdownFormat(includeCodeLineNumbers: includeLineNumbers));
    }

    public static DocusaurusMarkdownWriter CreateWriterWithBlankLines(bool admonitionBlankLines = true)
    {
        return CreateDocusaurusWriter(CreateWriter(), new DocusaurusMarkdownFormat(includeAdmonitionBlankLines: admonitionBlankLines));
    }

    public static DocusaurusMarkdownWriter CreateWriterWithFenceStyle(CodeFenceStyle? style)
    {
        return CreateDocusaurusWriter(CreateWriter((style is not null) ? new MarkdownFormat(codeFenceStyle: style.Value) : null));
    }

    public static DocusaurusMarkdownWriter CreateWriterWithCodeBlockOptions(CodeBlockOptions options)
    {
        return CreateDocusaurusWriter(CreateWriter(new MarkdownFormat(codeBlockOptions: options)));
    }

    public static DocusaurusMarkdownWriter CreateDocusaurusWriter(MarkdownWriter writer, DocusaurusMarkdownFormat? format = null)
    {
        return new DocusaurusMarkdownWriter(writer, format);
    }

    public static DocusaurusCodeBlock CreateDocusaurusCodeBlock()
    {
        return new DocusaurusCodeBlock(CodeBlockText(), CodeBlockInfo(), "file.txt", includeLineNumbers: true);
    }
}
