// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus;

public class DocusaurusInfoBlock : DocusaurusAdmonitionBlock
{
    public DocusaurusInfoBlock(object? content) : base(content)
    {
    }

    public DocusaurusInfoBlock(params object[]? content) : base(content)
    {
    }

    public DocusaurusInfoBlock(DocusaurusInfoBlock other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Info;

    internal override MElement Clone()
    {
        return new DocusaurusInfoBlock(this);
    }
}
