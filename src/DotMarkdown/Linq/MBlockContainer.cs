// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown.Linq
{
    public abstract class MBlockContainer : MContainer
    {
        protected MBlockContainer()
        {
        }

        protected MBlockContainer(object content)
            : base(content)
        {
        }

        protected MBlockContainer(params object[] content)
            : base(content)
        {
        }

        protected MBlockContainer(MBlockContainer other)
            : base(other)
        {
        }

        internal override void ValidateElement(MElement element)
        {
            switch (element.Kind)
            {
                case MarkdownKind.TableColumn:
                case MarkdownKind.TableRow:
                case MarkdownKind.Document:
                    {
                        Error.InvalidContent(this, element);
                        break;
                    }
            }
        }
    }
}
