---
sidebar_label: Create
---

# MarkdownWriter\.Create Method

**Containing Type**: [MarkdownWriter](../index.md)

**Assembly**: DotMarkdown\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Create(Stream, Encoding, MarkdownWriterSettings)](#1803453469) | |
| [Create(Stream, MarkdownWriterSettings)](#2595698549) | |
| [Create(String, MarkdownWriterSettings)](#3360061740) | |
| [Create(StringBuilder, IFormatProvider, MarkdownWriterSettings)](#3111769310) | |
| [Create(StringBuilder, MarkdownWriterSettings)](#1010978077) | |
| [Create(TextWriter, MarkdownWriterSettings)](#2942469733) | |

<a id="1803453469"></a>

## Create\(Stream, Encoding, MarkdownWriterSettings\) 

```csharp
public static DotMarkdown.MarkdownWriter Create(System.IO.Stream stream, System.Text.Encoding encoding, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

**encoding** &ensp; [Encoding](https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/index.md)

### Returns

[MarkdownWriter](../index.md)

<a id="2595698549"></a>

## Create\(Stream, MarkdownWriterSettings\) 

```csharp
public static DotMarkdown.MarkdownWriter Create(System.IO.Stream stream, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/index.md)

### Returns

[MarkdownWriter](../index.md)

<a id="3360061740"></a>

## Create\(String, MarkdownWriterSettings\) 

```csharp
public static DotMarkdown.MarkdownWriter Create(string fileName, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**fileName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/index.md)

### Returns

[MarkdownWriter](../index.md)

<a id="3111769310"></a>

## Create\(StringBuilder, IFormatProvider, MarkdownWriterSettings\) 

```csharp
public static DotMarkdown.MarkdownWriter Create(System.Text.StringBuilder output, IFormatProvider formatProvider, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**output** &ensp; [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)

**formatProvider** &ensp; [IFormatProvider](https://docs.microsoft.com/en-us/dotnet/api/system.iformatprovider)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/index.md)

### Returns

[MarkdownWriter](../index.md)

<a id="1010978077"></a>

## Create\(StringBuilder, MarkdownWriterSettings\) 

```csharp
public static DotMarkdown.MarkdownWriter Create(System.Text.StringBuilder output, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**output** &ensp; [StringBuilder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/index.md)

### Returns

[MarkdownWriter](../index.md)

<a id="2942469733"></a>

## Create\(TextWriter, MarkdownWriterSettings\) 

```csharp
public static DotMarkdown.MarkdownWriter Create(System.IO.TextWriter output, DotMarkdown.MarkdownWriterSettings settings = null)
```

### Parameters

**output** &ensp; [TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)

**settings** &ensp; [MarkdownWriterSettings](../../MarkdownWriterSettings/index.md)

### Returns

[MarkdownWriter](../index.md)

