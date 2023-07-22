// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Docusaurus;

namespace DotMarkdown.Linq.Docusaurus;

public class MDocusaurusInfoBlock : MDocusaurusAdmonition
{
    public MDocusaurusInfoBlock(string text, string? title = null) : base(text, title)
    {
    }

    public MDocusaurusInfoBlock(MDocusaurusAdmonition other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Info;

    internal override MElement Clone()
    {
        return new MDocusaurusInfoBlock(this);
    }
}
