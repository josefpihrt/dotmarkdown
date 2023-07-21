// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Docusaurus;

public class DocusaurusMarkdownFormat
{
    public DocusaurusMarkdownFormat(
        bool codeBlockLineNumber = false,
        bool admonitionEmptyLines = true)
    {
        CodeBlockLineNumber = codeBlockLineNumber;
        AdmonitionEmptyLines = admonitionEmptyLines;
    }

    public bool CodeBlockLineNumber { get; }

    public bool AdmonitionEmptyLines { get; }
}
