// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind} {Number} {ToStringDebuggerDisplay(),nq}")]
    public class MOrderedItem : MBlockContainer
    {
        private int _number;

        public MOrderedItem(int number)
        {
            Number = number;
        }

        public MOrderedItem(int number, object content)
            : base(content)
        {
            Number = number;
        }

        public MOrderedItem(int number, params object[] content)
            : base(content)
        {
            Number = number;
        }

        public MOrderedItem(MOrderedItem other)
            : base(other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            _number = other.Number;
        }

        public int Number
        {
            get { return _number; }
            set
            {
                Error.ThrowOnInvalidItemNumber(value);
                _number = value;
            }
        }

        public override MarkdownKind Kind => MarkdownKind.OrderedItem;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteStartOrderedItem(Number);
            WriteContentTo(writer);
            writer.WriteEndOrderedItem();
        }

        internal override MElement Clone()
        {
            return new MOrderedItem(this);
        }
    }
}
