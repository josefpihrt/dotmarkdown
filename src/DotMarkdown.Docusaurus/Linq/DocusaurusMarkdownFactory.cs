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

    public static DocusaurusNoteBlock DocusaurusNoteBlock(object? content) => new(content);

    public static DocusaurusNoteBlock DocusaurusNoteBlock(params object[]? content) => new(content);

    public static DocusaurusTipBlock DocusaurusTipBlock(object? content) => new(content);

    public static DocusaurusTipBlock DocusaurusTipBlock(params object[]? content) => new(content);

    public static DocusaurusInfoBlock DocusaurusInfoBlock(object? content) => new(content);

    public static DocusaurusInfoBlock DocusaurusInfoBlock(params object[]? content) => new(content);

    public static DocusaurusCautionBlock DocusaurusCautionBlock(object? content) => new(content);

    public static DocusaurusCautionBlock DocusaurusCautionBlock(params object[]? content) => new(content);

    public static DocusaurusDangerBlock DocusaurusDangerBlock(object? content) => new(content);

    public static DocusaurusDangerBlock DocusaurusDangerBlock(params object[]? content) => new(content);

    public static DocusaurusAdmonitionBlock DocusaurusAdmonitionBlock(AdmonitionKind kind, object? content)
    {
        return Linq.DocusaurusAdmonitionBlock.Create(kind, content);
    }

    public static DocusaurusAdmonitionBlock DocusaurusAdmonitionBlock(AdmonitionKind kind, params object[]? content)
    {
        return Linq.DocusaurusAdmonitionBlock.Create(kind, content);
    }
}
