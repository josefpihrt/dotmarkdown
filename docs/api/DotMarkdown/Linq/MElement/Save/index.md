---
sidebar_label: Save
---

# MElement\.Save Method

**Containing Type**: [MElement](../index.md)

**Assembly**: DotMarkdown\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [Save(MarkdownWriter)](#1605807764) | |
| [Save(Stream, MarkdownFormat)](#377468245) | |
| [Save(String, MarkdownFormat)](#3914377559) | |
| [Save(TextWriter, MarkdownFormat)](#3157011060) | |

<a id="1605807764"></a>

## Save\(MarkdownWriter\) 

```csharp
public void Save(DotMarkdown.MarkdownWriter writer)
```

### Parameters

**writer** &ensp; [MarkdownWriter](../../../MarkdownWriter/index.md)<a id="377468245"></a>

## Save\(Stream, MarkdownFormat\) 

```csharp
public void Save(System.IO.Stream stream, DotMarkdown.MarkdownFormat format = null)
```

### Parameters

**stream** &ensp; [Stream](https://docs.microsoft.com/en-us/dotnet/api/system.io.stream)

**format** &ensp; [MarkdownFormat](../../../MarkdownFormat/index.md)<a id="3914377559"></a>

## Save\(String, MarkdownFormat\) 

```csharp
public void Save(string fileName, DotMarkdown.MarkdownFormat format = null)
```

### Parameters

**fileName** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)

**format** &ensp; [MarkdownFormat](../../../MarkdownFormat/index.md)<a id="3157011060"></a>

## Save\(TextWriter, MarkdownFormat\) 

```csharp
public void Save(System.IO.TextWriter writer, DotMarkdown.MarkdownFormat format = null)
```

### Parameters

**writer** &ensp; [TextWriter](https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter)

**format** &ensp; [MarkdownFormat](../../../MarkdownFormat/index.md)