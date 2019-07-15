# MarkdownWriter\.Create Method

[Home](../../../README.md)

**Containing Type**: [MarkdownWriter](../README.md)

**Assembly**: DotMarkdown\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Create(Stream, Encoding, MarkdownWriterSettings)](#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_System_Text_Encoding_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(Stream, MarkdownWriterSettings)](#DotMarkdown_MarkdownWriter_Create_System_IO_Stream_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, IFormatProvider, MarkdownWriterSettings)](#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_System_IFormatProvider_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(StringBuilder, MarkdownWriterSettings)](#DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_DotMarkdown_MarkdownWriterSettings_) | |
| [Create(TextWriter, MarkdownWriterSettings)](#DotMarkdown_MarkdownWriter_Create_System_IO_TextWriter_DotMarkdown_MarkdownWriterSettings_) | |

## Create\(Stream, Encoding, MarkdownWriterSettings\) <a id="DotMarkdown_MarkdownWriter_Create_System_IO_Stream_System_Text_Encoding_DotMarkdown_MarkdownWriterSettings_"></a>

```csharp
public static DotMarkdown.MarkdownWriter Create(System.IO.Stream stream, System.Text.Encoding encoding, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

**encoding** &ensp; [Encoding](https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/README.md)

### Returns

[MarkdownWriter](../README.md)

## Create\(Stream, MarkdownWriterSettings\) <a id="DotMarkdown_MarkdownWriter_Create_System_IO_Stream_DotMarkdown_MarkdownWriterSettings_"></a>

```csharp
public static DotMarkdown.MarkdownWriter Create(System.IO.Stream stream, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/README.md)

### Returns

[MarkdownWriter](../README.md)

## Create\(StringBuilder, IFormatProvider, MarkdownWriterSettings\) <a id="DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_System_IFormatProvider_DotMarkdown_MarkdownWriterSettings_"></a>

```csharp
public static DotMarkdown.MarkdownWriter Create(System.Text.StringBuilder output, IFormatProvider formatProvider, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**output** &ensp; [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)

**formatProvider** &ensp; [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/README.md)

### Returns

[MarkdownWriter](../README.md)

## Create\(StringBuilder, MarkdownWriterSettings\) <a id="DotMarkdown_MarkdownWriter_Create_System_Text_StringBuilder_DotMarkdown_MarkdownWriterSettings_"></a>

```csharp
public static DotMarkdown.MarkdownWriter Create(System.Text.StringBuilder output, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**output** &ensp; [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/README.md)

### Returns

[MarkdownWriter](../README.md)

## Create\(TextWriter, MarkdownWriterSettings\) <a id="DotMarkdown_MarkdownWriter_Create_System_IO_TextWriter_DotMarkdown_MarkdownWriterSettings_"></a>

```csharp
public static DotMarkdown.MarkdownWriter Create(System.IO.TextWriter output, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**output** &ensp; [TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/README.md)

### Returns

[MarkdownWriter](../README.md)

