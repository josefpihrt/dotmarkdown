<a name="_top"></a>

# MarkdownWriter Class

[Home](../../README.md#_top) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [DotMarkdown](../README.md#_top)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MarkdownWriter : System.IDisposable
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; MarkdownWriter

### Implements

* System\.[IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MarkdownWriter(MarkdownWriterSettings)](-ctor/README.md#_top) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Format](Format/README.md#_top) | |
| [Settings](Settings/README.md#_top) | |
| [WriteState](WriteState/README.md#_top) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Close()](Close/README.md#_top) | |
| [Create(Stream, Encoding, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_System_Text_Encoding_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(Stream, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, IFormatProvider, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_System_IFormatProvider_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(TextWriter, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_IO_TextWriter_DotMarkdown_MarkdownWriterSettings_) | |
| [Dispose()](Dispose/README.md#DotMarkdown_MarkdownWriter_Dispose) |  \(Implements [IDisposable.Dispose](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose)\) |
| [Dispose(Boolean)](Dispose/README.md#DotMarkdown_MarkdownWriter_Dispose_System_Boolean_) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Flush()](Flush/README.md#_top) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [WriteAutolink(String)](WriteAutolink/README.md#_top) | |
| [WriteBlockQuote(String)](WriteBlockQuote/README.md#_top) | |
| [WriteBold(String)](WriteBold/README.md#_top) | |
| [WriteBulletItem(String)](WriteBulletItem/README.md#_top) | |
| [WriteComment(String)](WriteComment/README.md#_top) | |
| [WriteCompletedTaskItem(String)](WriteCompletedTaskItem/README.md#_top) | |
| [WriteEndBlockQuote()](WriteEndBlockQuote/README.md#_top) | |
| [WriteEndBold()](WriteEndBold/README.md#_top) | |
| [WriteEndBulletItem()](WriteEndBulletItem/README.md#_top) | |
| [WriteEndHeading()](WriteEndHeading/README.md#_top) | |
| [WriteEndItalic()](WriteEndItalic/README.md#_top) | |
| [WriteEndLink(String, String)](WriteEndLink/README.md#_top) | |
| [WriteEndOrderedItem()](WriteEndOrderedItem/README.md#_top) | |
| [WriteEndStrikethrough()](WriteEndStrikethrough/README.md#_top) | |
| [WriteEndTable()](WriteEndTable/README.md#_top) | |
| [WriteEndTableCell()](WriteEndTableCell/README.md#_top) | |
| [WriteEndTableRow()](WriteEndTableRow/README.md#_top) | |
| [WriteEndTaskItem()](WriteEndTaskItem/README.md#_top) | |
| [WriteEntityRef(String)](WriteEntityRef/README.md#_top) | |
| [WriteFencedCodeBlock(String, String)](WriteFencedCodeBlock/README.md#_top) | |
| [WriteHeading(Int32, String)](WriteHeading/README.md#_top) | |
| [WriteHeading1(String)](WriteHeading1/README.md#_top) | |
| [WriteHeading2(String)](WriteHeading2/README.md#_top) | |
| [WriteHeading3(String)](WriteHeading3/README.md#_top) | |
| [WriteHeading4(String)](WriteHeading4/README.md#_top) | |
| [WriteHeading5(String)](WriteHeading5/README.md#_top) | |
| [WriteHeading6(String)](WriteHeading6/README.md#_top) | |
| [WriteHorizontalRule()](WriteHorizontalRule/README.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule) | |
| [WriteHorizontalRule(HorizontalRuleFormat)](WriteHorizontalRule/README.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleFormat__) | |
| [WriteHorizontalRule(HorizontalRuleStyle, Int32, String)](WriteHorizontalRule/README.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleStyle_System_Int32_System_String_) | |
| [WriteCharEntity(Char)](WriteCharEntity/README.md#_top) | |
| [WriteImage(String, String, String)](WriteImage/README.md#_top) | |
| [WriteImageReference(String, String)](WriteImageReference/README.md#_top) | |
| [WriteIndentedCodeBlock(String)](WriteIndentedCodeBlock/README.md#_top) | |
| [WriteInlineCode(String)](WriteInlineCode/README.md#_top) | |
| [WriteItalic(String)](WriteItalic/README.md#_top) | |
| [WriteLabel(String, String, String)](WriteLabel/README.md#_top) | |
| [WriteLine()](WriteLine/README.md#_top) | |
| [WriteLink(String, String, String)](WriteLink/README.md#_top) | |
| [WriteLinkOrText(String, String, String)](WriteLinkOrText/README.md#_top) | |
| [WriteLinkReference(String, String)](WriteLinkReference/README.md#_top) | |
| [WriteOrderedItem(Int32, String)](WriteOrderedItem/README.md#_top) | |
| [WriteRaw(String)](WriteRaw/README.md#_top) | |
| [WriteStartBlockQuote()](WriteStartBlockQuote/README.md#_top) | |
| [WriteStartBold()](WriteStartBold/README.md#_top) | |
| [WriteStartBulletItem()](WriteStartBulletItem/README.md#_top) | |
| [WriteStartCompletedTaskItem()](WriteStartCompletedTaskItem/README.md#_top) | |
| [WriteStartHeading(Int32)](WriteStartHeading/README.md#_top) | |
| [WriteStartItalic()](WriteStartItalic/README.md#_top) | |
| [WriteStartLink()](WriteStartLink/README.md#_top) | |
| [WriteStartOrderedItem(Int32)](WriteStartOrderedItem/README.md#_top) | |
| [WriteStartStrikethrough()](WriteStartStrikethrough/README.md#_top) | |
| [WriteStartTable(Int32)](WriteStartTable/README.md#DotMarkdown_MarkdownWriter_WriteStartTable_System_Int32_) | |
| [WriteStartTable(IReadOnlyList\<TableColumnInfo>)](WriteStartTable/README.md#DotMarkdown_MarkdownWriter_WriteStartTable_System_Collections_Generic_IReadOnlyList_DotMarkdown_TableColumnInfo__) | |
| [WriteStartTableCell()](WriteStartTableCell/README.md#_top) | |
| [WriteStartTableRow()](WriteStartTableRow/README.md#_top) | |
| [WriteStartTaskItem(Boolean)](WriteStartTaskItem/README.md#_top) | |
| [WriteStrikethrough(String)](WriteStrikethrough/README.md#_top) | |
| [WriteString(String)](WriteString/README.md#_top) | |
| [WriteTableCell(String)](WriteTableCell/README.md#_top) | |
| [WriteTableHeaderSeparator()](WriteTableHeaderSeparator/README.md#_top) | |
| [WriteTaskItem(String, Boolean)](WriteTaskItem/README.md#_top) | |
| [WriteValue(Boolean)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Boolean_) | |
| [WriteValue(Decimal)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Decimal_) | |
| [WriteValue(Double)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Double_) | |
| [WriteValue(Int32)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Int32_) | |
| [WriteValue(Int64)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Int64_) | |
| [WriteValue(Single)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Single_) | |

