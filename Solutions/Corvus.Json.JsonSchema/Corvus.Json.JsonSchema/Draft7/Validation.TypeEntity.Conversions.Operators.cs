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

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct TypeEntity
    {
        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator TypeEntity(Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.String => new((string)value),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity(TypeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.String) != 0)
            {
                return new(value.stringBacking);
            }

            return Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity.Undefined;
        }

        /// <summary>
        /// Conversion from <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator TypeEntity(Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray value)
        {
            if (value.HasJsonElementBacking)
            {
                return new(value.AsJsonElement);
            }

            return value.ValueKind switch
            {
                JsonValueKind.Array => new((ImmutableList<JsonAny>)value),
                _ => Undefined
            };
        }

        /// <summary>
        /// Conversion to <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray"/>.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray(TypeEntity value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return new(value.AsJsonElement);
            }

            if ((value.backing & Backing.Array) != 0)
            {
                return new(value.arrayBacking);
            }

            return Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray.Undefined;
        }
    }
}