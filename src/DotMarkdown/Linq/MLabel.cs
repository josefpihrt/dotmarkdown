// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Text,nq} {Url,nq}{TitleDebuggerDisplay,nq}")]
    public class MLabel : MElement
    {
        private string _url;

        public MLabel(string text, string url, string title = null)
        {
            Text = text;
            Url = url;
            Title = title;
        }

        public MLabel(MLabel other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            Text = other.Text;
            _url = other.Url;
            Title = other.Title;
        }

        public string Text { get; set; }

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

        public string Title { get; set; }

        private string TitleDebuggerDisplay => (!string.IsNullOrEmpty(Title)) ? " " + Title : "";

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
