// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace DotMarkdown
{
    internal static class Int32Extensions
    {
        public static int GetDigitCount(this int value)
        {
            if (value < 0)
                value = -value;

            if (value < 10)
                return 1;

            if (value < 100)
                return 2;

            if (value < 1000)
                return 3;

            if (value < 10000)
                return 4;

            if (value < 100000)
                return 5;

            if (value < 1000000)
                return 6;

            if (value < 10000000)
                return 7;

            if (value < 100000000)
                return 8;

            if (value < 1000000000)
                return 9;

            return 10;
        }
    }
}
