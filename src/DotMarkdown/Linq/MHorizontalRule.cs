// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown.Linq
{
    public class MHorizontalRule : MElement
    {
        private int _count;
        private string _separator;

        public MHorizontalRule(HorizontalRuleStyle style, int count, string separator)
        {
            Style = style;
            Count = count;
            Separator = separator;
        }

        public MHorizontalRule(in HorizontalRuleFormat format)
            : this(format.Style, format.Count, format.Separator)
        {
        }

        public MHorizontalRule(MHorizontalRule other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            Style = other.Style;
            _count = other.Count;
            _separator = other.Separator;
        }

        public HorizontalRuleStyle Style { get; set; }

        public int Count
        {
            get { return _count; }
            set
            {
                Error.ThrowOnInvalidHorizontalRuleCount(value);
                _count = value;
            }
        }

        public string Separator
        {
            get { return _separator; }
            set
            {
                Error.ThrowOnInvalidHorizontalRuleSeparator(value);
                _separator = value;
            }
        }

        public override MarkdownKind Kind => MarkdownKind.HorizontalRule;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteHorizontalRule(Style, Count, Separator);
        }

        internal override MElement Clone()
        {
            return new MHorizontalRule(this);
        }
    }
}
