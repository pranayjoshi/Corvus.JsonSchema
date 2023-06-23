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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct Copy
    {
        /// <summary>
        /// JSON property name for <see cref = "FromValue"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> FromValueUtf8JsonPropertyName = new byte[]
        {
            102,
            114,
            111,
            109
        };
        /// <summary>
        /// JSON property name for <see cref = "FromValue"/>.
        /// </summary>
        public const string FromValueJsonPropertyName = "from";
        /// <summary>
        /// JSON property name for <see cref = "Path"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> PathUtf8JsonPropertyName = new byte[]
        {
            112,
            97,
            116,
            104
        };
        /// <summary>
        /// JSON property name for <see cref = "Path"/>.
        /// </summary>
        public const string PathJsonPropertyName = "path";
        /// <summary>
        /// JSON property name for <see cref = "Op"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> OpUtf8JsonPropertyName = new byte[]
        {
            111,
            112
        };
        /// <summary>
        /// JSON property name for <see cref = "Op"/>.
        /// </summary>
        public const string OpJsonPropertyName = "op";
        /// <summary>
        /// Gets FromValue.
        /// </summary>
        public Corvus.Json.JsonPointer FromValue
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(FromValueUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.JsonPointer(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(FromValueJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.JsonPointer>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets Path.
        /// </summary>
        public Corvus.Json.JsonPointer Path
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(PathUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.JsonPointer(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(PathJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.JsonPointer>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets Op.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.Copy.OpEntity Op
        {
            get
            {
                if ((this.backing & Backing.JsonElement) != 0)
                {
                    if (this.jsonElementBacking.ValueKind != JsonValueKind.Object)
                    {
                        return default;
                    }

                    if (this.jsonElementBacking.TryGetProperty(OpUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.Patch.Model.JsonPatchDocument.Copy.OpEntity(result);
                    }
                }

                if ((this.backing & Backing.Object) != 0)
                {
                    if (this.objectBacking.TryGetValue(OpJsonPropertyName, out JsonAny result))
                    {
                        return result.As<Corvus.Json.Patch.Model.JsonPatchDocument.Copy.OpEntity>();
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Creates an instance of a <see cref = "Copy"/>.
        /// </summary>
        public static Copy Create(Corvus.Json.JsonPointer fromValue, Corvus.Json.JsonPointer path)
        {
            var builder = ImmutableDictionary.CreateBuilder<JsonPropertyName, JsonAny>();
            builder.Add(FromValueJsonPropertyName, fromValue.AsAny);
            builder.Add(PathJsonPropertyName, path.AsAny);
            builder.Add(OpJsonPropertyName, new Corvus.Json.Patch.Model.JsonPatchDocument.Copy.OpEntity().AsAny);
            return builder.ToImmutable();
        }

        /// <summary>
        /// Sets from.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public Copy WithFromValue(in Corvus.Json.JsonPointer value)
        {
            return this.SetProperty(FromValueJsonPropertyName, value);
        }

        /// <summary>
        /// Sets path.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public Copy WithPath(in Corvus.Json.JsonPointer value)
        {
            return this.SetProperty(PathJsonPropertyName, value);
        }

        private static ValidationContext __CorvusValidateFromValue(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.JsonPointer>().Validate(validationContext, level);
        }

        private static ValidationContext __CorvusValidateOp(in JsonObjectProperty property, in ValidationContext validationContext, ValidationLevel level)
        {
            return property.ValueAs<Corvus.Json.Patch.Model.JsonPatchDocument.Copy.OpEntity>().Validate(validationContext, level);
        }

        /// <summary>
        /// Tries to get the validator for the given property.
        /// </summary>
        /// <param name = "property">The property for which to get the validator.</param>
        /// <param name = "hasJsonElementBacking"><c>True</c> if the object containing the property has a JsonElement backing.</param>
        /// <param name = "propertyValidator">The validator for the property, if provided by this schema.</param>
        /// <returns><c>True</c> if the validator was found.</returns>
        private bool __TryGetCorvusLocalPropertiesValidator(in JsonObjectProperty property, bool hasJsonElementBacking, [NotNullWhen(true)] out ObjectPropertyValidator? propertyValidator)
        {
            if (hasJsonElementBacking)
            {
                if (property.NameEquals(FromValueUtf8JsonPropertyName.Span))
                {
                    propertyValidator = __CorvusValidateFromValue;
                    return true;
                }
                else if (property.NameEquals(OpUtf8JsonPropertyName.Span))
                {
                    propertyValidator = __CorvusValidateOp;
                    return true;
                }
            }
            else
            {
                if (property.NameEquals(FromValueJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateFromValue;
                    return true;
                }
                else if (property.NameEquals(OpJsonPropertyName))
                {
                    propertyValidator = __CorvusValidateOp;
                    return true;
                }
            }

            propertyValidator = null;
            return false;
        }
    }
}