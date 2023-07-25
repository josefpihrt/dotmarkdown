// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus;

public class DocusaurusTipBlock : DocusaurusAdmonitionBlock
{
    public DocusaurusTipBlock(object? content) : base(content)
    {
    }

    public DocusaurusTipBlock(params object[]? content) : base(content)
    {
    }

    public DocusaurusTipBlock(DocusaurusTipBlock other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Tip;

    internal override MElement Clone()
    {
        return new DocusaurusTipBlock(this);
    }
}
