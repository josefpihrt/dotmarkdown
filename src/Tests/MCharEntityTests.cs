// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public static class MCharEntityTests
    {
        [Fact]
        public static void MCharEntity_Equals()
        {
            MCharEntity htmlEntity = CreateHtmlEntity();

            Assert.True(htmlEntity.Equals((object)htmlEntity));
        }

        [Fact]
        public static void MCharEntity_NotEquals()
        {
            MCharEntity htmlEntity = CreateHtmlEntity();
            MCharEntity htmlEntity2 = htmlEntity.Modify();

            Assert.False(htmlEntity.Equals((object)htmlEntity2));
        }

        [Fact]
        public static void MCharEntity_GetHashCode_Equal()
        {
            MCharEntity htmlEntity = CreateHtmlEntity();

            Assert.Equal(htmlEntity.GetHashCode(), htmlEntity.GetHashCode());
        }

        [Fact]
        public static void MCharEntity_GetHashCode_NotEqual()
        {
            MCharEntity htmlEntity = CreateHtmlEntity();
            MCharEntity htmlEntity2 = htmlEntity.Modify();

            Assert.NotEqual(htmlEntity.GetHashCode(), htmlEntity2.GetHashCode());
        }

        [Fact]
        public static void MCharEntity_OperatorEquals()
        {
            MCharEntity htmlEntity = CreateHtmlEntity();
            MCharEntity htmlEntity2 = htmlEntity;

            Assert.True(htmlEntity == htmlEntity2);
        }

        [Fact]
        public static void MCharEntity_OperatorNotEquals()
        {
            MCharEntity htmlEntity = CreateHtmlEntity();
            MCharEntity htmlEntity2 = htmlEntity.Modify();

            Assert.True(htmlEntity != htmlEntity2);
        }

        [Fact]
        public static void MCharEntity_Constructor_AssignNumber()
        {
            char ch = CharEntityChar();
            var htmlEntity = new MCharEntity(value: ch);

            Assert.Equal(ch, htmlEntity.Value);
        }
    }
}
