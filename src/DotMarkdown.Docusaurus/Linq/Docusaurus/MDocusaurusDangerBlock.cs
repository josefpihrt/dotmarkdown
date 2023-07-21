// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Docusaurus;

namespace DotMarkdown.Linq.Docusaurus;

public class MDocusaurusDangerBlock : MDocusaurusAdmonition
{
    public MDocusaurusDangerBlock(string text, string? title = null) : base(text, title)
    {
    }

    public MDocusaurusDangerBlock(MDocusaurusAdmonition other) : base(other)
    {
    }

    public override AdmonitionStyle Style => AdmonitionStyle.Danger;

    internal override MElement Clone()
    {
        return new MDocusaurusNoteBlock(this);
    }
}
