// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public class MBlockQuoteTests
    {
        [Fact]
        public void MBlockQuote_Equals()
        {
            MBlockQuote blockQuote = CreateBlockQuote();

            Assert.True(blockQuote.Equals((object)blockQuote));
        }

        [Fact]
        public void MBlockQuote_GetHashCode_Equal()
        {
            MBlockQuote blockQuote = CreateBlockQuote();

            Assert.Equal(blockQuote.GetHashCode(), blockQuote.GetHashCode());
        }

        [Fact]
        public void MBlockQuote_OperatorEquals()
        {
            MBlockQuote blockQuote = CreateBlockQuote();
            MBlockQuote blockQuote2 = blockQuote;

            Assert.True(blockQuote == blockQuote2);
        }
    }
}
