// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown;

[Flags]
public enum HeadingOptions
{
    None = 0,
    UnderlineHeading1 = 1,
    UnderlineHeading2 = 1 << 1,
    Underline = UnderlineHeading1 | UnderlineHeading2,
    Close = 1 << 2,
    EmptyLineBefore = 1 << 3,
    EmptyLineAfter = 1 << 4,
    EmptyLineBeforeAndAfter = EmptyLineBefore | EmptyLineAfter,
}
