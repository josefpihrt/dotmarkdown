// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public static class MTableColumnTests
    {
        [Fact]
        public static void MTableColumn_Equals()
        {
            MTableColumn column = CreateTableColumn();

            Assert.True(column.Equals((object)column));
        }

        [Fact]
        public static void MTableColumn_GetHashCode_Equal()
        {
            MTableColumn column = CreateTableColumn();

            Assert.Equal(column.GetHashCode(), column.GetHashCode());
        }

        [Fact]
        public static void MTableColumn_OperatorEquals()
        {
            MTableColumn column = CreateTableColumn();
            MTableColumn column2 = column;

            Assert.True(column == column2);
        }

        [Fact]
        public static void MTableColumn_Constructor_AssignAlignment()
        {
            HorizontalAlignment alignment = TableColumnAlignment();
            var column = new MTableColumn(alignment: alignment, content: StringValue());

            Assert.Equal(alignment, column.Alignment);
        }
    }
}
