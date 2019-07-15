# MContainer Class

[Home](../../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [DotMarkdown.Linq](../README.md)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MContainer : DotMarkdown.Linq.MElement
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/README.md) &#x2192; [MElement](../MElement/README.md) &#x2192; MContainer

### Derived

* [MBlockContainer](../MBlockContainer/README.md)
* [MHeading](../MHeading/README.md)
* [MInline](../MInline/README.md)
* [MLink](../MLink/README.md)
* [MList](../MList/README.md)
* [...](#derived-all "See all derived types")

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MContainer()](-ctor/README.md#DotMarkdown_Linq_MContainer__ctor) | |
| [MContainer(MContainer)](-ctor/README.md#DotMarkdown_Linq_MContainer__ctor_DotMarkdown_Linq_MContainer_) | |
| [MContainer(Object)](-ctor/README.md#DotMarkdown_Linq_MContainer__ctor_System_Object_) | |
| [MContainer(Object\[\])](-ctor/README.md#DotMarkdown_Linq_MContainer__ctor_System_Object___) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Document](../MObject/Document/README.md) |  \(Inherited from [MObject](../MObject/README.md)\) |
| [FirstElement](FirstElement/README.md) | |
| [IsEmpty](IsEmpty/README.md) | |
| [Kind](../MObject/Kind/README.md) |  \(Inherited from [MObject](../MObject/README.md)\) |
| [LastElement](LastElement/README.md) | |
| [NextElement](../MElement/NextElement/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [Parent](../MObject/Parent/README.md) |  \(Inherited from [MObject](../MObject/README.md)\) |
| [PreviousElement](../MElement/PreviousElement/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Object)](Add/README.md#DotMarkdown_Linq_MContainer_Add_System_Object_) | |
| [Add(Object\[\])](Add/README.md#DotMarkdown_Linq_MContainer_Add_System_Object___) | |
| [Ancestors()](../MElement/Ancestors/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [AncestorsAndSelf()](AncestorsAndSelf/README.md) | |
| [Descendants()](Descendants/README.md) | |
| [DescendantsAndSelf()](DescendantsAndSelf/README.md) | |
| [Elements()](Elements/README.md) | |
| [ElementsAfterSelf()](../MElement/ElementsAfterSelf/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [ElementsBeforeSelf()](../MElement/ElementsBeforeSelf/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](../MElement/Remove/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [RemoveAll()](RemoveAll/README.md) | |
| [Save(MarkdownWriter)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [Save(Stream, MarkdownFormat)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [Save(String, MarkdownFormat)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [Save(TextWriter, MarkdownFormat)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [ToString()](../MElement/ToString/README.md#DotMarkdown_Linq_MElement_ToString) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [ToString(MarkdownFormat)](../MElement/ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [ToString(MarkdownWriterSettings)](../MElement/ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) |  \(Inherited from [MElement](../MElement/README.md)\) |
| [WriteTo(MarkdownWriter)](../MElement/WriteTo/README.md) |  \(Inherited from [MElement](../MElement/README.md)\) |

## Derived \(All\)

* [MBlockContainer](../MBlockContainer/README.md)
* [MHeading](../MHeading/README.md)
* [MInline](../MInline/README.md)
* [MLink](../MLink/README.md)
* [MList](../MList/README.md)
* &mdash;&mdash;&mdash;&mdash;&mdash;
* [MTable](../MTable/README.md)
* [MTableColumn](../MTableColumn/README.md)
* [MTableRow](../MTableRow/README.md)
