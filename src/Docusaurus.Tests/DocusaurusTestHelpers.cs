// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using static DotMarkdown.Tests.TestHelpers;

namespace DotMarkdown.Tests;

internal static class DocusaurusTestHelpers
{
    public static MFencedCodeBlock CreateCodeBlock()
    {
        return new MFencedCodeBlock(CodeBlockText(), CodeBlockInfo());
    }
}
