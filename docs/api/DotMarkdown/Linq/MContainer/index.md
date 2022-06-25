---
sidebar_label: MContainer
---

# MContainer Class

**Namespace**: [DotMarkdown.Linq](../index.md)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MContainer : DotMarkdown.Linq.MElement
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/index.md) &#x2192; [MElement](../MElement/index.md) &#x2192; MContainer

### Derived

* [MBlockContainer](../MBlockContainer/index.md)
* [MHeading](../MHeading/index.md)
* [MInline](../MInline/index.md)
* [MLink](../MLink/index.md)
* [MList](../MList/index.md)
* [MTable](../MTable/index.md)
* [MTableColumn](../MTableColumn/index.md)
* [MTableRow](../MTableRow/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MContainer()](-ctor/index.md#DotMarkdown_Linq_MContainer__ctor) | |
| [MContainer(MContainer)](-ctor/index.md#DotMarkdown_Linq_MContainer__ctor_DotMarkdown_Linq_MContainer_) | |
| [MContainer(Object)](-ctor/index.md#DotMarkdown_Linq_MContainer__ctor_System_Object_) | |
| [MContainer(Object\[\])](-ctor/index.md#DotMarkdown_Linq_MContainer__ctor_System_Object___) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Document](../MObject/Document/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [FirstElement](FirstElement/index.md) | |
| [IsEmpty](IsEmpty/index.md) | |
| [Kind](../MObject/Kind/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [LastElement](LastElement/index.md) | |
| [NextElement](../MElement/NextElement/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Parent](../MObject/Parent/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [PreviousElement](../MElement/PreviousElement/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Object)](Add/index.md#DotMarkdown_Linq_MContainer_Add_System_Object_) | |
| [Add(Object\[\])](Add/index.md#DotMarkdown_Linq_MContainer_Add_System_Object___) | |
| [Ancestors()](../MElement/Ancestors/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [AncestorsAndSelf()](AncestorsAndSelf/index.md) | |
| [Descendants()](Descendants/index.md) | |
| [DescendantsAndSelf()](DescendantsAndSelf/index.md) | |
| [Elements()](Elements/index.md) | |
| [ElementsAfterSelf()](../MElement/ElementsAfterSelf/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ElementsBeforeSelf()](../MElement/ElementsBeforeSelf/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](../MElement/Remove/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [RemoveAll()](RemoveAll/index.md) | |
| [Save(MarkdownWriter)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Save(Stream, MarkdownFormat)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Save(String, MarkdownFormat)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Save(TextWriter, MarkdownFormat)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ToString()](../MElement/ToString/index.md#DotMarkdown_Linq_MElement_ToString) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ToString(MarkdownFormat)](../MElement/ToString/index.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ToString(MarkdownWriterSettings)](../MElement/ToString/index.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [WriteTo(MarkdownWriter)](../MElement/WriteTo/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |

