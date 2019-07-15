# MElement Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [DotMarkdown.Linq](../README.md)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MElement : DotMarkdown.Linq.MObject
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/README.md) &#x2192; MElement

### Derived

* [MAutolink](../MAutolink/README.md)
* [MCharEntity](../MCharEntity/README.md)
* [MComment](../MComment/README.md)
* [MContainer](../MContainer/README.md)
* [MEntityRef](../MEntityRef/README.md)
* [...](#derived-all "See all derived types")

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MElement()](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Document](../MObject/Document/README.md) |  \(Inherited from [MObject](../MObject/README.md)\) |
| [Kind](../MObject/Kind/README.md) |  \(Inherited from [MObject](../MObject/README.md)\) |
| [NextElement](NextElement/README.md) | |
| [Parent](../MObject/Parent/README.md) |  \(Inherited from [MObject](../MObject/README.md)\) |
| [PreviousElement](PreviousElement/README.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Ancestors()](Ancestors/README.md) | |
| [ElementsAfterSelf()](ElementsAfterSelf/README.md) | |
| [ElementsBeforeSelf()](ElementsBeforeSelf/README.md) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](Remove/README.md) | |
| [Save(MarkdownWriter)](Save/README.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) | |
| [Save(Stream, MarkdownFormat)](Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) | |
| [Save(String, MarkdownFormat)](Save/README.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) | |
| [Save(TextWriter, MarkdownFormat)](Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) | |
| [ToString()](ToString/README.md#DotMarkdown_Linq_MElement_ToString) |  \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |
| [ToString(MarkdownFormat)](ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) | |
| [ToString(MarkdownWriterSettings)](ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) | |
| [WriteTo(MarkdownWriter)](WriteTo/README.md) | |

## Derived \(All\)

* [MAutolink](../MAutolink/README.md)
* [MCharEntity](../MCharEntity/README.md)
* [MComment](../MComment/README.md)
* [MContainer](../MContainer/README.md)
* [MEntityRef](../MEntityRef/README.md)
* &mdash;&mdash;&mdash;&mdash;&mdash;
* [MFencedCodeBlock](../MFencedCodeBlock/README.md)
* [MHorizontalRule](../MHorizontalRule/README.md)
* [MImage](../MImage/README.md)
* [MIndentedCodeBlock](../MIndentedCodeBlock/README.md)
* [MInlineCode](../MInlineCode/README.md)
* [MLabel](../MLabel/README.md)
* [MRaw](../MRaw/README.md)
* [MText](../MText/README.md)
