# HeadingOptions Enum

[Home](../../README.md) &#x2022; [Fields](#fields)

**Namespace**: [DotMarkdown](../README.md)

**Assembly**: DotMarkdown\.dll

```csharp
[Flags]
public enum HeadingOptions
```

### Inheritance

[Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) &#x2192; [ValueType](https://docs.microsoft.com/en-us/dotnet/api/system.valuetype) &#x2192; [Enum](https://docs.microsoft.com/en-us/dotnet/api/system.enum) &#x2192; HeadingOptions

### Attributes

* [FlagsAttribute](https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute)

## Fields

| Name | Value | Combination of | Summary |
| ---- | ----- | -------------- | ------- |
| None | 0 | |
| UnderlineHeading1 | 1 | |
| UnderlineHeading2 | 2 | |
| Underline | 3 | UnderlineHeading1 \| UnderlineHeading2 |
| Close | 4 | |
| EmptyLineBefore | 8 | |
| EmptyLineAfter | 16 | |
| EmptyLineBeforeAndAfter | 24 | EmptyLineBefore \| EmptyLineAfter |

