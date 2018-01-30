// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public class MLinkTests
    {
        [Fact]
        public void MLink_Equals()
        {
            MLink link = CreateLink();

            Assert.True(link.Equals((object)link));
        }

        [Fact]
        public void MLink_NotEquals()
        {
            MLink link = CreateLink();
            MLink link2 = link.Modify();

            Assert.False(link.Equals((object)link2));
        }

        [Fact]
        public void MLink_GetHashCode_Equal()
        {
            MLink link = CreateLink();

            Assert.Equal(link.GetHashCode(), link.GetHashCode());
        }

        [Fact]
        public void MLink_GetHashCode_NotEqual()
        {
            MLink link = CreateLink();
            MLink link2 = link.Modify();

            Assert.NotEqual(link.GetHashCode(), link2.GetHashCode());
        }

        [Fact]
        public void MLink_OperatorEquals()
        {
            MLink link = CreateLink();
            MLink link2 = link;

            Assert.True(link == link2);
        }

        [Fact]
        public void MLink_OperatorNotEquals()
        {
            MLink link = CreateLink();
            MLink link2 = link.Modify();

            Assert.True(link != link2);
        }

        [Fact]
        public void MLink_Constructor_AssignText()
        {
            string text = LinkText();
            var link = new MLink(text: text, url: LinkUrl(), title: LinkTitle());

            Assert.Equal(text, link.Text);
        }

        [Fact]
        public void MLink_Constructor_AssignUrl()
        {
            string url = LinkUrl();
            var link = new MLink(text: LinkText(), url: url, title: LinkTitle());

            Assert.Equal(url, link.Url);
        }

        [Fact]
        public void MLink_Constructor_AssignTitle()
        {
            string title = LinkTitle();
            var link = new MLink(text: LinkText(), url: LinkUrl(), title: title);

            Assert.Equal(title, link.Title);
        }
    }
}
