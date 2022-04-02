// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind} {Text, nq}")]
    public class MInlineCode : MElement
    {
        public MInlineCode(string text)
        {
            Text = text;
        }

        public MInlineCode(MInlineCode other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            Text = other.Text;
        }

        public string Text { get; }

        public override MarkdownKind Kind => MarkdownKind.InlineCode;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteInlineCode(Text);
        }

        internal override MElement Clone()
        {
            return new MInlineCode(this);
        }
    }
}
