// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public class MBlockQuote : MBlockContainer
    {
        public MBlockQuote()
        {
        }

        public MBlockQuote(object content)
            : base(content)
        {
        }

        public MBlockQuote(params object[] content)
            : base(content)
        {
        }

        public MBlockQuote(MBlockQuote other)
            : base(other)
        {
        }

        public override MarkdownKind Kind => MarkdownKind.BlockQuote;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteStartBlockQuote();
            WriteContentTo(writer);
            writer.WriteEndBlockQuote();
        }

        internal override MElement Clone()
        {
            return new MBlockQuote(this);
        }
    }
}
