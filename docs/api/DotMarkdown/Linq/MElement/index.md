---
sidebar_label: MElement
---

# MElement Class

**Namespace**: [DotMarkdown.Linq](../index.md)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MElement : DotMarkdown.Linq.MObject
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/index.md) &#x2192; MElement

### Derived

* [MAutolink](../MAutolink/index.md)
* [MCharEntity](../MCharEntity/index.md)
* [MComment](../MComment/index.md)
* [MContainer](../MContainer/index.md)
* [MEntityRef](../MEntityRef/index.md)
* [MFencedCodeBlock](../MFencedCodeBlock/index.md)
* [MHorizontalRule](../MHorizontalRule/index.md)
* [MImage](../MImage/index.md)
* [MIndentedCodeBlock](../MIndentedCodeBlock/index.md)
* [MInlineCode](../MInlineCode/index.md)
* [...](#derived-all "See all derived types")

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MElement()](-ctor/index.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Document](../MObject/Document/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [Kind](../MObject/Kind/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [NextElement](NextElement/index.md) | |
| [Parent](../MObject/Parent/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [PreviousElement](PreviousElement/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Ancestors()](Ancestors/index.md) | |
| [ElementsAfterSelf()](ElementsAfterSelf/index.md) | |
| [ElementsBeforeSelf()](ElementsBeforeSelf/index.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](Remove/index.md) | |
| [Save(MarkdownWriter)](Save/index.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) | |
| [Save(Stream, MarkdownFormat)](Save/index.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) | |
| [Save(String, MarkdownFormat)](Save/index.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) | |
| [Save(TextWriter, MarkdownFormat)](Save/index.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) | |
| [ToString()](ToString/index.md#DotMarkdown_Linq_MElement_ToString) |  \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |
| [ToString(MarkdownFormat)](ToString/index.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) | |
| [ToString(MarkdownWriterSettings)](ToString/index.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) | |
| [WriteTo(MarkdownWriter)](WriteTo/index.md) | |

## Derived \(All\)

* [MAutolink](../MAutolink/index.md)
* [MCharEntity](../MCharEntity/index.md)
* [MComment](../MComment/index.md)
* [MContainer](../MContainer/index.md)
* [MEntityRef](../MEntityRef/index.md)
* [MFencedCodeBlock](../MFencedCodeBlock/index.md)
* [MHorizontalRule](../MHorizontalRule/index.md)
* [MImage](../MImage/index.md)
* [MIndentedCodeBlock](../MIndentedCodeBlock/index.md)
* [MInlineCode](../MInlineCode/index.md)
* &mdash;&mdash;&mdash;&mdash;&mdash;
* [MLabel](../MLabel/index.md)
* [MRaw](../MRaw/index.md)
* [MText](../MText/index.md)
