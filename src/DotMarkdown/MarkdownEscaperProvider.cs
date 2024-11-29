// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown;

internal sealed class MarkdownEscaperProvider : IMarkdownEscaperProvider
{
    public static IMarkdownEscaperProvider Default { get; } = new MarkdownEscaperProvider();

    public MarkdownCharEscaper GetDefaultEscaper() => MarkdownCharEscaper.Default;
}
