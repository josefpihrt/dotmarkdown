// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Docusaurus.Linq;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

internal static class DocusaurusTestHelpers
{
    public static DocusaurusMarkdownWriter CreateWriterWithLineNumbers(bool includeLineNumbers = false)
    {
        return CreateDocusaurusWriter(CreateWriter(), new DocusaurusMarkdownFormat(codeLineNumbers: includeLineNumbers));
    }

    public static DocusaurusMarkdownWriter CreateWriterWithBlankLines(bool admonitionBlankLines = true)
    {
        return CreateDocusaurusWriter(CreateWriter(), new DocusaurusMarkdownFormat(admonitionBlankLines: admonitionBlankLines));
    }

    public static DocusaurusMarkdownWriter CreateDocusaurusWriter(MarkdownWriter writer, DocusaurusMarkdownFormat? format = null)
    {
        return new DocusaurusMarkdownWriter(writer, format);
    }

    public static MDocusaurusCodeBlock CreateDocusaurusCodeBlock()
    {
        return new MDocusaurusCodeBlock(CodeBlockText(), CodeBlockInfo(), "file.txt", includeLineNumbers: true);
    }
}
