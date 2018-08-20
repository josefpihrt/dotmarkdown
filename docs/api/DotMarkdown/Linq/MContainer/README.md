<a name="_top"></a>

# MContainer Class

[Home](../../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [DotMarkdown.Linq](../README.md#_top)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MContainer : MElement
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [MObject](../MObject/README.md#_top) &#x2192; [MElement](../MElement/README.md#_top) &#x2192; MContainer

### Derived

* DotMarkdown\.Linq\.[MBlockContainer](../MBlockContainer/README.md#_top)
* DotMarkdown\.Linq\.[MHeading](../MHeading/README.md#_top)
* DotMarkdown\.Linq\.[MInline](../MInline/README.md#_top)
* DotMarkdown\.Linq\.[MLink](../MLink/README.md#_top)
* DotMarkdown\.Linq\.[MList](../MList/README.md#_top)
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
| [Document](../MObject/Document/README.md#_top) |  \(Inherited from [MObject](../MObject/README.md#_top)\) |
| [FirstElement](FirstElement/README.md#_top) | |
| [IsEmpty](IsEmpty/README.md#_top) | |
| [Kind](../MObject/Kind/README.md#_top) |  \(Inherited from [MObject](../MObject/README.md#_top)\) |
| [LastElement](LastElement/README.md#_top) | |
| [NextElement](../MElement/NextElement/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [Parent](../MObject/Parent/README.md#_top) |  \(Inherited from [MObject](../MObject/README.md#_top)\) |
| [PreviousElement](../MElement/PreviousElement/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |

## Methods

| Method | Summary |
| ------ | ------- |
| [Add(Object)](Add/README.md#DotMarkdown_Linq_MContainer_Add_System_Object_) | |
| [Add(Object\[\])](Add/README.md#DotMarkdown_Linq_MContainer_Add_System_Object___) | |
| [Ancestors()](../MElement/Ancestors/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [AncestorsAndSelf()](AncestorsAndSelf/README.md#_top) | |
| [Descendants()](Descendants/README.md#_top) | |
| [DescendantsAndSelf()](DescendantsAndSelf/README.md#_top) | |
| [Elements()](Elements/README.md#_top) | |
| [ElementsAfterSelf()](../MElement/ElementsAfterSelf/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [ElementsBeforeSelf()](../MElement/ElementsBeforeSelf/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Remove()](../MElement/Remove/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [RemoveAll()](RemoveAll/README.md#_top) | |
| [Save(MarkdownWriter)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_DotMarkdown_MarkdownWriter_) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [Save(Stream, MarkdownFormat)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_Stream_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [Save(String, MarkdownFormat)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_System_String_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [Save(TextWriter, MarkdownFormat)](../MElement/Save/README.md#DotMarkdown_Linq_MElement_Save_System_IO_TextWriter_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [ToString()](../MElement/ToString/README.md#DotMarkdown_Linq_MElement_ToString) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [ToString(MarkdownFormat)](../MElement/ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownFormat_) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [ToString(MarkdownWriterSettings)](../MElement/ToString/README.md#DotMarkdown_Linq_MElement_ToString_DotMarkdown_MarkdownWriterSettings_) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |
| [WriteTo(MarkdownWriter)](../MElement/WriteTo/README.md#_top) |  \(Inherited from [MElement](../MElement/README.md#_top)\) |

## Derived \(All\)

* DotMarkdown\.Linq\.[MBlockContainer](../MBlockContainer/README.md#_top)
* DotMarkdown\.Linq\.[MHeading](../MHeading/README.md#_top)
* DotMarkdown\.Linq\.[MInline](../MInline/README.md#_top)
* DotMarkdown\.Linq\.[MLink](../MLink/README.md#_top)
* DotMarkdown\.Linq\.[MList](../MList/README.md#_top)
* &mdash;&mdash;&mdash;&mdash;&mdash;
* DotMarkdown\.Linq\.[MTable](../MTable/README.md#_top)
* DotMarkdown\.Linq\.[MTableColumn](../MTableColumn/README.md#_top)
* DotMarkdown\.Linq\.[MTableRow](../MTableRow/README.md#_top)

