// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown.Docusaurus;

internal static class Extensions
{
    public static string GetText(this AdmonitionKind kind)
    {
        return kind switch
        {
            AdmonitionKind.Note => "note",
            AdmonitionKind.Tip => "tip",
            AdmonitionKind.Info => "info",
            AdmonitionKind.Caution => "caution",
            AdmonitionKind.Danger => "danger",
            _ => throw new ArgumentException($"Unknown {nameof(AdmonitionKind)} '{kind}'", nameof(kind))
        };
    }
}
