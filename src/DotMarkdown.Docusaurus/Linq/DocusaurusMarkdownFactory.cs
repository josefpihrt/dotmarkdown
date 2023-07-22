// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Docusaurus.Linq;

public static class DocusaurusMarkdownFactory
{
    public static DocusaurusCodeBlock DocusaurusCodeBlock(
        string text,
        string? language = null,
        string? title = null,
        bool? showLineNumbers = false)
    {
        return new DocusaurusCodeBlock(text, language, title, showLineNumbers);
    }

    public static DocusaurusNoteBlock DocusaurusNote(object? content) => new(content);

    public static DocusaurusNoteBlock DocusaurusNote(params object[]? content) => new(content);

    public static DocusaurusTipBlock DocusaurusTip(object? content) => new(content);

    public static DocusaurusTipBlock DocusaurusTip(params object[]? content) => new(content);

    public static DocusaurusInfoBlock DocusaurusInfo(object? content) => new(content);

    public static DocusaurusInfoBlock DocusaurusInfo(params object[]? content) => new(content);

    public static DocusaurusCautionBlock DocusaurusCaution(object? content) => new(content);

    public static DocusaurusCautionBlock DocusaurusCaution(params object[]? content) => new(content);

    public static DocusaurusDangerBlock DocusaurusDanger(object? content) => new(content);

    public static DocusaurusDangerBlock DocusaurusDanger(params object[]? content) => new(content);

    public static DocusaurusAdmonitionBlock DocusaurusAdmonition(AdmonitionKind kind, object? content)
    {
        return Linq.DocusaurusAdmonitionBlock.Create(kind, content);
    }

    public static DocusaurusAdmonitionBlock DocusaurusAdmonition(AdmonitionKind kind, params object[]? content)
    {
        return Linq.DocusaurusAdmonitionBlock.Create(kind, content);
    }
}
