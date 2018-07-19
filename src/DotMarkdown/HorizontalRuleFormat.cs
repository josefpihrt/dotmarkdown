// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown
{
    [DebuggerDisplay("{HorizontalRuleStyle} {Count}{SeparatorDebuggerDisplay,nq}")]
    public readonly struct HorizontalRuleFormat : IEquatable<HorizontalRuleFormat>
    {
        internal const HorizontalRuleStyle DefaultStyle = HorizontalRuleStyle.Hyphen;
        internal const int DefaultCount = 3;
        internal const string DefaultSeparator = " ";

        public HorizontalRuleFormat(HorizontalRuleStyle style, int count, string separator)
        {
            Error.ThrowOnInvalidHorizontalRuleCount(count);
            Error.ThrowOnInvalidHorizontalRuleSeparator(separator);

            Style = style;
            Count = count;
            Separator = separator;
        }

        public static HorizontalRuleFormat Default { get; } = new HorizontalRuleFormat(DefaultStyle, DefaultCount, DefaultSeparator);

        public HorizontalRuleStyle Style { get; }

        public int Count { get; }

        public string Separator { get; }

        private string SeparatorDebuggerDisplay
        {
            get { return (!string.IsNullOrEmpty(Separator)) ? $" {nameof(Separator)} = \"{Separator}\"" : ""; }
        }

        public bool IsValid
        {
            get
            {
                return IsValidCount(Count)
                    && IsValidSeparator(Separator);
            }
        }

        internal static bool IsValidCount(int count)
        {
            return count >= 3;
        }

        internal static bool IsValidSeparator(string separator)
        {
            if (separator == null)
                return true;

            for (int i = 0; i < separator.Length; i++)
            {
                if (separator[i] != ' ')
                    return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            return (obj is HorizontalRuleFormat other)
                && Equals(other);
        }

        public bool Equals(HorizontalRuleFormat other)
        {
            return Style == other.Style
                   && Count == other.Count
                   && Separator == other.Separator;
        }

        public override int GetHashCode()
        {
            return Hash.Combine((int)Style, Hash.Combine(Count, Hash.Create(Separator)));
        }

        public static bool operator ==(in HorizontalRuleFormat format1, in HorizontalRuleFormat format2)
        {
            return format1.Equals(format2);
        }

        public static bool operator !=(in HorizontalRuleFormat format1, in HorizontalRuleFormat format2)
        {
            return !(format1 == format2);
        }
    }
}
