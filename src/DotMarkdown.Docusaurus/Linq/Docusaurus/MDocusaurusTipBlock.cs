// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Docusaurus;

namespace DotMarkdown.Linq.Docusaurus;

public class MDocusaurusTipBlock : MDocusaurusAdmonition
{
    public MDocusaurusTipBlock(string text, string? title = null) : base(text, title)
    {
    }

    public MDocusaurusTipBlock(MDocusaurusAdmonition other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Tip;

    internal override MElement Clone()
    {
        return new MDocusaurusTipBlock(this);
    }
}
