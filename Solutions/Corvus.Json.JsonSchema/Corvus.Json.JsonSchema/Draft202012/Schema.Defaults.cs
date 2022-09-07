//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Schema
{
    private static readonly ImmutableDictionary<JsonPropertyName, JsonAny> __CorvusDefaults = BuildDefaults();
    /// <inheritdoc/>
    public bool TryGetDefault(in JsonPropertyName name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(name, out value);
    }

    /// <inheritdoc/>
    public bool TryGetDefault(string name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(name, out value);
    }

    /// <inheritdoc/>
    public bool TryGetDefault(ReadOnlySpan<char> name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(name, out value);
    }

    /// <inheritdoc/>
    public bool TryGetDefault(ReadOnlySpan<byte> utf8Name, out JsonAny value)
    {
        return __CorvusDefaults.TryGetValue(utf8Name, out value);
    }

    /// <inheritdoc/>
    public bool HasDefault(in JsonPropertyName name)
    {
        return __CorvusDefaults.TryGetValue(name, out _);
    }

    /// <inheritdoc/>
    public bool HasDefault(string name)
    {
        return __CorvusDefaults.TryGetValue(name, out _);
    }

    /// <inheritdoc/>
    public bool HasDefault(ReadOnlySpan<char> name)
    {
        return __CorvusDefaults.TryGetValue(name, out _);
    }

    /// <inheritdoc/>
    public bool HasDefault(ReadOnlySpan<byte> utf8Name)
    {
        return __CorvusDefaults.TryGetValue(utf8Name, out _);
    }

    private static ImmutableDictionary<JsonPropertyName, JsonAny> BuildDefaults()
    {
        ImmutableDictionary<JsonPropertyName, JsonAny>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        builder.Add(PropertiesJsonPropertyName, JsonAny.Parse("{}"));
        builder.Add(PatternPropertiesJsonPropertyName, JsonAny.Parse("{}"));
        builder.Add(DependentSchemasJsonPropertyName, JsonAny.Parse("{}"));
        builder.Add(DeprecatedJsonPropertyName, JsonAny.Parse("false"));
        builder.Add(ReadOnlyJsonPropertyName, JsonAny.Parse("false"));
        builder.Add(WriteOnlyJsonPropertyName, JsonAny.Parse("false"));
        builder.Add(MinLengthJsonPropertyName, JsonAny.Parse("0"));
        builder.Add(MinItemsJsonPropertyName, JsonAny.Parse("0"));
        builder.Add(UniqueItemsJsonPropertyName, JsonAny.Parse("false"));
        builder.Add(MinContainsJsonPropertyName, JsonAny.Parse("1"));
        builder.Add(MinPropertiesJsonPropertyName, JsonAny.Parse("0"));
        builder.Add(RequiredJsonPropertyName, JsonAny.Parse("[]"));
        builder.Add(DefinitionsJsonPropertyName, JsonAny.Parse("{}"));
        builder.Add(DependenciesJsonPropertyName, JsonAny.Parse("{}"));
        return builder.ToImmutable();
    }
}