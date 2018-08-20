// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using DotMarkdown.Linq;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Tests
{
    internal static class ModifyExtensions
    {
        public static string Modify(this string value)
        {
            return value + "x";
        }

        public static string ModifySpaces(this string value, int minValue, int maxValue)
        {
            string newValue = null;

            do
            {
                newValue = Spaces(minValue, maxValue);

            } while (newValue == value);

            return newValue;
        }

        public static int Modify(this int value)
        {
            int newValue = 0;

            do
            {
                newValue = IntValue();

            } while (newValue == value);

            return newValue;
        }

        public static int Modify(this int value, int maxValue)
        {
            int newValue = 0;

            do
            {
                newValue = IntValue(maxValue);

            } while (newValue == value);

            return newValue;
        }

        public static int Modify(this int value, int minValue, int maxValue)
        {
            int newValue = 0;

            do
            {
                newValue = IntValue(minValue, maxValue);

            } while (newValue == value);

            return newValue;
        }

        public static bool Modify(this bool value)
        {
            return !value;
        }

        public static MFencedCodeBlock Modify(this MFencedCodeBlock block)
        {
            return new MFencedCodeBlock(block.Text.Modify(), block.Info.Modify());
        }

        public static MIndentedCodeBlock Modify(this MIndentedCodeBlock block)
        {
            return new MIndentedCodeBlock(block.Text.Modify());
        }

        public static MImage Modify(this MImage image)
        {
            return new MImage(image.Text.Modify(), image.Url.Modify(), image.Title.Modify());
        }

        public static MLink Modify(this MLink link)
        {
            return new MLink(link.content.ToString().Modify(), link.Url.Modify(), link.Title.Modify());
        }

        public static MRaw Modify(this MRaw text)
        {
            return new MRaw(text.Value.Modify());
        }

        public static MarkdownFormat Modify(this MarkdownFormat x)
        {
            return new MarkdownFormat(
                x.BoldStyle.Modify(),
                x.ItalicStyle.Modify(),
                x.BulletListStyle.Modify(),
                x.OrderedListStyle.Modify(),
                x.HeadingStyle.Modify(),
                x.HeadingOptions.Modify(),
                x.TableOptions.Modify(),
                x.CodeFenceStyle.Modify(),
                x.CodeBlockOptions.Modify(),
                x.CharEntityFormat.Modify(),
                horizontalRuleFormat: x.HorizontalRuleFormat.Modify());
        }

        public static HorizontalRuleFormat Modify(this in HorizontalRuleFormat format)
        {
            HorizontalRuleStyle style = format.Style;

            do
            {
                style = HorizontalRuleStyle();

            } while (style != format.Style);

            return new HorizontalRuleFormat(style, format.Count.Modify(3, 10), format.Separator + " ");
        }

        public static BulletListStyle Modify(this BulletListStyle style)
        {
            switch (style)
            {
                case BulletListStyle.Asterisk:
                    return BulletListStyle.Plus;
                case BulletListStyle.Plus:
                    return BulletListStyle.Minus;
                case BulletListStyle.Minus:
                    return BulletListStyle.Asterisk;
                default:
                    throw new ArgumentException(style.ToString(), nameof(style));
            }
        }

        public static OrderedListStyle Modify(this OrderedListStyle style)
        {
            switch (style)
            {
                case OrderedListStyle.Dot:
                    return OrderedListStyle.Parenthesis;
                case OrderedListStyle.Parenthesis:
                    return OrderedListStyle.Dot;
                default:
                    throw new ArgumentException(style.ToString(), nameof(style));
            }
        }

        public static HeadingStyle Modify(this HeadingStyle style)
        {
            switch (style)
            {
                case HeadingStyle.NumberSign:
                    return HeadingStyle.NumberSign;
                default:
                    throw new ArgumentException(style.ToString(), nameof(style));
            }
        }

        public static HeadingOptions Modify(this HeadingOptions options)
        {
            switch (options)
            {
                case HeadingOptions.None:
                    return HeadingOptions.EmptyLineBefore;
                default:
                    return HeadingOptions.None;
            }
        }

        public static TableOptions Modify(this TableOptions options)
        {
            switch (options)
            {
                case TableOptions.None:
                    return TableOptions.FormatHeader;
                default:
                    return TableOptions.None;
            }
        }

        public static CodeFenceStyle Modify(this CodeFenceStyle style)
        {
            switch (style)
            {
                case CodeFenceStyle.Backtick:
                    return CodeFenceStyle.Tilde;
                case CodeFenceStyle.Tilde:
                    return CodeFenceStyle.Backtick;
                default:
                    throw new ArgumentException(style.ToString(), nameof(style));
            }
        }

        public static CodeBlockOptions Modify(this CodeBlockOptions options)
        {
            switch (options)
            {
                case CodeBlockOptions.None:
                    return CodeBlockOptions.EmptyLineBefore;
                default:
                    return CodeBlockOptions.None;
            }
        }

        public static EmphasisStyle Modify(this EmphasisStyle style)
        {
            switch (style)
            {
                case EmphasisStyle.Asterisk:
                    return EmphasisStyle.Underscore;
                case EmphasisStyle.Underscore:
                    return EmphasisStyle.Asterisk;
                default:
                    throw new ArgumentException(style.ToString(), nameof(style));
            }
        }

        public static HorizontalAlignment Modify(this HorizontalAlignment alignment)
        {
            switch (alignment)
            {
                case HorizontalAlignment.Left:
                    return HorizontalAlignment.Center;
                case HorizontalAlignment.Center:
                    return HorizontalAlignment.Right;
                case HorizontalAlignment.Right:
                    return HorizontalAlignment.Left;
                default:
                    throw new ArgumentException(alignment.ToString(), nameof(alignment));
            }
        }

        public static MCharEntity Modify(this MCharEntity htmlEntity)
        {
            return new MCharEntity((char)((int)htmlEntity.Value).Modify(1, 0xFFFF));
        }

        public static CharEntityFormat Modify(this CharEntityFormat format)
        {
            switch (format)
            {
                case CharEntityFormat.Hexadecimal:
                    return CharEntityFormat.Decimal;
                case CharEntityFormat.Decimal:
                    return CharEntityFormat.Hexadecimal;
                default:
                    throw new ArgumentException(format.ToString(), nameof(format));
            }
        }
    }
}
