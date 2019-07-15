# MarkdownWriter Class

[Home](../../README.md) &#x2022; [Constructors](#constructors) &#x2022; [Properties](#properties) &#x2022; [Methods](#methods)

**Namespace**: [DotMarkdown](../README.md)

**Assembly**: DotMarkdown\.dll

```csharp
public abstract class MarkdownWriter : IDisposable
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; MarkdownWriter

### Implements

* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable)

## Constructors

| Constructor | Summary |
| ----------- | ------- |
| [MarkdownWriter(MarkdownWriterSettings)](-ctor/README.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Format](Format/README.md) | |
| [Settings](Settings/README.md) | |
| [WriteState](WriteState/README.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Close()](Close/README.md) | |
| [Create(Stream, Encoding, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_System_Text_Encoding_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(Stream, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, IFormatProvider, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_System_IFormatProvider_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(TextWriter, MarkdownWriterSettings)](Create/README.md#DotMarkdown_MarkdownWriter_Create_System_IO_TextWriter_DotMarkdown_MarkdownWriterSettings_) | |
| [Dispose()](Dispose/README.md#DotMarkdown_MarkdownWriter_Dispose) |  \(Implements [IDisposable.Dispose](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose)\) |
| [Dispose(Boolean)](Dispose/README.md#DotMarkdown_MarkdownWriter_Dispose_System_Boolean_) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Flush()](Flush/README.md) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [WriteAutolink(String)](WriteAutolink/README.md) | |
| [WriteBlockQuote(String)](WriteBlockQuote/README.md) | |
| [WriteBold(String)](WriteBold/README.md) | |
| [WriteBulletItem(String)](WriteBulletItem/README.md) | |
| [WriteComment(String)](WriteComment/README.md) | |
| [WriteCompletedTaskItem(String)](WriteCompletedTaskItem/README.md) | |
| [WriteEndBlockQuote()](WriteEndBlockQuote/README.md) | |
| [WriteEndBold()](WriteEndBold/README.md) | |
| [WriteEndBulletItem()](WriteEndBulletItem/README.md) | |
| [WriteEndHeading()](WriteEndHeading/README.md) | |
| [WriteEndItalic()](WriteEndItalic/README.md) | |
| [WriteEndLink(String, String)](WriteEndLink/README.md) | |
| [WriteEndOrderedItem()](WriteEndOrderedItem/README.md) | |
| [WriteEndStrikethrough()](WriteEndStrikethrough/README.md) | |
| [WriteEndTable()](WriteEndTable/README.md) | |
| [WriteEndTableCell()](WriteEndTableCell/README.md) | |
| [WriteEndTableRow()](WriteEndTableRow/README.md) | |
| [WriteEndTaskItem()](WriteEndTaskItem/README.md) | |
| [WriteEntityRef(String)](WriteEntityRef/README.md) | |
| [WriteFencedCodeBlock(String, String)](WriteFencedCodeBlock/README.md) | |
| [WriteHeading(Int32, String)](WriteHeading/README.md) | |
| [WriteHeading1(String)](WriteHeading1/README.md) | |
| [WriteHeading2(String)](WriteHeading2/README.md) | |
| [WriteHeading3(String)](WriteHeading3/README.md) | |
| [WriteHeading4(String)](WriteHeading4/README.md) | |
| [WriteHeading5(String)](WriteHeading5/README.md) | |
| [WriteHeading6(String)](WriteHeading6/README.md) | |
| [WriteHorizontalRule()](WriteHorizontalRule/README.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule) | |
| [WriteHorizontalRule(HorizontalRuleFormat)](WriteHorizontalRule/README.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleFormat__) | |
| [WriteHorizontalRule(HorizontalRuleStyle, Int32, String)](WriteHorizontalRule/README.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleStyle_System_Int32_System_String_) | |
| [WriteCharEntity(Char)](WriteCharEntity/README.md) | |
| [WriteImage(String, String, String)](WriteImage/README.md) | |
| [WriteImageReference(String, String)](WriteImageReference/README.md) | |
| [WriteIndentedCodeBlock(String)](WriteIndentedCodeBlock/README.md) | |
| [WriteInlineCode(String)](WriteInlineCode/README.md) | |
| [WriteItalic(String)](WriteItalic/README.md) | |
| [WriteLabel(String, String, String)](WriteLabel/README.md) | |
| [WriteLine()](WriteLine/README.md) | |
| [WriteLink(String, String, String)](WriteLink/README.md) | |
| [WriteLinkOrText(String, String, String)](WriteLinkOrText/README.md) | |
| [WriteLinkReference(String, String)](WriteLinkReference/README.md) | |
| [WriteOrderedItem(Int32, String)](WriteOrderedItem/README.md) | |
| [WriteRaw(String)](WriteRaw/README.md) | |
| [WriteStartBlockQuote()](WriteStartBlockQuote/README.md) | |
| [WriteStartBold()](WriteStartBold/README.md) | |
| [WriteStartBulletItem()](WriteStartBulletItem/README.md) | |
| [WriteStartCompletedTaskItem()](WriteStartCompletedTaskItem/README.md) | |
| [WriteStartHeading(Int32)](WriteStartHeading/README.md) | |
| [WriteStartItalic()](WriteStartItalic/README.md) | |
| [WriteStartLink()](WriteStartLink/README.md) | |
| [WriteStartOrderedItem(Int32)](WriteStartOrderedItem/README.md) | |
| [WriteStartStrikethrough()](WriteStartStrikethrough/README.md) | |
| [WriteStartTable(Int32)](WriteStartTable/README.md#DotMarkdown_MarkdownWriter_WriteStartTable_System_Int32_) | |
| [WriteStartTable(IReadOnlyList\<TableColumnInfo>)](WriteStartTable/README.md#DotMarkdown_MarkdownWriter_WriteStartTable_System_Collections_Generic_IReadOnlyList_DotMarkdown_TableColumnInfo__) | |
| [WriteStartTableCell()](WriteStartTableCell/README.md) | |
| [WriteStartTableRow()](WriteStartTableRow/README.md) | |
| [WriteStartTaskItem(Boolean)](WriteStartTaskItem/README.md) | |
| [WriteStrikethrough(String)](WriteStrikethrough/README.md) | |
| [WriteString(String)](WriteString/README.md) | |
| [WriteTableCell(String)](WriteTableCell/README.md) | |
| [WriteTableHeaderSeparator()](WriteTableHeaderSeparator/README.md) | |
| [WriteTaskItem(String, Boolean)](WriteTaskItem/README.md) | |
| [WriteValue(Boolean)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Boolean_) | |
| [WriteValue(Decimal)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Decimal_) | |
| [WriteValue(Double)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Double_) | |
| [WriteValue(Int32)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Int32_) | |
| [WriteValue(Int64)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Int64_) | |
| [WriteValue(Single)](WriteValue/README.md#DotMarkdown_MarkdownWriter_WriteValue_System_Single_) | |

