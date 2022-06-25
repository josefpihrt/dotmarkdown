---
sidebar_label: TableOptions
---

# TableOptions Enum

**Namespace**: [DotMarkdown](../index.md)

**Assembly**: DotMarkdown\.dll

```csharp
[Flags]
public enum TableOptions
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; TableOptions

### Attributes

* [FlagsAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute)

## Fields

| Name | Value | Combination of | Summary |
| ---- | ----- | -------------- | ------- |
| None | 0 | |
| FormatHeader | 1 | |
| FormatContent | 2 | |
| FormatHeaderAndContent | 3 | FormatHeader \| FormatContent |
| Padding | 4 | |
| OuterDelimiter | 8 | |
| EmptyLineBefore | 16 | |
| EmptyLineAfter | 32 | |
| EmptyLineBeforeAndAfter | 48 | EmptyLineBefore \| EmptyLineAfter |

