// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown
{
    [Flags]
    public enum TableOptions
    {
        None = 0,
        FormatHeader = 1,
        FormatContent = 2,
        FormatHeaderAndContent = FormatHeader | FormatContent,
        Padding = 4,
        OuterDelimiter = 8,
        EmptyLineBefore = 16,
        EmptyLineAfter = 32,
        EmptyLineBeforeAndAfter = EmptyLineBefore | EmptyLineAfter,
    }
}
