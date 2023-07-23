// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Docusaurus;

public class DocusaurusMarkdownFormat
{
    public static DocusaurusMarkdownFormat Default { get; } = new();

    public DocusaurusMarkdownFormat(
        bool includeCodeLineNumbers = false,
        bool includeAdmonitionBlankLines = true)
    {
        IncludeCodeLineNumbers = includeCodeLineNumbers;
        IncludeAdmonitionBlankLines = includeAdmonitionBlankLines;
    }

    public bool IncludeCodeLineNumbers { get; }

    public bool IncludeAdmonitionBlankLines { get; }
}
