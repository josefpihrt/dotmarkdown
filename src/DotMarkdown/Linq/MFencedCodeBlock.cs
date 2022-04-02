// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using System;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind}{InfoDebuggerDisplay,nq} {Text,nq}")]
    public class MFencedCodeBlock : MElement
    {
        private string _info;

        public MFencedCodeBlock(string text, string info = null)
        {
            Text = text;
            Info = info;
        }

        public MFencedCodeBlock(MFencedCodeBlock other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            Text = other.Text;
            _info = other.Info;
        }

        public string Text { get; set; }

        public string Info
        {
            get { return _info; }
            set
            {
                Error.ThrowOnInvalidFencedCodeBlockInfo(value);

                _info = value;
            }
        }

        public override MarkdownKind Kind => MarkdownKind.FencedCodeBlock;

        private string InfoDebuggerDisplay => (!string.IsNullOrEmpty(Info)) ? " " + Info : "";

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteFencedCodeBlock(Text, Info);
        }

        internal override MElement Clone()
        {
            return new MFencedCodeBlock(this);
        }
    }
}
