// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests;

public static class MRawTests
{
    [Fact]
    public static void MRaw_Equals()
    {
        MRaw rawText = CreateRawText();

        Assert.True(rawText.Equals((object)rawText));
    }

    [Fact]
    public static void MRaw_NotEquals()
    {
        MRaw rawText = CreateRawText();
        MRaw rawText2 = rawText.Modify();

        Assert.False(rawText.Equals((object)rawText2));
    }

    [Fact]
    public static void MRaw_GetHashCode_Equal()
    {
        MRaw rawText = CreateRawText();

        Assert.Equal(rawText.GetHashCode(), rawText.GetHashCode());
    }

    [Fact]
    public static void MRaw_GetHashCode_NotEqual()
    {
        MRaw rawText = CreateRawText();
        MRaw rawText2 = rawText.Modify();

        Assert.NotEqual(rawText.GetHashCode(), rawText2.GetHashCode());
    }

    [Fact]
    public static void MRaw_OperatorEquals()
    {
        MRaw rawText = CreateRawText();
        MRaw rawText2 = rawText;

        Assert.True(rawText == rawText2);
    }

    [Fact]
    public static void MRaw_OperatorNotEquals()
    {
        MRaw rawText = CreateRawText();
        MRaw rawText2 = rawText.Modify();

        Assert.True(rawText != rawText2);
    }
}
