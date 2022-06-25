---
sidebar_label: MarkdownWriter
---

# MarkdownWriter Class

**Namespace**: [DotMarkdown](../index.md)

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
| [MarkdownWriter(MarkdownWriterSettings)](-ctor/index.md) | |

## Properties

| Property | Summary |
| -------- | ------- |
| [Format](Format/index.md) | |
| [Settings](Settings/index.md) | |
| [WriteState](WriteState/index.md) | |

## Methods

| Method | Summary |
| ------ | ------- |
| [Close()](Close/index.md) | |
| [Create(Stream, Encoding, MarkdownWriterSettings)](Create/index.md#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_System_Text_Encoding_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(Stream, MarkdownWriterSettings)](Create/index.md#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(String, MarkdownWriterSettings)](Create/index.md#DotMarkdown_MarkdownWriter_Create_System_String_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, IFormatProvider, MarkdownWriterSettings)](Create/index.md#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_System_IFormatProvider_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, MarkdownWriterSettings)](Create/index.md#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(TextWriter, MarkdownWriterSettings)](Create/index.md#DotMarkdown_MarkdownWriter_Create_System_IO_TextWriter_DotMarkdown_MarkdownWriterSettings_) | |
| [Dispose()](Dispose/index.md#DotMarkdown_MarkdownWriter_Dispose) |  \(Implements [IDisposable.Dispose](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose)\) |
| [Dispose(Boolean)](Dispose/index.md#DotMarkdown_MarkdownWriter_Dispose_System_Boolean_) | |
| [Equals(Object)](https://docs.microsoft.com/en-us/dotnet/api/system.object.equals) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [Flush()](Flush/index.md) | |
| [GetHashCode()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gethashcode) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [GetType()](https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [MemberwiseClone()](https://docs.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [ToString()](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring) |  \(Inherited from [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\) |
| [WriteAutolink(String)](WriteAutolink/index.md) | |
| [WriteBlockQuote(String)](WriteBlockQuote/index.md) | |
| [WriteBold(String)](WriteBold/index.md) | |
| [WriteBulletItem(String)](WriteBulletItem/index.md) | |
| [WriteComment(String)](WriteComment/index.md) | |
| [WriteCompletedTaskItem(String)](WriteCompletedTaskItem/index.md) | |
| [WriteEndBlockQuote()](WriteEndBlockQuote/index.md) | |
| [WriteEndBold()](WriteEndBold/index.md) | |
| [WriteEndBulletItem()](WriteEndBulletItem/index.md) | |
| [WriteEndHeading()](WriteEndHeading/index.md) | |
| [WriteEndItalic()](WriteEndItalic/index.md) | |
| [WriteEndLink(String, String)](WriteEndLink/index.md) | |
| [WriteEndOrderedItem()](WriteEndOrderedItem/index.md) | |
| [WriteEndStrikethrough()](WriteEndStrikethrough/index.md) | |
| [WriteEndTable()](WriteEndTable/index.md) | |
| [WriteEndTableCell()](WriteEndTableCell/index.md) | |
| [WriteEndTableRow()](WriteEndTableRow/index.md) | |
| [WriteEndTaskItem()](WriteEndTaskItem/index.md) | |
| [WriteEntityRef(String)](WriteEntityRef/index.md) | |
| [WriteFencedCodeBlock(String, String)](WriteFencedCodeBlock/index.md) | |
| [WriteHeading(Int32, String)](WriteHeading/index.md) | |
| [WriteHeading1(String)](WriteHeading1/index.md) | |
| [WriteHeading2(String)](WriteHeading2/index.md) | |
| [WriteHeading3(String)](WriteHeading3/index.md) | |
| [WriteHeading4(String)](WriteHeading4/index.md) | |
| [WriteHeading5(String)](WriteHeading5/index.md) | |
| [WriteHeading6(String)](WriteHeading6/index.md) | |
| [WriteHorizontalRule()](WriteHorizontalRule/index.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule) | |
| [WriteHorizontalRule(HorizontalRuleFormat)](WriteHorizontalRule/index.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleFormat__) | |
| [WriteHorizontalRule(HorizontalRuleStyle, Int32, String)](WriteHorizontalRule/index.md#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleStyle_System_Int32_System_String_) | |
| [WriteCharEntity(Char)](WriteCharEntity/index.md) | |
| [WriteImage(String, String, String)](WriteImage/index.md) | |
| [WriteImageReference(String, String)](WriteImageReference/index.md) | |
| [WriteIndentedCodeBlock(String)](WriteIndentedCodeBlock/index.md) | |
| [WriteInlineCode(String)](WriteInlineCode/index.md) | |
| [WriteItalic(String)](WriteItalic/index.md) | |
| [WriteLabel(String, String, String)](WriteLabel/index.md) | |
| [WriteLine()](WriteLine/index.md) | |
| [WriteLink(String, String, String)](WriteLink/index.md) | |
| [WriteLinkOrText(String, String, String)](WriteLinkOrText/index.md) | |
| [WriteLinkReference(String, String)](WriteLinkReference/index.md) | |
| [WriteOrderedItem(Int32, String)](WriteOrderedItem/index.md) | |
| [WriteRaw(String)](WriteRaw/index.md) | |
| [WriteStartBlockQuote()](WriteStartBlockQuote/index.md) | |
| [WriteStartBold()](WriteStartBold/index.md) | |
| [WriteStartBulletItem()](WriteStartBulletItem/index.md) | |
| [WriteStartCompletedTaskItem()](WriteStartCompletedTaskItem/index.md) | |
| [WriteStartHeading(Int32)](WriteStartHeading/index.md) | |
| [WriteStartItalic()](WriteStartItalic/index.md) | |
| [WriteStartLink()](WriteStartLink/index.md) | |
| [WriteStartOrderedItem(Int32)](WriteStartOrderedItem/index.md) | |
| [WriteStartStrikethrough()](WriteStartStrikethrough/index.md) | |
| [WriteStartTable(Int32)](WriteStartTable/index.md#DotMarkdown_MarkdownWriter_WriteStartTable_System_Int32_) | |
| [WriteStartTable(IReadOnlyList&lt;TableColumnInfo&gt;)](WriteStartTable/index.md#DotMarkdown_MarkdownWriter_WriteStartTable_System_Collections_Generic_IReadOnlyList_DotMarkdown_TableColumnInfo__) | |
| [WriteStartTableCell()](WriteStartTableCell/index.md) | |
| [WriteStartTableRow()](WriteStartTableRow/index.md) | |
| [WriteStartTaskItem(Boolean)](WriteStartTaskItem/index.md) | |
| [WriteStrikethrough(String)](WriteStrikethrough/index.md) | |
| [WriteString(String)](WriteString/index.md) | |
| [WriteTableCell(String)](WriteTableCell/index.md) | |
| [WriteTableHeaderSeparator()](WriteTableHeaderSeparator/index.md) | |
| [WriteTaskItem(String, Boolean)](WriteTaskItem/index.md) | |
| [WriteValue(Boolean)](WriteValue/index.md#DotMarkdown_MarkdownWriter_WriteValue_System_Boolean_) | |
| [WriteValue(Decimal)](WriteValue/index.md#DotMarkdown_MarkdownWriter_WriteValue_System_Decimal_) | |
| [WriteValue(Double)](WriteValue/index.md#DotMarkdown_MarkdownWriter_WriteValue_System_Double_) | |
| [WriteValue(Int32)](WriteValue/index.md#DotMarkdown_MarkdownWriter_WriteValue_System_Int32_) | |
| [WriteValue(Int64)](WriteValue/index.md#DotMarkdown_MarkdownWriter_WriteValue_System_Int64_) | |
| [WriteValue(Single)](WriteValue/index.md#DotMarkdown_MarkdownWriter_WriteValue_System_Single_) | |

