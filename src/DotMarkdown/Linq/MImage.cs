// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public class MImage : MLink
    {
        public MImage(string text, string url, string title = null)
            : base(text, url, title)
        {
        }

        public MImage(MImage other)
            : base(other)
        {
        }

        public override MarkdownKind Kind => MarkdownKind.Image;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteImage(Text, Url, Title);
        }

        internal override MElement Clone()
        {
            return new MImage(this);
        }
    }
}
