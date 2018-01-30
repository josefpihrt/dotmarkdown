// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind} {Url,nq}")]
    public class MAutolink : MElement
    {
        private string _url;

        public MAutolink(string url)
        {
            Url = url;
        }

        public MAutolink(MAutolink other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            _url = other.Url;
        }

        public string Url
        {
            get { return _url; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                Error.ThrowIfContainsWhitespace(value, nameof(value));

                _url = value;
            }
        }

        public override MarkdownKind Kind => MarkdownKind.Autolink;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteAutolink(Url);
        }

        internal override MElement Clone()
        {
            return new MAutolink(this);
        }
    }
}
