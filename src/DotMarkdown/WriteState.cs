// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown
{
    public enum WriteState
    {
        Start = 0,
        Content = 1,
        Closed = 2,
        Error = 3
    }
}