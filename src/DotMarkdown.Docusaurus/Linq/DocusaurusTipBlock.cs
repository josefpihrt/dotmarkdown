// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

public class DocusaurusTipBlock : DocusaurusAdmonition
{
    public DocusaurusTipBlock(string text, string? title = null) : base(text, title)
    {
    }

    public DocusaurusTipBlock(DocusaurusAdmonition other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Tip;

    internal override MElement Clone()
    {
        return new DocusaurusTipBlock(this);
    }
}
