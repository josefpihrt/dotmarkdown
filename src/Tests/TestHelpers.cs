// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Text;
using DotMarkdown.Linq;

namespace DotMarkdown.Tests
{
    internal static class TestHelpers
    {
        private static readonly Random _random = new Random();

        public const string Chars = @"! "" # $ % & ' ) ( * + , - . / : ; < = > ? @ ] [ \ ^ _ ` } { | ~";

        public const string CharsWithoutSpaces = @"!""#$%&')(*+,-./:;<=>?@][\^_`}{|~";

        public const string CharsEscaped = @"\! "" \# $ % & ' \) \( \* \+ , \- \. / : ; \< = > ? @ \] \[ \\ ^ \_ \` \} \{ \| \~";

        public const string CharsSquareBracketsBacktickLessThanEscaped = @"! "" # $ % & ' ) ( * + , - . / : ; \< = > ? @ \] \[ \ ^ _ \` } { | ~";

        public const string CharsWithoutSpacesParenthesesEscaped = @"!""#$%&'\)\(*+,-./:;<=>?@][\^_`}{|~";

        public const string CharsDoubleQuoteEscaped = @"! \"" # $ % & ' ) ( * + , - . / : ; < = > ? @ ] [ \ ^ _ ` } { | ~";

        public const string CharsEnclosedWithBacktick = @"` ! "" # $ % & ' ) ( * + , - . / : ; < = > ? @ ] [ \ ^ _ } { | ~ `";

        public const string CharsEnclosedWithBacktickDoubled = @"`` ! "" # $ % & ' ) ( * + , - . / : ; < = > ? @ ] [ \ ^ _ } { | ~ ``";

        public const string CharsWithoutBacktick = @"! "" # $ % & ' ) ( * + , - . / : ; < = > ? @ ] [ \ ^ _ } { | ~";

        public const string NewLine = "\r\n";

        public const string DefaultText = "Text";

        public static string NewLine2 { get; } = NewLine + NewLine;

        public static string Backtick { get; } = "`";

        public static MFencedCodeBlock CreateCodeBlock()
        {
            return new MFencedCodeBlock(CodeBlockText(), CodeBlockInfo());
        }

        public static string CodeBlockText()
        {
            return StringValue();
        }

        public static MIndentedCodeBlock CreateIndentedCodeBlock()
        {
            return new MIndentedCodeBlock(IndentedCodeBlockText());
        }

        public static string IndentedCodeBlockText()
        {
            return StringValue();
        }

        public static string CodeBlockInfo()
        {
            return StringValue();
        }

        public static MHeading CreateHeading()
        {
            return new MHeading(HeadingLevel(), HeadingText());
        }

        public static string HeadingText()
        {
            return StringValue();
        }

        public static int HeadingLevel()
        {
            return IntValue(1, 6);
        }

        public static HorizontalRuleFormat HorizontalRuleFormat()
        {
            return new HorizontalRuleFormat(HorizontalRuleStyle(), HorizontalRuleCount(), HorizontalRuleSpace());
        }

        public static MHorizontalRule CreateHorizontalRule()
        {
            return new MHorizontalRule(HorizontalRuleStyle(), HorizontalRuleCount(), HorizontalRuleSpace());
        }

        public static HorizontalRuleStyle HorizontalRuleStyle()
        {
            return (HorizontalRuleStyle)IntValue(0, 2);
        }

        public static int HorizontalRuleCount()
        {
            return IntValue(3, 10);
        }

        public static string HorizontalRuleSpace()
        {
            return Spaces(0, 2);
        }

        public static MImage CreateImage()
        {
            return new MImage(LinkText(), LinkUrl(), LinkTitle());
        }

        public static MLink CreateLink()
        {
            return new MLink(LinkText(), LinkUrl(), LinkTitle());
        }

        public static string LinkText()
        {
            return StringValue();
        }

        public static string LinkUrl()
        {
            return StringValue();
        }

        public static string LinkTitle()
        {
            return StringValue();
        }

        public static MBulletItem CreateListItem()
        {
            return new MBulletItem(BulletItemText());
        }

        public static string BulletItemText()
        {
            return StringValue();
        }

        public static MText CreateMarkdownText()
        {
            return new MText(MarkdownTextText());
        }

        public static string MarkdownTextText()
        {
            return StringValue();
        }

        public static MRaw CreateRawText()
        {
            return new MRaw(RawTextText());
        }

        public static string RawTextText()
        {
            return StringValue();
        }

        public static MOrderedItem CreateOrderedListItem()
        {
            return new MOrderedItem(OrderedListItemNumber(), BulletItemText());
        }

        public static int OrderedListItemNumber()
        {
            return IntValue(0, 9);
        }

        public static MBlockQuote CreateBlockQuote()
        {
            return new MBlockQuote(BlockQuoteText());
        }

        public static string BlockQuoteText()
        {
            return StringValue();
        }

        public static MTableColumn CreateTableColumn()
        {
            return new MTableColumn(TableColumnAlignment(), TableColumnName());
        }

