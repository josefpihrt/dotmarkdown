# DotMarkdown

## Introduction 

* DotMarkdown is Markdown framework for .NET 
* The library is distributed via [NuGet](https://www.nuget.org/packages/DotMarkdown).

## Supported Frameworks

* .NET Standard 1.3
* .NET Framework 4.5

## Usage 

### Commonly Used Types

* `DotMarkdown.MarkdownWriter`
* `DotMarkdown.MarkdownWriterSettings`
* `DotMarkdown.MarkdownFormat`
* `DotMarkdown.Linq.MFactory`

### MarkdownWriter

```csharp
using System.Text;
using DotMarkdown;
```

```csharp
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
```

#### Output

```csharp
Console.WriteLine(sb.ToString());
```

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

### LINQ to Markdown

```csharp
using DotMarkdown.Linq;
using static DotMarkdown.Linq.MFactory;
```

```csharp
MDocument document = Document(
    Heading1("Markdown Sample"),
    Heading2("Bullet List"),
    BulletList(
        "text",
        Bold("bold text")),
    HorizontalRule(),
    Heading2("IndentedCodeBlock"),
    IndentedCodeBlock("string s = null;"));
```

#### Output

```csharp
Console.WriteLine(document.ToString());
```

```
# Markdown Sample

## Bullet List

* text
* **bold text**

- - -

## IndentedCodeBlock

    string s = null;
```