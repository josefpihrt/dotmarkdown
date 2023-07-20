﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;

namespace DotMarkdown.Linq;

[DebuggerDisplay("{Text,nq} {Url,nq}{TitleDebuggerDisplay,nq}")]
public class MLabel : MElement
{
    private string _url;

    public MLabel(string text, string url, string? title = null)
    {
        ValidateUrl(url);

        Text = text;
        _url = url;
        Title = title;
    }

    public MLabel(MLabel other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        Text = other.Text;
        _url = other.Url;
        Title = other.Title;
    }

    public string Text { get; set; }

    public string Url
    {
        get { return _url; }
        set
        {
            ValidateUrl(value);
            _url = value;
        }
    }

    private static void ValidateUrl(string value)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));

        Error.ThrowIfContainsWhitespace(value, nameof(value));
    }

    public string? Title { get; set; }

    private string TitleDebuggerDisplay => (!string.IsNullOrEmpty(Title)) ? " " + Title : "";

    public override MarkdownKind Kind => MarkdownKind.Label;

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteLabel(Text, Url, Title);
    }

    internal override MElement Clone()
    {
        return new MLabel(this);
    }
}
