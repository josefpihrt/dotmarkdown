// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using DotMarkdown.Linq;

namespace DotMarkdown.Docusaurus;

[DebuggerDisplay("Docusaurus FrontMatter {ToStringDebuggerDisplay(),nq}")]
public class DocusaurusFrontMatter : MElement
{
    public DocusaurusFrontMatter(IEnumerable<(string Key, object Value)> labels)
    {
        Labels = labels ?? throw new ArgumentNullException(nameof(labels));
    }

    public DocusaurusFrontMatter(params (string Key, object Value)[] labels)
    {
        Labels = labels ?? throw new ArgumentNullException(nameof(labels));
    }

    public DocusaurusFrontMatter(DocusaurusFrontMatter other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Labels = other.Labels;
    }

    public override MarkdownKind Kind => MarkdownKind.FencedBlock;

    public IEnumerable<(string Key, object Value)> Labels { get; set; }

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteDocusaurusFrontMatter(Labels);
    }

    internal override MElement Clone()
    {
        return new DocusaurusFrontMatter(this);
    }
}
