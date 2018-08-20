// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using DotMarkdown.Linq;
using Xunit;
using static DotMarkdown.Tests.TestHelpers;

#pragma warning disable CS1718

namespace DotMarkdown.Tests
{
    public static class MLinkTests
    {
        [Fact]
        public static void MLink_Equals()
        {
            MLink link = CreateLink();

            Assert.True(link.Equals((object)link));
        }

        [Fact]
        public static void MLink_NotEquals()
        {
            MLink link = CreateLink();
            MLink link2 = link.Modify();

            Assert.False(link.Equals((object)link2));
        }

        [Fact]
        public static void MLink_GetHashCode_Equal()
        {
            MLink link = CreateLink();

            Assert.Equal(link.GetHashCode(), link.GetHashCode());
        }

        [Fact]
        public static void MLink_GetHashCode_NotEqual()
        {
            MLink link = CreateLink();
            MLink link2 = link.Modify();

            Assert.NotEqual(link.GetHashCode(), link2.GetHashCode());
        }

        [Fact]
        public static void MLink_OperatorEquals()
        {
            MLink link = CreateLink();
            MLink link2 = link;

            Assert.True(link == link2);
        }

        [Fact]
        public static void MLink_OperatorNotEquals()
        {
            MLink link = CreateLink();
            MLink link2 = link.Modify();

            Assert.True(link != link2);
        }

        [Fact]
        public static void MLink_Constructor_AssignText()
        {
            string content = LinkText();
            var link = new MLink(content: content, url: LinkUrl(), title: LinkTitle());

            Assert.Equal(content, link.content);
        }

        [Fact]
        public static void MLink_Constructor_AssignUrl()
        {
            string url = LinkUrl();
            var link = new MLink(content: LinkText(), url: url, title: LinkTitle());

            Assert.Equal(url, link.Url);
        }

        [Fact]
        public static void MLink_Constructor_AssignTitle()
        {
            string title = LinkTitle();
            var link = new MLink(content: LinkText(), url: LinkUrl(), title: title);

            Assert.Equal(title, link.Title);
        }

        [Fact]
        public static void MLink_Content()
        {
            string url = LinkUrl();
            string title = LinkTitle();

            var link = new MLink(
                content: new object[]
                {
                    MFactory.Bold("b"),
                    " ",
                    MFactory.Italic("i"),
                    " ",
                    MFactory.Strikethrough("s"),
                    " ",
                    MFactory.InlineCode("c"),
                    " ",
                    new MComment("cmt"),
                    " ",
                    MFactory.CharEntity(' '),
                    " ",
                    MFactory.EntityRef("amp"),
                },
                url: url,
                title: title);

            Assert.Equal($"[**b** *i* ~~s~~ `c` <!-- cmt --> &#x20; &amp;]({url} \"{title}\")", link.ToString());
        }
    }
}
