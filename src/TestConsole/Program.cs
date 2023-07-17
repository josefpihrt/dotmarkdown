// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using DotMarkdown.Linq;
using static DotMarkdown.Linq.MFactory;

namespace DotMarkdown.TestConsole;

public static class Program
{
    public static void Main()
    {
        MDocument document = Document();

        Console.WriteLine(document.ToString());

        Console.ReadKey();
    }
}