        public static string TableColumnName()
        {
            return StringValue();
        }

        public static HorizontalAlignment TableColumnAlignment()
        {
            return (HorizontalAlignment)IntValue(0, 2);
        }

        public static MTaskItem CreateTaskListItem()
        {
            return new MTaskItem(TaskListItemIsCompleted(), BulletItemText());
        }

        public static bool TaskListItemIsCompleted()
        {
            return BoolValue();
        }

        public static MarkdownFormat CreateMarkdownFormat()
        {
            return new MarkdownFormat(
                BoldStyle(),
                ItalicStyle(),
                BulletListStyle(),
                OrderedListStyle(),
                HeadingStyle(),
                HeadingOptions(),
                TableOptions(),
                CodeFenceStyle(),
                CodeBlockOptions(),
                HtmlEntityFormat(),
                horizontalRuleFormat: HorizontalRuleFormat());
        }

        public static EmphasisStyle BoldStyle()
        {
            return (EmphasisStyle)IntValue(0, 1);
        }

        public static EmphasisStyle ItalicStyle()
        {
            return (EmphasisStyle)IntValue(0, 1);
        }

        public static BulletListStyle BulletListStyle()
        {
            return (BulletListStyle)IntValue(0, 2);
        }

        public static OrderedListStyle OrderedListStyle()
        {
            return (OrderedListStyle)IntValue(0, 1);
        }

        public static HeadingStyle HeadingStyle()
        {
            return (HeadingStyle)IntValue(0, 0);
        }

        public static HeadingOptions HeadingOptions()
        {
            return (HeadingOptions)IntValue(0, 16);
        }

        public static TableOptions TableOptions()
        {
            return (TableOptions)IntValue(0, 8);
        }

        public static CodeFenceStyle CodeFenceStyle()
        {
            return (CodeFenceStyle)IntValue(0, 1);
        }

        public static CodeBlockOptions CodeBlockOptions()
        {
            return (CodeBlockOptions)IntValue(0, 3);
        }

        public static MCharEntity CreateHtmlEntity()
        {
            return new MCharEntity(CharEntityChar());
        }

        public static char CharEntityChar()
        {
            int value = 0;

            do
            {
                value = IntValue(0, 0xFFFF);

            } while (value >= 0xD800
                && value <= 0xDFFF);

            return (char)value;
        }

        public static CharEntityFormat HtmlEntityFormat()
        {
            return (CharEntityFormat)IntValue(0, 1);
        }

        public static MarkdownWriter CreateWriter(MarkdownFormat format = null)
        {
            return CreateBuilder(new StringBuilder(), format);
        }

        public static MarkdownWriter CreateBuilderWithHtmlEntityFormat(CharEntityFormat? format)
        {
            return CreateWriter((format != null) ? new MarkdownFormat(charEntityFormat: format.Value) : null);
        }

        public static MarkdownWriter CreateBuilderWithCodeBlockOptions(CodeBlockOptions options)
        {
            return CreateWriter(new MarkdownFormat(codeBlockOptions: options));
        }

        public static MarkdownWriter CreateBuilderWithCodeFenceOptions(CodeFenceStyle? style)
        {
            return CreateWriter((style != null) ? new MarkdownFormat(codeFenceStyle: style.Value) : null);
        }

        public static MarkdownWriter CreateBuilderWithBoldStyle(EmphasisStyle? boldStyle)
        {
            return CreateWriter((boldStyle != null) ? new MarkdownFormat(boldStyle: boldStyle.Value) : null);
        }

        public static MarkdownWriter CreateBuilderWithItalicStyle(EmphasisStyle? italicStyle)
        {
            return CreateWriter((italicStyle != null) ? new MarkdownFormat(italicStyle: italicStyle.Value) : null);
        }

        public static MarkdownWriter CreateBuilderWithHeadingOptions(HeadingOptions? headingOptions)
        {
            return CreateWriter((headingOptions != null) ? new MarkdownFormat(headingOptions: headingOptions.Value) : null);
        }

        public static MarkdownWriter CreateBuilderWithBulletItemStyle(BulletListStyle? style)
        {
            return CreateWriter((style != null) ? new MarkdownFormat(bulletListStyle: style.Value) : null);
        }

        public static MarkdownWriter CreateBuilder(StringBuilder sb, MarkdownFormat format = null)
        {
            return MarkdownWriter.Create(sb, settings: MarkdownWriterSettings.From(format));
        }

        public static int IntValue()
        {
            return _random.Next();
        }

        public static int IntValue(int maxValue)
        {
            return _random.Next(maxValue + 1);
        }

        public static int IntValue(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue + 1);
        }

        public static string StringValue(int length = 3)
        {
            var chars = new char[length];

            for (int i = 0; i < length; i++)
            {
                chars[i] = (char)IntValue(97, 122);
            }

            return new string(chars);
        }

        public static string Spaces(int minValue, int maxValue)
        {
            return new string(' ', IntValue(minValue, maxValue));
        }

        public static bool BoolValue()
        {
            return IntValue(0, 1) == 1;
        }
    }
}
