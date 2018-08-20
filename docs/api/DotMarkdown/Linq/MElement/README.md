<a name="_top"></a>

# MElement Class

[Home](../../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [DotMarkdown.Linq](../README.md#_top)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MElement : MObject
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/README.md#_top) &#x2192; MElement

### Derived

* DotMarkdown\.Linq\.[MAutolink](../MAutolink/README.md#_top)
* DotMarkdown\.Linq\.[MComment](../MComment/README.md#_top)
* DotMarkdown\.Linq\.[MContainer](../MContainer/README.md#_top)
* DotMarkdown\.Linq\.[MEntityRef](../MEntityRef/README.md#_top)
* DotMarkdown\.Linq\.[MFencedCodeBlock](../MFencedCodeBlock/README.md#_top)
* [...](#derived-all "See all derived types")

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MElement()](-ctor/README.md#_top) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Document](../MObject/Document/README.md#_top) |  \(Inherited from [MObject](../MObject/README.md#_top)\) |
| [Kind](../MObject/Kind/README.md#_top) |  \(Inherited from [MObject](../MObject/README.md#_top)\) |
| [NextElement](NextElement/README.md#_top) | |
| [Parent](../MObject/Parent/README.md#_top) |  \(Inherited from [MObject](../MObject/README.md#_top)\) |
| [PreviousElement](PreviousElement/README.md#_top) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Ancestors()](Ancestors/README.md#_top) | |
| [ElementsAfterSelf()](ElementsAfterSelf/README.md#_top) | |
| [ElementsBeforeSelf()](ElementsBeforeSelf/README.md#_top) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](Remove/README.md#_top) | |
| [Save(MarkdownWriter)](Save/README.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) | |
| [Save(Stream, MarkdownFormat)](Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) | |
| [Save(String, MarkdownFormat)](Save/README.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) | |
| [Save(TextWriter, MarkdownFormat)](Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) | |
| [ToString()](ToString/README.md#DotMarkdown_Linq_MElement_ToString) |  \(Overrides [Object.ToString](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)\) |
| [ToString(MarkdownFormat)](ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) | |
| [ToString(MarkdownWriterSettings)](ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) | |
| [WriteTo(MarkdownWriter)](WriteTo/README.md#_top) | |

## Derived \(All\)

* DotMarkdown\.Linq\.[MAutolink](../MAutolink/README.md#_top)
* DotMarkdown\.Linq\.[MComment](../MComment/README.md#_top)
* DotMarkdown\.Linq\.[MContainer](../MContainer/README.md#_top)
* DotMarkdown\.Linq\.[MEntityRef](../MEntityRef/README.md#_top)
* DotMarkdown\.Linq\.[MFencedCodeBlock](../MFencedCodeBlock/README.md#_top)
* &mdash;&mdash;&mdash;&mdash;&mdash;
* DotMarkdown\.Linq\.[MHorizontalRule](../MHorizontalRule/README.md#_top)
* DotMarkdown\.Linq\.[MCharEntity](../MCharEntity/README.md#_top)
* DotMarkdown\.Linq\.[MImage](../MImage/README.md#_top)
* DotMarkdown\.Linq\.[MIndentedCodeBlock](../MIndentedCodeBlock/README.md#_top)
* DotMarkdown\.Linq\.[MInlineCode](../MInlineCode/README.md#_top)
* DotMarkdown\.Linq\.[MLabel](../MLabel/README.md#_top)
* DotMarkdown\.Linq\.[MRaw](../MRaw/README.md#_top)
* DotMarkdown\.Linq\.[MText](../MText/README.md#_top)

