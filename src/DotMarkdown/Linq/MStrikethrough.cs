// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public class MStrikethrough : MInline
    {
        public MStrikethrough()
        {
        }

        public MStrikethrough(object content)
            : base(content)
        {
        }

        public MStrikethrough(params object[] content)
            : base(content)
        {
        }

        public MStrikethrough(MStrikethrough other)
            : base(other)
        {
        }

        public override MarkdownKind Kind => MarkdownKind.Strikethrough;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteStartStrikethrough();
            WriteContentTo(writer);
            writer.WriteEndStrikethrough();
        }

        internal override MElement Clone()
        {
            return new MStrikethrough(this);
        }
    }
}
