// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public class MImageTests
    {
        [Fact]
        public void MImage_Equals()
        {
            MImage image = CreateImage();

            Assert.True(image.Equals((object)image));
        }

        [Fact]
        public void MImage_NotEquals()
        {
            MImage image = CreateImage();
            MImage image2 = image.Modify();

            Assert.False(image.Equals((object)image2));
        }

        [Fact]
        public void MImage_GetHashCode_Equal()
        {
            MImage image = CreateImage();

            Assert.Equal(image.GetHashCode(), image.GetHashCode());
        }

        [Fact]
        public void MImage_GetHashCode_NotEqual()
        {
            MImage image = CreateImage();
            MImage image2 = image.Modify();

            Assert.NotEqual(image.GetHashCode(), image2.GetHashCode());
        }

        [Fact]
        public void MImage_OperatorEquals()
        {
            MImage image = CreateImage();
            MImage image2 = image;

            Assert.True(image == image2);
        }

        [Fact]
        public void MImage_OperatorNotEquals()
        {
            MImage image = CreateImage();
            MImage image2 = image.Modify();

            Assert.True(image != image2);
        }

        [Fact]
        public void MImage_Constructor_AssignText()
        {
            string text = LinkText();
            var image = new MImage(text: text, url: LinkUrl(), title: LinkTitle());

            Assert.Equal(text, image.Text);
        }

        [Fact]
        public void MImage_Constructor_AssignUrl()
        {
            string url = LinkUrl();
            var image = new MImage(text: LinkText(), url: url, title: LinkTitle());

            Assert.Equal(url, image.Url);
        }

        [Fact]
        public void MImage_Constructor_AssignTitle()
        {
            string title = LinkTitle();
            var image = new MImage(text: LinkText(), url: LinkUrl(), title: title);

            Assert.Equal(title, image.Title);
        }
    }
}
