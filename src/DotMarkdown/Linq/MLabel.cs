// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public class MLabel : MLink
    {
        public MLabel(string text, string url, string title = null)
            : base(text, url, title)
        {
        }

        public MLabel(MLabel other)
            : base(other)
        {
        }

        public override MarkdownKind Kind => MarkdownKind.Label;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteLabel(Text, Url, Title);
        }

        internal override MElement Clone()
        {
            return new MLabel(this);
        }
    }
}
