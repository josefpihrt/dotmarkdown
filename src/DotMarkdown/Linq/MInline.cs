// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public class MInline : MContainer
    {
        public MInline()
        {
        }

        public MInline(object content)
            : base(content)
        {
        }

        public MInline(params object[] content)
            : base(content)
        {
        }

        public MInline(MContainer other)
            : base(other)
        {
        }

        public override MarkdownKind Kind => MarkdownKind.Inline;

        public override void WriteTo(MarkdownWriter writer)
        {
            WriteContentTo(writer);
        }

        internal override MElement Clone()
        {
            return new MInline(this);
        }
    }
}