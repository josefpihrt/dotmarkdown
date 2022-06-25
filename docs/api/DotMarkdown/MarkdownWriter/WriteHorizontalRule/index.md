---
sidebar_label: WriteHorizontalRule
---

# MarkdownWriter\.WriteHorizontalRule Method

**Containing Type**: [MarkdownWriter](../index.md)

**Assembly**: DotMarkdown\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [WriteHorizontalRule()](#DotMarkdown_MarkdownWriter_WriteHorizontalRule) | |
| [WriteHorizontalRule(HorizontalRuleFormat)](#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleFormat__) | |
| [WriteHorizontalRule(HorizontalRuleStyle, Int32, String)](#DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleStyle_System_Int32_System_String_) | |

## WriteHorizontalRule\(\) <a id="DotMarkdown_MarkdownWriter_WriteHorizontalRule"></a>

```csharp
public void WriteHorizontalRule()
```

## WriteHorizontalRule\(HorizontalRuleFormat\) <a id="DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleFormat__"></a>

```csharp
public void WriteHorizontalRule(in DotMarkdown.HorizontalRuleFormat format)
```

### Parameters

**format** &ensp; [HorizontalRuleFormat](../../HorizontalRuleFormat/index.md)

## WriteHorizontalRule\(HorizontalRuleStyle, Int32, String\) <a id="DotMarkdown_MarkdownWriter_WriteHorizontalRule_DotMarkdown_HorizontalRuleStyle_System_Int32_System_String_"></a>

```csharp
public abstract void WriteHorizontalRule(DotMarkdown.HorizontalRuleStyle style, int count = 3, string separator = " ")
```

### Parameters

**style** &ensp; [HorizontalRuleStyle](../../HorizontalRuleStyle/index.md)

**count** &ensp; [Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32)

**separator** &ensp; [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)