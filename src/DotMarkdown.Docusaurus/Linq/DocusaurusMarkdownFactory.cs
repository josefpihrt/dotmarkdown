// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Docusaurus.Linq;

//TODO: DocusaurusMarkdownFactory > DocusaurusFactory, DocusaurusMarkdown
public static class DocusaurusMarkdownFactory
{
    public static DocusaurusCodeBlock DocusaurusCodeBlock(string text, string? language = null, string? title = null, bool? showLineNumbers = false)
    {
        return new DocusaurusCodeBlock(text, language, title, showLineNumbers);
    }

    public static DocusaurusNoteBlock DocusaurusNoteBlock(string text, string? title = null)
    {
        return new DocusaurusNoteBlock(text, title);
    }

    public static DocusaurusTipBlock DocusaurusTipBlock(string text, string? title = null)
    {
        return new DocusaurusTipBlock(text, title);
    }

    public static DocusaurusInfoBlock DocusaurusInfoBlock(string text, string? title = null)
    {
        return new DocusaurusInfoBlock(text, title);
    }

    public static DocusaurusCautionBlock DocusaurusCautionBlock(string text, string? title = null)
    {
        return new DocusaurusCautionBlock(text, title);
    }

    public static DocusaurusDangerBlock DocusaurusDangerBlock(string text, string? title = null)
    {
        return new DocusaurusDangerBlock(text, title);
    }

    public static DocusaurusAdmonition DocusaurusAdmonition(AdmonitionKind kind, string text, string? title = null)
    {
        return Linq.DocusaurusAdmonition.Create(kind, text, title);
    }
}
