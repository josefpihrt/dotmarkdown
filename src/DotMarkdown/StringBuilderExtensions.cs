// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;

namespace DotMarkdown;

internal static class StringBuilderExtensions
{
    public static bool IsWhiteSpace(this StringBuilder sb)
    {
        return IsWhiteSpace(sb, 0, sb.Length);
    }

    public static bool IsWhiteSpace(this StringBuilder sb, int index, int length)
    {
        int max = index + length;

        for (int i = index; i < max; i++)
        {
            if (!char.IsWhiteSpace(sb[i]))
                return false;
        }

        return true;
    }
}
