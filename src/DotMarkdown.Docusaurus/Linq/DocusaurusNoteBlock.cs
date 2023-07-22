﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus.Linq;

public class DocusaurusNoteBlock : DocusaurusAdmonition
{
    public DocusaurusNoteBlock(string text, string? title = null) : base(text, title)
    {
    }

    public DocusaurusNoteBlock(DocusaurusAdmonition other) : base(other)
    {
    }

    public override AdmonitionKind AdmonitionKind => AdmonitionKind.Note;

    internal override MElement Clone()
    {
        return new DocusaurusNoteBlock(this);
    }
}