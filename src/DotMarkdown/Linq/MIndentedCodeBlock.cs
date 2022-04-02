// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind} {Text,nq}")]
    public class MIndentedCodeBlock : MElement
    {
        public MIndentedCodeBlock(string text)
        {
            Text = text;
        }

        public MIndentedCodeBlock(MIndentedCodeBlock other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            Text = other.Text;
        }

        public string Text { get; set; }

        public override MarkdownKind Kind => MarkdownKind.IndentedCodeBlock;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteIndentedCodeBlock(Text);
        }

        internal override MElement Clone()
        {
            return new MIndentedCodeBlock(this);
        }
    }
}
