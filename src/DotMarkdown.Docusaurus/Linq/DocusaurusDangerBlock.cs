// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

public class DocusaurusDangerBlock : DocusaurusAdmonitionBlock
{
    public DocusaurusDangerBlock(object? content) : base(content)
    {
    }

    public DocusaurusDangerBlock(params object[]? content) : base(content)
    {
    }

    public DocusaurusDangerBlock(DocusaurusDangerBlock other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Danger;

    internal override MElement Clone()
    {
        return new DocusaurusNoteBlock(this);
    }
}
