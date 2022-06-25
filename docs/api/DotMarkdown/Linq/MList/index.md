---
sidebar_label: MList
---

# MList Class

**Namespace**: [DotMarkdown.Linq](../index.md)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MList : DotMarkdown.Linq.MContainer
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/index.md) &#x2192; [MElement](../MElement/index.md) &#x2192; [MContainer](../MContainer/index.md) &#x2192; MList

### Derived

* [MBulletList](../MBulletList/index.md)
* [MOrderedList](../MOrderedList/index.md)
* [MTaskList](../MTaskList/index.md)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MList()](-ctor/index.md#DotMarkdown_Linq_MList__ctor) | |
| [MList(MList)](-ctor/index.md#DotMarkdown_Linq_MList__ctor_DotMarkdown_Linq_MList_) | |
| [MList(Object)](-ctor/index.md#DotMarkdown_Linq_MList__ctor_System_Object_) | |
| [MList(Object\[\])](-ctor/index.md#DotMarkdown_Linq_MList__ctor_System_Object___) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Document](../MObject/Document/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [FirstElement](../MContainer/FirstElement/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [IsEmpty](../MContainer/IsEmpty/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [Kind](../MObject/Kind/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [LastElement](../MContainer/LastElement/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [NextElement](../MElement/NextElement/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Parent](../MObject/Parent/index.md) |  \(Inherited from [MObject](../MObject/index.md)\) |
| [PreviousElement](../MElement/PreviousElement/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Object)](../MContainer/Add/index.md#DotMarkdown_Linq_MContainer_Add_System_Object_) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [Add(Object\[\])](../MContainer/Add/index.md#DotMarkdown_Linq_MContainer_Add_System_Object___) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [Ancestors()](../MElement/Ancestors/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [AncestorsAndSelf()](../MContainer/AncestorsAndSelf/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [Descendants()](../MContainer/Descendants/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [DescendantsAndSelf()](../MContainer/DescendantsAndSelf/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [Elements()](../MContainer/Elements/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [ElementsAfterSelf()](../MElement/ElementsAfterSelf/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ElementsBeforeSelf()](../MElement/ElementsBeforeSelf/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](../MElement/Remove/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [RemoveAll()](../MContainer/RemoveAll/index.md) |  \(Inherited from [MContainer](../MContainer/index.md)\) |
| [Save(MarkdownWriter)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Save(Stream, MarkdownFormat)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Save(String, MarkdownFormat)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [Save(TextWriter, MarkdownFormat)](../MElement/Save/index.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ToString()](../MElement/ToString/index.md#DotMarkdown_Linq_MElement_ToString) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ToString(MarkdownFormat)](../MElement/ToString/index.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [ToString(MarkdownWriterSettings)](../MElement/ToString/index.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) |  \(Inherited from [MElement](../MElement/index.md)\) |
| [WriteTo(MarkdownWriter)](../MElement/WriteTo/index.md) |  \(Inherited from [MElement](../MElement/index.md)\) |

