// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests;

public static class MOrderedItemTests
{
    [Fact]
    public static void MOrderedItem_Equals()
    {
        MOrderedItem item = CreateOrderedListItem();

        Assert.True(item.Equals((object)item));
    }

    [Fact]
    public static void MOrderedItem_GetHashCode_Equal()
    {
        MOrderedItem item = CreateOrderedListItem();

        Assert.Equal(item.GetHashCode(), item.GetHashCode());
    }

    [Fact]
    public static void MOrderedItem_OperatorEquals()
    {
        MOrderedItem item = CreateOrderedListItem();
        MOrderedItem item2 = item;

        Assert.True(item == item2);
    }

    [Fact]
    public static void MOrderedItem_Constructor_AssignNumber()
    {
        int number = OrderedListItemNumber();
        var item = new MOrderedItem(number: number, content: StringValue());

        Assert.Equal(number, item.Number);
    }
}
