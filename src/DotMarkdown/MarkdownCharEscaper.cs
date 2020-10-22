// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown
{
    internal abstract class MarkdownCharEscaper
    {
        public static char DefaultEscapingChar { get; } = '\\';

        public static MarkdownCharEscaper Default { get; } = new DefaultMarkdownEscaper();

        public static MarkdownCharEscaper LinkText { get; } = new LinkTextMarkdownEscaper();

        public static MarkdownCharEscaper LinkUrl { get; } = new LinkUrlMarkdownEscaper();

        public static MarkdownCharEscaper LinkTitle { get; } = new LinkTitleMarkdownEscaper();

        public static MarkdownCharEscaper AngleBrackets { get; } = new AngleBracketsMarkdownEscaper();

        public static MarkdownCharEscaper NoEscape { get; } = new NoEscapeMarkdownEscaper();

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

        private class NoEscapeMarkdownEscaper : MarkdownCharEscaper
        {
            public override bool ShouldBeEscaped(char ch) => false;
        }
    }
}
