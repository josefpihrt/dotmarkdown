// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public class MBulletItemTests
    {
        [Fact]
        public void MBulletItem_Equals()
        {
            MBulletItem item = CreateListItem();

            Assert.True(item.Equals((object)item));
        }

        [Fact]
        public void MBulletItem_GetHashCode_Equal()
        {
            MBulletItem item = CreateListItem();

            Assert.Equal(item.GetHashCode(), item.GetHashCode());
        }

        [Fact]
        public void MBulletItem_OperatorEquals()
        {
            MBulletItem item = CreateListItem();
            MBulletItem item2 = item;

            Assert.True(item == item2);
        }
    }
}
