// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests;

public static class MLabelTests
{
    [Fact]
    public static void MLabel_Equals()
    {
        MLabel label = CreateLabel();

        Assert.True(label.Equals((object)label));
    }

    [Fact]
    public static void MLabel_NotEquals()
    {
        MLabel label = CreateLabel();
        MLabel label2 = label.Modify();

        Assert.False(label.Equals((object)label2));
    }

    [Fact]
    public static void MLabel_GetHashCode_Equal()
    {
        MLabel label = CreateLabel();

        Assert.Equal(label.GetHashCode(), label.GetHashCode());
    }

    [Fact]
    public static void MLabel_GetHashCode_NotEqual()
    {
        MLabel label = CreateLabel();
        MLabel label2 = label.Modify();

        Assert.NotEqual(label.GetHashCode(), label2.GetHashCode());
    }

    [Fact]
    public static void MLabel_OperatorEquals()
    {
        MLabel label = CreateLabel();
        MLabel label2 = label;

        Assert.True(label == label2);
    }

    [Fact]
    public static void MLabel_OperatorNotEquals()
    {
        MLabel label = CreateLabel();
        MLabel label2 = label.Modify();

        Assert.True(label != label2);
    }

    [Fact]
    public static void MLabel_Constructor_AssignText()
    {
        string text = LinkText();
        var label = new MLabel(text: text, url: LinkUrl(), title: LinkTitle());

        Assert.Equal(text, label.Text);
    }

    [Fact]
    public static void MLabel_Constructor_AssignUrl()
    {
        string url = LinkUrl();
        var label = new MLabel(text: LinkText(), url: url, title: LinkTitle());

        Assert.Equal(url, label.Url);
    }

    [Fact]
    public static void MLabel_Constructor_AssignTitle()
    {
        string title = LinkTitle();
        var label = new MLabel(text: LinkText(), url: LinkUrl(), title: title);

        Assert.Equal(title, label.Title);
    }
}
