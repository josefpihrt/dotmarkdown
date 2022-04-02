// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind} {Name}")]
    public class MEntityRef : MElement
    {
        private string _name;

        public MEntityRef(string name)
            : this(name, isTrustedName: false)
        {
        }

        private MEntityRef(string name, bool isTrustedName)
        {
            if (isTrustedName)
            {
                _name = name;
            }
            else
            {
                Name = name;
            }
        }

        public MEntityRef(MEntityRef other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            _name = other.Name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                Error.ThrowOnInvalidEntityName(value);

                _name = value;
            }
        }

        public override MarkdownKind Kind => MarkdownKind.EntityRef;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteEntityRef(Name);
        }

        internal override MElement Clone()
        {
            return new MEntityRef(this);
        }

        internal static MEntityRef CreateTrusted(string name)
        {
            return new MEntityRef(name, isTrustedName: true);
        }
    }
}
