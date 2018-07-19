// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using DotMarkdown.Linq;

namespace DotMarkdown
{
    internal static class Error
    {
        public static void InvalidContent(MContainer container, MElement element)
        {
            throw new InvalidOperationException($"Element '{container.Kind}' cannot contain element '{element.Kind}'.");
        }

        public static void ThrowOnInvalidCharEntity(char value)
        {
            if (value >= 0xD800
                && value <= 0xDFFF)
            {
                throw new ArgumentException("Character entity cannot be in the surrogate pair character range.", nameof(value));
            }
        }

        public static void ThrowOnInvalidFencedCodeBlockInfo(string info)
        {
            if (string.IsNullOrEmpty(info))
                return;

            for (int i = 0; i < info.Length; i++)
            {
                switch (info[i])
                {
                    case '\r':
                    case '\n':
                        throw new ArgumentException("Code block info cannot contain a new line character.", nameof(info));
                    case '`':
                        throw new ArgumentException("Code block info cannot contain a backtick character.", nameof(info));
                }
            }
        }

        public static void ThrowOnInvalidHorizontalRuleFormat(in HorizontalRuleFormat format)
        {
            ThrowOnInvalidHorizontalRuleCount(format.Count);
            ThrowOnInvalidHorizontalRuleSeparator(format.Separator);
        }

        public static void ThrowOnInvalidHorizontalRuleCount(int count)
        {
            if (!HorizontalRuleFormat.IsValidCount(count))
                throw new ArgumentOutOfRangeException(nameof(count), count, "Number of characters in horizontal rule must be greater than or equal to 3.");
        }

        public static void ThrowOnInvalidHorizontalRuleSeparator(string separator)
        {
            if (!HorizontalRuleFormat.IsValidSeparator(separator))
                throw new ArgumentException("Horizontal rule separator must be empty or consists of space(s).", nameof(separator));
        }

        public static void ThrowOnInvalidHeadingLevel(int level)
        {
            if (level < 1
                || level > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(level), level, "Heading level must be in range from 1 to 6.");
            }
        }

        public static void ThrowOnInvalidEntityName(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (name.Length == 0)
                throw new ArgumentException("Entity name cannot be empty.", nameof(name));

            if (!TextUtility.IsAlphanumeric(name))
                throw new ArgumentException("Entity name can contains only alphanumeric characters.", nameof(name));
        }

        public static void ThrowOnInvalidItemNumber(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException(nameof(number), number, "Item number must be greater than or equal to 0.");
        }

        public static void ThrowOnInvalidUrl(string url)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));

            ThrowIfContainsWhitespace(url, nameof(url));
        }

        public static void ThrowIfContainsWhitespace(string value, string parameterName = null)
        {
            if (value == null)
                return;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsWhiteSpace(value[i]))
                    throw new ArgumentException("Link or image url cannot contain whitespace character(s).", (parameterName != null) ? nameof(parameterName) : nameof(value));
            }
        }
    }
}
