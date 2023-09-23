# DotMarkdown <img align="left" width="48px" height="48px" src="images/dotmarkdown-logo-small.png">

## Introduction 

* DotMarkdown is a framework for creating markdown content 
* The library is distributed as [![NuGet](https://img.shields.io/nuget/v/DotMarkdown.svg)](https://nuget.org/packages/DotMarkdown).

## Supported Frameworks

* .NET Standard 1.3
* .NET Framework 4.6

## Documentation

* [Reference documentation](https://josefpihrt.github.io/docs/dotmarkdown/api)

## Usage 

### Commonly Used Types

* `DotMarkdown.MarkdownWriter`
* `DotMarkdown.MarkdownWriterSettings`
* `DotMarkdown.MarkdownFormat`
* `DotMarkdown.Linq.MFactory`

### How to Use MarkdownWriter

```csharp
using System.Text;
using DotMarkdown;

var sb = new StringBuilder();

using (MarkdownWriter writer = MarkdownWriter.Create(sb))
{
    writer.WriteHeading1("Markdown Sample");
    writer.WriteHeading2("Bullet List");
    writer.WriteBulletItem("text");
    writer.WriteStartBulletItem();
    writer.WriteBold("bold text");
    writer.WriteEndBulletItem();

    writer.WriteHorizontalRule();

    writer.WriteHeading2("Indented Code Block");
    writer.WriteIndentedCodeBlock("string s = null;");
}

Console.WriteLine(sb.ToString());
```

#### Output

```
# Markdown Sample

## Bullet List

* text
* **bold text**
- - -

## Indented Code Block

    string s = null;
```

- - -

### How to Use LINQ to Markdown

```csharp
using DotMarkdown.Linq;
using static DotMarkdown.Linq.MFactory;

MDocument document = Document(
    Heading1("Markdown Sample"),
    Heading2("Bullet List"),
    BulletList(
        "text",
        Bold("bold text")),
    HorizontalRule(),
    Heading2("IndentedCodeBlock"),
    IndentedCodeBlock("string s = null;"));

Console.WriteLine(document.ToString());
```

#### Output

```
# Markdown Sample

## Bullet List

* text
* **bold text**

- - -

## IndentedCodeBlock

    string s = null;
```

## Links

* [Mastering Markdown](http://guides.github.com/features/mastering-markdown/)
* [Markdown Cheatsheet](http://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet)
* [Markdown Guide](https://www.markdownguide.org)
* [Daring Fireball: Markdown Syntax Documentation](http://daringfireball.net/projects/markdown/syntax)
* [CommonMark Spec](http://spec.commonmark.org)