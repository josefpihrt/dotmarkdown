﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace DotMarkdown.Docusaurus;

public static class DocusaurusMarkdownFactory
{
    public static DocusaurusFrontMatter FrontMatter(IEnumerable<(string Key, object Value)> labels) => new(labels);

    public static DocusaurusFrontMatter FrontMatter(params (string Key, object Value)[] labels) => new(labels);

    public static DocusaurusCodeBlock CodeBlock(
        string text,
        string? language = null,
        string? title = null,
        bool? showLineNumbers = null)
    {
        return new DocusaurusCodeBlock(text, language, title, showLineNumbers);
    }

    public static DocusaurusNoteBlock NoteBlock(object? content) => new(content);

    public static DocusaurusNoteBlock NoteBlock(params object[]? content) => new(content);

    public static DocusaurusTipBlock TipBlock(object? content) => new(content);

    public static DocusaurusTipBlock TipBlock(params object[]? content) => new(content);

    public static DocusaurusInfoBlock InfoBlock(object? content) => new(content);

    public static DocusaurusInfoBlock InfoBlock(params object[]? content) => new(content);

    public static DocusaurusCautionBlock CautionBlock(object? content) => new(content);

    public static DocusaurusCautionBlock CautionBlock(params object[]? content) => new(content);

    public static DocusaurusDangerBlock DangerBlock(object? content) => new(content);

    public static DocusaurusDangerBlock DangerBlock(params object[]? content) => new(content);

    public static DocusaurusAdmonitionBlock AdmonitionBlock(AdmonitionKind kind, object? content)
    {
        return DocusaurusAdmonitionBlock.Create(kind, content);
    }

    public static DocusaurusAdmonitionBlock AdmonitionBlock(AdmonitionKind kind, params object[]? content)
    {
        return DocusaurusAdmonitionBlock.Create(kind, content);
    }
}
