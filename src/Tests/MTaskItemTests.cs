// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public static class MTaskItemTests
    {
        [Fact]
        public static void MTaskItem_Equals()
        {
            MTaskItem item = CreateTaskListItem();

            Assert.True(item.Equals((object)item));
        }

        [Fact]
        public static void MTaskItem_GetHashCode_Equal()
        {
            MTaskItem item = CreateTaskListItem();

            Assert.Equal(item.GetHashCode(), item.GetHashCode());
        }

        [Fact]
        public static void MTaskItem_OperatorEquals()
        {
            MTaskItem item = CreateTaskListItem();
            MTaskItem item2 = item;

            Assert.True(item == item2);
        }

        [Fact]
        public static void MTaskItem_Constructor_AssignIsCompleted()
        {
            bool isCompleted = TaskListItemIsCompleted();
            var item = new MTaskItem(isCompleted: isCompleted, content: StringValue());

            Assert.Equal(isCompleted, item.IsCompleted);
        }
    }
}
