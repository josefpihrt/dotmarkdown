// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace DotMarkdown;

public enum MarkdownKind
{
    None = 0,

    Text = 1,
    Raw = 2,
    Link = 3,
    LinkReference = 4,
    Image = 5,
    ImageReference = 6,
    Label = 7,
    Autolink = 8,
    InlineCode = 9,
    CharEntity = 10,
    EntityRef = 11,
    Comment = 12,

    [Obsolete]
    FencedCodeBlock = 13,

    FencedBlock = 13,

    IndentedCodeBlock = 14,
    HorizontalRule = 15,

    Heading = 16,

    Inline = 17,
    Bold = 18,
    Italic = 19,
    Strikethrough = 20,

    Table = 21,
    TableRow = 22,
    TableColumn = 23,

    BulletList = 24,
    OrderedList = 25,
    TaskList = 26,

    BulletItem = 27,
    OrderedItem = 28,
    TaskItem = 29,

    BlockQuote = 30,

    Document = 31,
}
