// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Docusaurus.Linq;

//TODO: DocusaurusMarkdownFactory > DocusaurusFactory
public static class DocusaurusMarkdownFactory
{
    public static MDocusaurusCodeBlock DocusaurusCodeBlock(string text, string? language = null, string? title = null, bool? showLineNumbers = false)
    {
        return new MDocusaurusCodeBlock(text, language, title, showLineNumbers);
    }

    public static MDocusaurusNoteBlock DocusaurusNoteBlock(string text, string? title = null)
    {
        return new MDocusaurusNoteBlock(text, title);
    }

    public static MDocusaurusTipBlock DocusaurusTipBlock(string text, string? title = null)
    {
        return new MDocusaurusTipBlock(text, title);
    }

    public static MDocusaurusInfoBlock DocusaurusInfoBlock(string text, string? title = null)
    {
        return new MDocusaurusInfoBlock(text, title);
    }

    public static MDocusaurusCautionBlock DocusaurusCautionBlock(string text, string? title = null)
    {
        return new MDocusaurusCautionBlock(text, title);
    }

    public static MDocusaurusDangerBlock DocusaurusDangerBlock(string text, string? title = null)
    {
        return new MDocusaurusDangerBlock(text, title);
    }

    public static MDocusaurusAdmonition DocusaurusAdmonition(AdmonitionKind kind, string text, string? title = null)
    {
        return MDocusaurusAdmonition.Create(kind, text, title);
    }
}
