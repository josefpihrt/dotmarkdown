---
sidebar_label: WriteHorizontalRule
---

# MarkdownWriter\.WriteHorizontalRule Method

**Containing Type**: [MarkdownWriter](../index.md)

**Assembly**: DotMarkdown\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WriteHorizontalRule()](#3448336783) | |
| [WriteHorizontalRule(HorizontalRuleFormat)](#3263388817) | |
| [WriteHorizontalRule(HorizontalRuleStyle, Int32, String)](#660685721) | |

<a id="3448336783"></a>

## WriteHorizontalRule\(\) 

```csharp
public void WriteHorizontalRule()
```

<a id="3263388817"></a>

## WriteHorizontalRule\(HorizontalRuleFormat\) 

```csharp
public void WriteHorizontalRule(in DotMarkdown.HorizontalRuleFormat format)
```

### Parameters

**format** &ensp; [HorizontalRuleFormat](../../HorizontalRuleFormat/index.md)<a id="660685721"></a>

## WriteHorizontalRule\(HorizontalRuleStyle, Int32, String\) 

```csharp
public abstract void WriteHorizontalRule(DotMarkdown.HorizontalRuleStyle style, int count = 3, string separator = " ")
```

### Parameters

**style** &ensp; [HorizontalRuleStyle](../../HorizontalRuleStyle/index.md)

**count** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**separator** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)