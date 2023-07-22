// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq.Docusaurus;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Docusaurus.Tests;

internal static class DocusaurusTestHelpers
{
    public static MDocusaurusCodeBlock CreateDocusaurusCodeBlock()
    {
        return new MDocusaurusCodeBlock(CodeBlockText(), CodeBlockInfo(), "file.txt", showLineNumbers: true);
    }
}
