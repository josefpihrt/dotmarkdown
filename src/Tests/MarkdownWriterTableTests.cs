// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text;
using Xunit;

namespace DotMarkdown.Tests
{
    public static class MarkdownWriterTableTests
    {
        [Fact]
        public static void TestTableHeaderWithSingleCharacter()
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(new StringBuilder()))
            {
                mw.WriteLine();

                mw.WriteStartTable(3);

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString(" ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("a");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("b");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteTableHeaderSeparator();

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString(" ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("c");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("d");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteEndTable();

                Assert.Equal(
                    @"
|     | a   | b   |
| --- | --- | --- |
|   | c | d |

",
                    mw.ToString());
            }
        }

        [Fact]
        public static void TestTableHeaderWithTwoCharacter()
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(new StringBuilder()))
            {
                mw.WriteLine();

                mw.WriteStartTable(3);

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString("  ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("aa");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("bb");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteTableHeaderSeparator();

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString(" ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("c");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("d");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteEndTable();

                Assert.Equal(
                    @"
|     | aa  | bb  |
| --- | --- | --- |
|   | c | d |

",
                    mw.ToString());
            }
        }

        [Fact]
        public static void TestTableHeaderWithThreeCharacter()
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(new StringBuilder()))
            {
                mw.WriteLine();

                mw.WriteStartTable(3);

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString("   ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("aaa");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("bbb");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteTableHeaderSeparator();

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString(" ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("c");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("d");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteEndTable();

                Assert.Equal(
                    @"
|     | aaa | bbb |
| --- | --- | --- |
|   | c | d |

",
                    mw.ToString());
            }
        }

        [Fact]
        public static void TestTableHeaderWithFourCharacter()
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(new StringBuilder()))
            {
                mw.WriteLine();

                mw.WriteStartTable(3);

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString("    ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("aaaa");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("bbbb");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteTableHeaderSeparator();

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString(" ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("c");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("d");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteEndTable();

                Assert.Equal(
                    @"
|      | aaaa | bbbb |
| ---- | ---- | ---- |
|   | c | d |

",
                    mw.ToString());
            }
        }

        [Fact]
        public static void TestTableWithInlineCode()
        {
            using (MarkdownWriter mw = MarkdownWriter.Create(new StringBuilder()))
            {
                mw.WriteLine();

                mw.WriteStartTable(3);

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString("    ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("a||a");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("b");
                mw.WriteInlineCode("b|b");
                mw.WriteString("b");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteTableHeaderSeparator();

                mw.WriteStartTableRow();

                mw.WriteStartTableCell();
                mw.WriteString(" ");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteString("c|c");
                mw.WriteEndTableCell();

                mw.WriteStartTableCell();
                mw.WriteInlineCode("|");
                mw.WriteEndTableCell();

                mw.WriteEndTableRow();

                mw.WriteEndTable();

                Assert.Equal(
                    @"
|      | a\|\|a | b`b\|b`b |
| ---- | ------ | -------- |
|   | c\|c | `\|` |

",
                    mw.ToString());
            }
        }
    }
}
