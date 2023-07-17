---
sidebar_label: TaskItem
---

# MFactory\.TaskItem Method

**Containing Type**: [MFactory](../index.md)

**Assembly**: DotMarkdown\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [TaskItem(Boolean, Object)](#1042399140) | |
| [TaskItem(Boolean, Object\[\])](#1518315464) | |
| [TaskItem(Boolean)](#1892159258) | |
| [TaskItem(MTaskItem)](#2860550771) | |

<a id="1042399140"></a>

## TaskItem\(Boolean, Object\) 

```csharp
public static DotMarkdown.Linq.MTaskItem TaskItem(bool isCompleted, object content)
```

### Parameters

**isCompleted** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)

### Returns

[MTaskItem](../../MTaskItem/index.md)

<a id="1518315464"></a>

## TaskItem\(Boolean, Object\[\]\) 

```csharp
public static DotMarkdown.Linq.MTaskItem TaskItem(bool isCompleted, params object[] content)
```

### Parameters

**isCompleted** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

**content** &ensp; [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object)\[\]

### Returns

[MTaskItem](../../MTaskItem/index.md)

<a id="1892159258"></a>

## TaskItem\(Boolean\) 

```csharp
public static DotMarkdown.Linq.MTaskItem TaskItem(bool isCompleted)
```

### Parameters

**isCompleted** &ensp; [Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean)

### Returns

[MTaskItem](../../MTaskItem/index.md)

<a id="2860550771"></a>

## TaskItem\(MTaskItem\) 

```csharp
public static DotMarkdown.Linq.MTaskItem TaskItem(DotMarkdown.Linq.MTaskItem other)
```

### Parameters

**other** &ensp; [MTaskItem](../../MTaskItem/index.md)

### Returns

[MTaskItem](../../MTaskItem/index.md)

