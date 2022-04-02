// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown
{
    [Flags]
    public enum TableOptions
    {
        None = 0,
        FormatHeader = 1,
        FormatContent = 1 << 1,
        FormatHeaderAndContent = FormatHeader | FormatContent,
        Padding = 1 << 2,
        OuterDelimiter = 1 << 3,
        EmptyLineBefore = 1 << 4,
        EmptyLineAfter = 1 << 5,
        EmptyLineBeforeAndAfter = EmptyLineBefore | EmptyLineAfter,
    }
}
