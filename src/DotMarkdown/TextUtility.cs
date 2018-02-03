// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
namespace DotMarkdown
{
    internal static class TextUtility
    {
        public static bool IsNullOrSpace(string s)
        {
            if (s == null)
                return true;

            int length = s.Length;

            if (length == 0)
                return true;

            for (int i = 0; i < length; i++)
            {
                if (s[i] != ' ')
                    return false;
            }

            return true;
        }

        public static bool IsCarriageReturnOrLinefeed(char ch)
        {
            return ch == '\n' || ch == '\r';
        }

        public static bool IsAlphanumeric(string s)
        {
            if (s == null)
                return false;

            int length = s.Length;

            if (length == 0)
                return false;

            for (int i = 0; i < length; i++)
            {
                char ch = s[i];

                if (ch >= 48
                    && ch <= 122)
                {
                    if (ch <= 57) // 0-9
                        continue;

                    if (ch >= 97) // a-z
                        continue;

                    if (ch >= 65
                        && ch <= 90) // A-Z
                    {
                        continue;
                    }
                }

                return false;
            }

            return true;
        }

        public static string GetSpaces(int count)
        {
            switch (count)
            {
                case 1:
                    return " ";
                case 2:
                    return "  ";
                case 3:
                    return "   ";
                case 4:
                    return "    ";
                case 5:
                    return "     ";
                case 6:
                    return "      ";
                case 7:
                    return "       ";
                case 8:
                    return "        ";
                case 9:
                    return "         ";
                case 10:
                    return "          ";
                case 11:
                    return "           ";
                case 12:
                    return "            ";
            }

            Debug.Fail("");

            return new string(' ', count);
        }
    }
}
