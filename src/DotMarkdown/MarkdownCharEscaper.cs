// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown;

public abstract class MarkdownCharEscaper
{
    internal static char DefaultEscapingChar { get; } = '\\';

    internal static MarkdownCharEscaper Default { get; } = new DefaultMarkdownEscaper();

    internal static MarkdownCharEscaper LinkText { get; } = new LinkTextMarkdownEscaper();

    internal static MarkdownCharEscaper LinkUrl { get; } = new LinkUrlMarkdownEscaper();

    internal static MarkdownCharEscaper LinkTitle { get; } = new LinkTitleMarkdownEscaper();

    internal static MarkdownCharEscaper AngleBrackets { get; } = new AngleBracketsMarkdownEscaper();

    internal static MarkdownCharEscaper InlineCodeInsideTable { get; } = new InlineCodeInsideTableMarkdownEscaper();

    internal static MarkdownCharEscaper NoEscape { get; } = new NoEscapeMarkdownEscaper();

    public abstract bool ShouldBeEscaped(char value);

    private class DefaultMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char value)
        {
            switch (value)
            {
                case '\\':
                case '`':
                case '*':
                case '_':
                case '{':
                case '}':
                case '[':
                case ']':
                case '(':
                case ')':
                case '#':
                case '+':
                case '-':
                case '.':
                case '!':
                case '<':
                case '>':
                case '|':
                case '~':
                    return true;
                default:
                    return false;
            }
        }
    }

    private class LinkTextMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char ch)
        {
            switch (ch)
            {
                case '[':
                case ']':
                case '`':
                case '<':
                case '>':
                    return true;
                default:
                    return false;
            }
        }
    }

    private class LinkUrlMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char ch)
        {
            switch (ch)
            {
                case '(':
                case ')':
                    return true;
                default:
                    return false;
            }
        }
    }

    private class LinkTitleMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char ch)
        {
            switch (ch)
            {
                case '"':
                    return true;
                default:
                    return false;
            }
        }
    }

    private class AngleBracketsMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char ch)
        {
            switch (ch)
            {
                case '<':
                case '>':
                    return true;
                default:
                    return false;
            }
        }
    }

    private class InlineCodeInsideTableMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char ch)
        {
            return ch == '|';
        }
    }

    private class NoEscapeMarkdownEscaper : MarkdownCharEscaper
    {
        public override bool ShouldBeEscaped(char ch) => false;
    }
}
