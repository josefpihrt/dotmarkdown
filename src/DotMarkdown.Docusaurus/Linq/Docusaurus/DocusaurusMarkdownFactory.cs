// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq.Docusaurus;

public static class DocusaurusMarkdownFactory
{
    public static MDocusaurusCodeBlock DocusaurusCodeBlock(string text, string? info = null, string? textInfo = null, bool showLineNumbers = false)
    {
        return new MDocusaurusCodeBlock(text, info, textInfo, showLineNumbers);
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
}
