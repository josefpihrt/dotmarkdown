﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace DotMarkdown.Linq;

[Obsolete("This API is obsolete.")]
public interface ITableAnalyzer
{
    IReadOnlyList<TableColumnInfo>? AnalyzeTable(IEnumerable<MElement> rows);
}
