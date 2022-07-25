﻿// <copyright file="JsonObjectProperty.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

using System.Text.Json;

namespace Corvus.Json;

/// <summary>
/// A property on a <see cref="IJsonObject{T}"/>.
/// </summary>
public readonly struct JsonObjectProperty : IEquatable<JsonObjectProperty>
{
    private readonly Backing backing;
    private readonly JsonProperty jsonProperty;
    private readonly JsonPropertyName name;
    private readonly JsonAny value;

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonObjectProperty"/> struct.
    /// </summary>
    /// <param name="jsonProperty">The JSON property over which to construct this instance.</param>
    public JsonObjectProperty(JsonProperty jsonProperty)
    {
        this.backing = Backing.JsonProperty;
        this.jsonProperty = jsonProperty;
        this.name = default;
        this.value = default;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonObjectProperty"/> struct.
    /// </summary>
    /// <param name="name">The property name.</param>
    /// <param name="value">The property value.</param>
    public JsonObjectProperty(JsonPropertyName name, JsonAny value)
    {
        this.backing = Backing.NameValue;
        this.jsonProperty = default;
        this.name = name;
        this.value = value;
    }

    [Flags]
    private enum Backing : byte
    {
        Undefined = 0b00,
        JsonProperty = 0b01,
        NameValue = 0b10,
    }

    /// <summary>
    /// Gets the value kind of the property value.
    /// </summary>
    public JsonValueKind ValueKind
    {
        get
        {
            if ((this.backing & Backing.JsonProperty) != 0)
            {
                return this.jsonProperty.Value.ValueKind;
            }

            if ((this.backing & Backing.NameValue) != 0)
            {
                return this.value.ValueKind;
            }

            return JsonValueKind.Undefined;
        }
    }

    /// <summary>
    /// Gets the value of the property.
    /// </summary>
    public JsonAny Value
    {
        get
        {
            if ((this.backing & Backing.JsonProperty) != 0)
            {
                return new(this.jsonProperty.Value);
            }

            if ((this.backing & Backing.NameValue) != 0)
            {
                return this.value;
            }

            return default;
        }
    }

    /// <summary>
    /// Gets the name of the property as a string.
    /// </summary>
    /// <exception cref="InvalidOperationException">The value does not have a name.</exception>
    public JsonPropertyName Name
    {
        get
        {
            if ((this.backing & Backing.JsonProperty) != 0)
            {
                return this.jsonProperty.Name;
            }

            if ((this.backing & Backing.NameValue) != 0)
            {
                return this.name;
            }

            throw new InvalidOperationException("The property does not have a name.");
        }
    }

    /// <summary>
    /// Standard equality operator.
    /// </summary>
    /// <param name="left">The LHS of the comparison.</param>
    /// <param name="right">The RHS of the comparison.</param>
    /// <returns>True if they are equal.</returns>
    public static bool operator ==(JsonObjectProperty left, JsonObjectProperty right)
    {
        return left.Equals(right);
    }

    /// <summary>
    /// Standard inequality operator.
    /// </summary>
    /// <param name="left">The LHS of the comparison.</param>
    /// <param name="right">The RHS of the comparison.</param>
    /// <returns>True if they are not equal.</returns>
    public static bool operator !=(JsonObjectProperty left, JsonObjectProperty right)
    {
        return !left.Equals(right);
    }

    /// <summary>
    /// Gets the value as an instance of the given type.
    /// </summary>
    /// <typeparam name="T">The type for which to get the value.</typeparam>
    /// <returns>An instance of the value as the given type.</returns>
    public T ValueAs<T>()
        where T : struct, IJsonValue<T>
    {
        if ((this.backing & Backing.JsonProperty) != 0)
        {
            return T.FromJson(this.jsonProperty.Value);
        }

        if ((this.backing & Backing.NameValue) != 0)
        {
            return T.FromAny(this.value);
        }

        return default;
    }

    /// <summary>
    /// Compares the specified UTF-8 encoded text to the name of this property.
    /// </summary>
    /// <param name="utf8Name">The name to match.</param>
    /// <returns><c>True</c> if the name matches.</returns>
    public bool NameEquals(ReadOnlySpan<byte> utf8Name)
    {
        if ((this.backing & Backing.JsonProperty) != 0)
        {
            return this.jsonProperty.NameEquals(utf8Name);
        }

        if ((this.backing & Backing.NameValue) != 0)
        {
            this.name.Equals(utf8Name);
        }

        return false;
    }

    /// <summary>
    /// Compares the specified text to the name of this property.
    /// </summary>
    /// <param name="name">The name to match.</param>
    /// <returns><c>True</c> if the name matches.</returns>
    public bool NameEquals(ReadOnlySpan<char> name)
    {
        if ((this.backing & Backing.JsonProperty) != 0)
        {
            return this.jsonProperty.NameEquals(name);
        }

        if ((this.backing & Backing.NameValue) != 0)
        {
            this.name.Equals(name);
        }

        return false;
    }

    /// <summary>
    /// Compares the specified text to the name of this property.
    /// </summary>
    /// <param name="name">The name to match.</param>
    /// <returns><c>True</c> if the name matches.</returns>
    public bool NameEquals(string name)
    {
        if ((this.backing & Backing.JsonProperty) != 0)
        {
            return this.jsonProperty.NameEquals(name);
        }

        if ((this.backing & Backing.NameValue) != 0)
        {
            this.name.Equals(name);
        }

        return false;
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return obj is JsonObjectProperty property && this.Equals(property);
    }

    /// <inheritdoc/>
    public bool Equals(JsonObjectProperty other)
    {
        return this.Value.Equals(other.Value) &&
               this.Name.Equals(other.Name);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(this.Value, this.Name);
    }
}