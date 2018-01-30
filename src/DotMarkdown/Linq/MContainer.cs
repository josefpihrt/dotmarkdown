// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DotMarkdown.Linq
{
    public abstract class MContainer : MElement
    {
        internal object content;

        protected MContainer()
        {
        }

        protected MContainer(object content)
        {
            Add(content);
        }

        protected MContainer(params object[] content)
        {
            Add(content);
        }

        protected MContainer(MContainer other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            if (other.content is string)
            {
                content = other.content;
            }
            else
            {
                var e = (MElement)other.content;

                if (e != null)
                {
                    do
                    {
                        e = e.next;
                        AppendElement(e.Clone());

                    } while (e != other.content);
                }
            }
        }

        internal virtual bool AllowStringConcatenation => true;

        public bool IsEmpty
        {
            get { return content == null; }
        }

        public MElement FirstElement
        {
            get { return LastElement?.next; }
        }

        public MElement LastElement
        {
            get
            {
                if (content == null)
                    return null;

                if (content is MElement element)
                    return element;

                if (content is string s)
                {
                    if (s.Length == 0)
                        return null;

                    var t = new MText(s) { Parent = this };
                    t.next = t;

                    Interlocked.CompareExchange<object>(ref content, t, s);
                }

                return (MElement)content;
            }
        }

        internal void WriteContentTo(MarkdownWriter writer)
        {
            if (content is string s)
            {
                writer.WriteString(s);
            }
            else
            {
                foreach (MElement element in Elements())
                    element.WriteTo(writer);
            }
        }

        public IEnumerable<MElement> Elements()
        {
            MElement e = LastElement;

            if (e != null)
            {
                do
                {
                    e = e.next;
                    yield return e;

                } while (e.Parent == this && e != content);
            }
        }

        public IEnumerable<MContainer> AncestorsAndSelf()
        {
            return GetAncestors(self: true);
        }

        public IEnumerable<MElement> Descendants()
        {
            return GetDescendants(self: false);
        }

        public IEnumerable<MElement> DescendantsAndSelf()
        {
            return GetDescendants(self: true);
        }

        internal IEnumerable<MElement> GetDescendants(bool self)
        {
            MElement e = this;

            if (self)
                yield return e;

            var c = this;

            while (true)
            {
                MElement first = c?.FirstElement;

                if (first != null)
                {
                    e = first;
                }
                else
                {
                    while (e != this
                        && e == e.Parent.content)
                    {
                        e = e.Parent;
                    }

                    if (e == this)
                        break;

                    e = e.next;
                }

                if (e != null)
                    yield return e;

                c = e as MContainer;
            }
        }

        internal void RemoveElement(MElement e)
        {
            var p = (MElement)content;

            while (p.next != e)
                p = p.next;

            if (p == e)
            {
                content = null;
            }
            else
            {
                if (content == e)
                    content = p;

                p.next = e.next;
            }

            e.Parent = null;
            e.next = null;
        }

        public void RemoveAll()
        {
            if (content == null)
                return;

            if (content is string)
            {
                content = null;
                return;
            }

            var e = (MElement)content;

            do
            {
                MElement n = e.next;

                e.Parent = null;
                e.next = null;

                e = n;

            } while (e != content);

            content = null;
        }

        public void Add(object content)
        {
            if (content == null)
                return;

            if (content is MElement element)
            {
                AddElement(element);
                return;
            }

            if (content is string s)
            {
                AddString(s);
                return;
            }

            if (content is object[] arr)
            {
                foreach (object item in arr)
                    Add(item);

                return;
            }

            if (content is IEnumerable enumerable)
            {
                foreach (object item in enumerable)
                    Add(item);

                return;
            }

            AddString(content.ToString());
        }

        public void Add(params object[] content)
        {
            Add((object)content);
        }

        internal void AddElement(MElement e)
        {
            ValidateElement(e);

            if (e.Parent != null)
            {
                e = e.Clone();
            }
            else
            {
                var p = this;

                while (p.Parent != null)
                    p = p.Parent;

                if (e == p)
                {
                    e = e.Clone();
                }
            }

            ConvertTextToElement();
            AppendElement(e);
        }

        internal void AppendElement(MElement e)
        {
            e.Parent = this;

            if (content == null
                || content is string)
            {
                e.next = e;
            }
            else
            {
                var x = (MElement)content;
                e.next = x.next;
                x.next = e;
            }

            content = e;
        }

        internal void AddString(string s)
        {
            ValidateString(s);

            if (content == null)
            {
                content = s;
            }
            else if (s.Length > 0)
            {
                if (AllowStringConcatenation)
                {
                    if (content is string stringContent)
                    {
                        content = stringContent + s;
                    }
                    else if (content is MText text)
                    {
                        text.Value += s;
                    }
                    else
                    {
                        AppendElement(new MText(s));
                    }
                }
                else
                {
                    ConvertTextToElement();
                    AppendElement(new MText(s));
                }
            }
        }

        internal virtual void ValidateElement(MElement element)
        {
            switch (element.Kind)
            {
                case MarkdownKind.Text:
                case MarkdownKind.Raw:
                case MarkdownKind.Link:
                case MarkdownKind.LinkReference:
                case MarkdownKind.Image:
                case MarkdownKind.ImageReference:
                case MarkdownKind.Autolink:
                case MarkdownKind.InlineCode:
                case MarkdownKind.CharEntity:
                case MarkdownKind.EntityRef:
                case MarkdownKind.Comment:
                case MarkdownKind.Bold:
                case MarkdownKind.Italic:
                case MarkdownKind.Strikethrough:
                case MarkdownKind.Inline:
                    return;
            }

            Error.InvalidContent(this, element);
        }

        internal virtual void ValidateString(string s)
        {
        }

        internal void ConvertTextToElement()
        {
            var s = content as string;

            if (!string.IsNullOrEmpty(s))
            {
                var t = new MText(s) { Parent = this };

                t.next = t;
                content = t;
            }
        }
    }
}