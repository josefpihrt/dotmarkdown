// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text;

namespace DotMarkdown
{
    public static class MarkdownEscaper
    {
        public static string Escape(string value, Func<char, bool> shouldBeEscaped = null)
        {
            return Escape(value, shouldBeEscaped ?? ShouldBeEscaped, escapingChar: '\\');
        }

        internal static string Escape(string value, Func<char, bool> shouldBeEscaped, char escapingChar)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            StringBuilder sb = null;

            for (int i = 0; i < value.Length; i++)
            {
                if (shouldBeEscaped(value[i]))
                {
                    sb = StringBuilderCache.GetInstance(value.Length);
                    sb.Append(value, 0, i);
                    sb.Append(escapingChar);
                    sb.Append(value[i]);

                    i++;
                    int lastIndex = i;

                    while (i < value.Length)
                    {
                        if (shouldBeEscaped(value[i]))
                        {
                            sb.Append(value, lastIndex, i - lastIndex);
                            sb.Append(escapingChar);
                            sb.Append(value[i]);

                            i++;
                            lastIndex = i;
                        }
                        else
                        {
                            i++;
                        }
                    }

                    sb.Append(value, lastIndex, value.Length - lastIndex);

                    return StringBuilderCache.GetStringAndFree(sb);
                }
            }

            return value;
        }

        public static bool ShouldBeEscaped(char value)
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

        internal static bool ShouldBeEscapedInLinkText(char ch)
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

        internal static bool ShouldBeEscapedInLinkUrl(char ch)
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

        internal static bool ShouldBeEscapedInLinkTitle(char ch)
        {
            switch (ch)
            {
                case '"':
                    return true;
                default:
                    return false;
            }
        }

        internal static bool ShouldBeEscapedInAngleBrackets(char ch)
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
}
