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
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft7;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Core
{
    private static readonly ImmutableDictionary<JsonPropertyName, PropertyValidator<Core>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    /// <summary>
    /// JSON property name for <see cref = "Id"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> IdUtf8JsonPropertyName = new byte[] { 36, 105, 100 };
    /// <summary>
    /// JSON property name for <see cref = "Id"/>.
    /// </summary>
    public const string IdJsonPropertyName = "$id";
    /// <summary>
    /// JSON property name for <see cref = "Schema"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> SchemaUtf8JsonPropertyName = new byte[] { 36, 115, 99, 104, 101, 109, 97 };
    /// <summary>
    /// JSON property name for <see cref = "Schema"/>.
    /// </summary>
    public const string SchemaJsonPropertyName = "$schema";
    /// <summary>
    /// JSON property name for <see cref = "Ref"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> RefUtf8JsonPropertyName = new byte[] { 36, 114, 101, 102 };
    /// <summary>
    /// JSON property name for <see cref = "Ref"/>.
    /// </summary>
    public const string RefJsonPropertyName = "$ref";
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public static readonly ReadOnlyMemory<byte> CommentUtf8JsonPropertyName = new byte[] { 36, 99, 111, 109, 109, 101, 110, 116 };
    /// <summary>
    /// JSON property name for <see cref = "Comment"/>.
    /// </summary>
    public const string CommentJsonPropertyName = "$comment";
    /// <summary>
    /// Gets Id.
    /// </summary>
    public Corvus.Json.JsonSchema.Draft7.Core.IdValue Id
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(IdUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonSchema.Draft7.Core.IdValue(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(IdJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonSchema.Draft7.Core.IdValue>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Schema.
    /// </summary>
    public Corvus.Json.JsonUri Schema
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(SchemaUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonUri(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(SchemaJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonUri>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Ref.
    /// </summary>
    public Corvus.Json.JsonUriReference Ref
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(RefUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonUriReference(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(RefJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonUriReference>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Gets Comment.
    /// </summary>
    public Corvus.Json.JsonString Comment
    {
        get
        {
            if ((this.backing & Backing.JsonElement) != 0)
            {
                if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                {
                    return default;
                }

                if (this.jsonElementBacking.TryGetProperty(CommentUtf8JsonPropertyName.Span, out JsonElement result))
                {
                    return new Corvus.Json.JsonString(result);
                }
            }

            if ((this.backing & Backing.Object) != 0)
            {
                if (this.objectBacking.TryGetValue(CommentJsonPropertyName, out JsonAny result))
                {
                    return result.As<Corvus.Json.JsonString>();
                }
            }

            return default;
        }
    }

    /// <summary>
    /// Creates an instance of a <see cref = "Core"/>.
    /// </summary>
    public static Core Create(Corvus.Json.JsonSchema.Draft7.Core.IdValue? id = null, Corvus.Json.JsonUri? schema = null, Corvus.Json.JsonUriReference? @ref = null, Corvus.Json.JsonUriReference? recursiveRef = null, Corvus.Json.JsonString? comment = null)
    {
        var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
        if (id is Corvus.Json.JsonSchema.Draft7.Core.IdValue id__)
        {
            builder.Add(IdJsonPropertyName, id__.AsAny);
        }

        if (schema is Corvus.Json.JsonUri schema__)
        {
            builder.Add(SchemaJsonPropertyName, schema__.AsAny);
        }

        if (@ref is Corvus.Json.JsonUriReference @ref__)
        {
            builder.Add(RefJsonPropertyName, @ref__.AsAny);
        }

        if (comment is Corvus.Json.JsonString comment__)
        {
            builder.Add(CommentJsonPropertyName, comment__.AsAny);
        }

        return builder.ToImmutable();
    }

    /// <summary>
    /// Sets $id.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithId(in Corvus.Json.JsonSchema.Draft7.Core.IdValue value)
    {
        return this.SetProperty(IdJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $schema.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithSchema(in Corvus.Json.JsonUri value)
    {
        return this.SetProperty(SchemaJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $ref.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithRef(in Corvus.Json.JsonUriReference value)
    {
        return this.SetProperty(RefJsonPropertyName, value);
    }

    /// <summary>
    /// Sets $comment.
    /// </summary>
    /// <param name = "value">The value to set.</param>
    /// <returns>The entity with the updated property.</returns>
    public Core WithComment(in Corvus.Json.JsonString value)
    {
        return this.SetProperty(CommentJsonPropertyName, value);
    }

    private static ImmutableDictionary<JsonPropertyName, PropertyValidator<Core>> CreateLocalPropertyValidators()
    {
        ImmutableDictionary<JsonPropertyName, PropertyValidator<Core>>.Builder builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, PropertyValidator<Core>>();
        builder.Add(IdJsonPropertyName, __CorvusValidateId);
        builder.Add(SchemaJsonPropertyName, __CorvusValidateSchema);
        builder.Add(RefJsonPropertyName, __CorvusValidateRef);
        builder.Add(CommentJsonPropertyName, __CorvusValidateComment);
        return builder.ToImmutable();
    }

    private static ValidationContext __CorvusValidateId(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonSchema.Draft7.Core.IdValue property = that.Id;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateSchema(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonUri property = that.Schema;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateRef(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonUriReference property = that.Ref;
        return property.Validate(validationContext, level);
    }

    private static ValidationContext __CorvusValidateComment(in Core that, in ValidationContext validationContext, ValidationLevel level)
    {
        Corvus.Json.JsonString property = that.Comment;
        return property.Validate(validationContext, level);
    }
}