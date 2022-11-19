// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;

namespace DotMarkdown.Linq;

[DebuggerDisplay("{Kind}")]
public abstract class MObject
{
    public abstract MarkdownKind Kind { get; }

    public MDocument Document
    {
        get
        {
            var x = this;

            while (x.Parent is not null)
                x = x.Parent;

            return x as MDocument;
        }
    }

    public MContainer Parent { get; internal set; }
}
