// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace DotMarkdown.Linq
{
    [DebuggerDisplay("{Kind} {ToStringDebuggerDisplay(),nq}")]
    public abstract class MElement : MObject
    {
        internal MElement next;

        public MElement NextElement
        {
            get
            {
                return (Parent is not null && Parent.content != this)
                    ? next
                    : null;
            }
        }

        public MElement PreviousElement
        {
            get
            {
                if (Parent is null)
                    return null;

                MElement e = ((MElement)Parent.content).next;

                MElement p = null;

                while (e != this)
                {
                    p = e;

                    e = e.next;
                }

                return p;
            }
        }

        public abstract void WriteTo(MarkdownWriter writer);

        internal abstract MElement Clone();

        public override string ToString()
        {
            return ToString(default(MarkdownWriterSettings));
        }

        public string ToString(MarkdownFormat format)
        {
            return ToString(MarkdownWriterSettings.From(format));
        }

        public string ToString(MarkdownWriterSettings settings)
        {
            StringBuilder sb = StringBuilderCache.GetInstance();

            using (var writer = new MarkdownStringWriter(sb, settings))
            {
                WriteTo(writer);

                return StringBuilderCache.GetStringAndFree(writer.GetStringBuilder());
            }
        }

        internal string ToStringDebuggerDisplay()
        {
            return ToString(MarkdownWriterSettings.Debugging);
        }

        public void Save(string fileName, MarkdownFormat format = null)
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(fileName, MarkdownWriterSettings.From(format)))
            {
                Save(mw);
            }
        }

        public void Save(Stream stream, MarkdownFormat format = null)
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(stream, MarkdownWriterSettings.From(format)))
            {
                Save(mw);
            }
        }

        public void Save(TextWriter writer, MarkdownFormat format = null)
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(writer, MarkdownWriterSettings.From(format)))
            {
                Save(mw);
            }
        }

        public void Save(MarkdownWriter writer)
        {
            if (writer is null)
                throw new ArgumentNullException(nameof(writer));

            WriteTo(writer);
        }

        public IEnumerable<MContainer> Ancestors()
        {
            return GetAncestors(self: false);
        }

        internal IEnumerable<MContainer> GetAncestors(bool self)
        {
            var c = ((self) ? this : Parent) as MContainer;

            while (c is not null)
            {
                yield return c;

                c = c.Parent;
            }
        }

        public IEnumerable<MElement> ElementsAfterSelf()
        {
            var e = this;

            while (e.Parent is not null
                && e.Parent.content != e)
            {
                e = e.next;

                yield return e;
            }
        }

        public IEnumerable<MElement> ElementsBeforeSelf()
        {
            if (Parent is not null)
            {
                var e = (MElement)Parent.content;

                do
                {
                    e = e.next;

                    if (e == this)
                        break;

                    yield return e;
                }
                while (Parent is not null && Parent == e.Parent);
            }
        }

        public void Remove()
        {
            if (Parent is null)
                throw new InvalidOperationException("Element has no parent.");

            Parent.RemoveElement(this);
        }
    }
}
