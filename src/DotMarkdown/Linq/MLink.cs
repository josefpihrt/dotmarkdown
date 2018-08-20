// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown.Linq
{
    public class MLink : MContainer
    {
        private string _url;

        public MLink(object content, string url, string title = null)
            : base(content)
        {
            Url = url;
            Title = title;
        }

        public MLink(MLink other)
            : base(other)
        {
            _url = other.Url;
            Title = other.Title;
        }

        internal override void ValidateElement(MElement element)
        {
            switch (element.Kind)
            {
                case MarkdownKind.Text:
                case MarkdownKind.Raw:
                case MarkdownKind.InlineCode:
                case MarkdownKind.CharEntity:
                case MarkdownKind.EntityRef:
                case MarkdownKind.Comment:
                case MarkdownKind.Bold:
                case MarkdownKind.Italic:
                case MarkdownKind.Strikethrough:
                    return;
            }

            Error.InvalidContent(this, element);
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

        public string Title { get; set; }

        public override MarkdownKind Kind => MarkdownKind.Link;

        public override void WriteTo(MarkdownWriter writer)
        {
            writer.WriteStartLink();
            WriteContentTo(writer);
            writer.WriteEndLink(Url, Title);
        }

        internal override MElement Clone()
        {
            return new MLink(this);
        }
    }
}
