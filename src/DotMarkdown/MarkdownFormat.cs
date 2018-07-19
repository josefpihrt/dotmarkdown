// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace DotMarkdown
{
    public class MarkdownFormat : IEquatable<MarkdownFormat>
    {
        public MarkdownFormat(
            EmphasisStyle boldStyle = EmphasisStyle.Asterisk,
            EmphasisStyle italicStyle = EmphasisStyle.Asterisk,
            BulletListStyle bulletListStyle = BulletListStyle.Asterisk,
            OrderedListStyle orderedListStyle = OrderedListStyle.Dot,
            HeadingStyle headingStyle = HeadingStyle.NumberSign,
            HeadingOptions headingOptions = HeadingOptions.EmptyLineBeforeAndAfter,
            TableOptions tableOptions = TableOptions.FormatHeader | TableOptions.OuterDelimiter | TableOptions.Padding | TableOptions.EmptyLineBeforeAndAfter,
            CodeFenceStyle codeFenceStyle = CodeFenceStyle.Backtick,
            CodeBlockOptions codeBlockOptions = CodeBlockOptions.EmptyLineBeforeAndAfter,
            CharEntityFormat charEntityFormat = CharEntityFormat.Hexadecimal,
            HorizontalRuleFormat? horizontalRuleFormat = null)
        {
            BoldStyle = boldStyle;
            ItalicStyle = italicStyle;
            BulletListStyle = bulletListStyle;
            OrderedListStyle = orderedListStyle;
            HeadingStyle = headingStyle;
            HeadingOptions = headingOptions;
            TableOptions = tableOptions;
            CodeFenceStyle = codeFenceStyle;
            CodeBlockOptions = codeBlockOptions;
            CharEntityFormat = charEntityFormat;

            if (BulletListStyle == BulletListStyle.Asterisk)
            {
                BulletItemStart = "* ";
            }
            else if (BulletListStyle == BulletListStyle.Plus)
            {
                BulletItemStart = "+ ";
            }
            else if (BulletListStyle == BulletListStyle.Minus)
            {
                BulletItemStart = "- ";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(BulletListStyle));
            }

            if (BoldStyle == EmphasisStyle.Asterisk)
            {
                BoldDelimiter = "**";
            }
            else if (BoldStyle == EmphasisStyle.Underscore)
            {
                BoldDelimiter = "__";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(BoldStyle));
            }

            if (ItalicStyle == EmphasisStyle.Asterisk)
            {
                ItalicDelimiter = "*";
            }
            else if (ItalicStyle == EmphasisStyle.Underscore)
            {
                ItalicDelimiter = "_";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(ItalicStyle));
            }

            if (OrderedListStyle == OrderedListStyle.Dot)
            {
                OrderedItemStart = ". ";
            }
            else if (OrderedListStyle == OrderedListStyle.Parenthesis)
            {
                OrderedItemStart = ") ";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(OrderedListStyle));
            }

            if (HeadingStyle == HeadingStyle.NumberSign)
            {
                HeadingStart = "#";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(HeadingStyle));
            }

            if (CodeFenceStyle == CodeFenceStyle.Backtick)
            {
                CodeFence = "```";
            }
            else if (CodeFenceStyle == CodeFenceStyle.Tilde)
            {
                CodeFence = "~~~";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(CodeFenceStyle));
            }

            if (horizontalRuleFormat != null)
            {
                Error.ThrowOnInvalidHorizontalRuleFormat(horizontalRuleFormat.Value);

                HorizontalRuleFormat = horizontalRuleFormat.Value;
            }
            else
            {
                HorizontalRuleFormat = HorizontalRuleFormat.Default;
            }

            if (HorizontalRuleStyle == HorizontalRuleStyle.Hyphen)
            {
                HorizontalRuleText = "-";
            }
            else if (HorizontalRuleStyle == HorizontalRuleStyle.Underscore)
            {
                HorizontalRuleText = "_";
            }
            else if (HorizontalRuleStyle == HorizontalRuleStyle.Asterisk)
            {
                HorizontalRuleText = "*";
            }
            else
            {
                throw new InvalidOperationException(ErrorMessages.UnknownEnumValue(HorizontalRuleStyle));
            }
        }

        public static MarkdownFormat Default { get; } = new MarkdownFormat();

        internal static MarkdownFormat Debugging { get; } = new MarkdownFormat(
            Default.BoldStyle,
            Default.ItalicStyle,
            Default.BulletListStyle,
            Default.OrderedListStyle,
            Default.HeadingStyle,
            HeadingOptions.None,
            TableOptions.OuterDelimiter,
            Default.CodeFenceStyle,
            CodeBlockOptions.None,
            Default.CharEntityFormat,
            Default.HorizontalRuleFormat);

        public EmphasisStyle BoldStyle { get; }

        internal string BoldDelimiter { get; }

        public EmphasisStyle ItalicStyle { get; }

        internal string ItalicDelimiter { get; }

        public BulletListStyle BulletListStyle { get; }

        internal string BulletItemStart { get; }

        public OrderedListStyle OrderedListStyle { get; }

        internal string OrderedItemStart { get; }

        public HorizontalRuleFormat HorizontalRuleFormat { get; }

        internal string HorizontalRuleText { get; }

        internal HorizontalRuleStyle HorizontalRuleStyle => HorizontalRuleFormat.Style;

        internal int HorizontalRuleCount => HorizontalRuleFormat.Count;

        internal string HorizontalRuleSeparator => HorizontalRuleFormat.Separator;

        public HeadingStyle HeadingStyle { get; }

        internal string HeadingStart { get; }

        public HeadingOptions HeadingOptions { get; }

        internal bool EmptyLineBeforeHeading => (HeadingOptions & HeadingOptions.EmptyLineBefore) != 0;

        internal bool EmptyLineAfterHeading => (HeadingOptions & HeadingOptions.EmptyLineAfter) != 0;

        public CodeFenceStyle CodeFenceStyle { get; }

        internal string CodeFence { get; }

        public CodeBlockOptions CodeBlockOptions { get; }

        internal bool EmptyLineBeforeCodeBlock => (CodeBlockOptions & CodeBlockOptions.EmptyLineBefore) != 0;

        internal bool EmptyLineAfterCodeBlock => (CodeBlockOptions & CodeBlockOptions.EmptyLineAfter) != 0;

        public TableOptions TableOptions { get; }

        internal bool TablePadding => (TableOptions & TableOptions.Padding) != 0;

        internal bool TableOuterDelimiter => (TableOptions & TableOptions.OuterDelimiter) != 0;

        internal bool FormatTableHeader => (TableOptions & TableOptions.FormatHeader) != 0;

        internal bool FormatTableContent => (TableOptions & TableOptions.FormatContent) != 0;

        internal bool EmptyLineBeforeTable => (TableOptions & TableOptions.EmptyLineBefore) != 0;

        internal bool EmptyLineAfterTable => (TableOptions & TableOptions.EmptyLineAfter) != 0;

        internal bool UnderlineHeading => (HeadingOptions & HeadingOptions.Underline) != 0;

        internal bool UnderlineHeading1 => (HeadingOptions & HeadingOptions.UnderlineHeading1) != 0;

        internal bool UnderlineHeading2 => (HeadingOptions & HeadingOptions.UnderlineHeading2) != 0;

        internal bool CloseHeading => (HeadingOptions & HeadingOptions.Close) != 0;

        public CharEntityFormat CharEntityFormat { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MarkdownFormat);
        }

        public bool Equals(MarkdownFormat other)
        {
            return other != null
                && BoldStyle == other.BoldStyle
                && ItalicStyle == other.ItalicStyle
                && BulletListStyle == other.BulletListStyle
                && OrderedListStyle == other.OrderedListStyle
                && HeadingStyle == other.HeadingStyle
                && HeadingOptions == other.HeadingOptions
                && CodeFenceStyle == other.CodeFenceStyle
                && CodeBlockOptions == other.CodeBlockOptions
                && TableOptions == other.TableOptions
                && CharEntityFormat == other.CharEntityFormat
                && HorizontalRuleFormat == other.HorizontalRuleFormat;
        }

        public override int GetHashCode()
        {
            int hashCode = Hash.OffsetBasis;
            hashCode = Hash.Combine((int)BoldStyle, hashCode);
            hashCode = Hash.Combine((int)ItalicStyle, hashCode);
            hashCode = Hash.Combine((int)BulletListStyle, hashCode);
            hashCode = Hash.Combine((int)OrderedListStyle, hashCode);
            hashCode = Hash.Combine((int)HeadingStyle, hashCode);
            hashCode = Hash.Combine((int)HeadingOptions, hashCode);
            hashCode = Hash.Combine((int)CodeFenceStyle, hashCode);
            hashCode = Hash.Combine((int)CodeBlockOptions, hashCode);
            hashCode = Hash.Combine((int)TableOptions, hashCode);
            hashCode = Hash.Combine((int)CharEntityFormat, hashCode);
            hashCode = Hash.Combine(HorizontalRuleFormat.GetHashCode(), hashCode);
            return hashCode;
        }

        public static bool operator ==(MarkdownFormat format1, MarkdownFormat format2)
        {
            return EqualityComparer<MarkdownFormat>.Default.Equals(format1, format2);
        }

        public static bool operator !=(MarkdownFormat format1, MarkdownFormat format2)
        {
            return !(format1 == format2);
        }

        public MarkdownFormat WithBoldStyle(EmphasisStyle boldStyle)
        {
            return new MarkdownFormat(
                boldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithItalicStyle(EmphasisStyle italicStyle)
        {
            return new MarkdownFormat(
                BoldStyle,
                italicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithBulletListStyle(BulletListStyle bulletListStyle)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                bulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithOrderedListStyle(OrderedListStyle orderedListStyle)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                orderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithHorizontalRuleFormat(in HorizontalRuleFormat horizontalRuleFormat)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                horizontalRuleFormat);
        }

        public MarkdownFormat WithHeadingOptions(HeadingStyle headingStyle)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                headingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithHeadingOptions(HeadingOptions headingOptions)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                headingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithTableOptions(TableOptions tableOptions)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                tableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithCodeFenceStyle(CodeFenceStyle codeFenceStyle)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                codeFenceStyle,
                CodeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithCodeBlockOptions(CodeBlockOptions codeBlockOptions)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                codeBlockOptions,
                CharEntityFormat,
                HorizontalRuleFormat);
        }

        public MarkdownFormat WithCharEntityFormat(CharEntityFormat charEntityFormat)
        {
            return new MarkdownFormat(
                BoldStyle,
                ItalicStyle,
                BulletListStyle,
                OrderedListStyle,
                HeadingStyle,
                HeadingOptions,
                TableOptions,
                CodeFenceStyle,
                CodeBlockOptions,
                charEntityFormat,
                HorizontalRuleFormat);
        }
    }
}
