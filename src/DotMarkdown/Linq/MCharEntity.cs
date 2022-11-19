// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using System.Globalization;

namespace DotMarkdown.Linq;

[DebuggerDisplay("{Kind} {ValueAsInt} {Value}")]
public class MCharEntity : MElement
{
    private char _value;

    public MCharEntity(char value)
    {
        Value = value;
    }

    public MCharEntity(MCharEntity other)
    {
        if (other is null)
            throw new ArgumentNullException(nameof(other));

        _value = other.Value;
    }

    public char Value
    {
        get { return _value; }
        set
        {
            Error.ThrowOnInvalidCharEntity(value);

            _value = value;
        }
    }

    internal int ValueAsInt => Value;

    public override MarkdownKind Kind => MarkdownKind.CharEntity;

    public override void WriteTo(MarkdownWriter writer)
    {
        writer.WriteCharEntity(Value);
    }

    internal override MElement Clone()
    {
        return new MCharEntity(this);
    }

    internal string NumberAsString(CharEntityFormat format)
    {
        switch (format)
        {
            case CharEntityFormat.Hexadecimal:
                return ((int)Value).ToString("X", CultureInfo.InvariantCulture);
            case CharEntityFormat.Decimal:
                return ((int)Value).ToString(CultureInfo.InvariantCulture);
            default:
                throw new ArgumentException(ErrorMessages.UnknownEnumValue(format), nameof(format));
        }
    }
}
