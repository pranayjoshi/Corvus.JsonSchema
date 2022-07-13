//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Corvus.Json.Patch.SpecGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Text;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using Corvus.Json;

    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly struct NotDisabled : IJsonObject<NotDisabled>, IEquatable<NotDisabled>
    {
        /// <summary>
        /// JSON property name for <see cref = "Disabled"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> DisabledUtf8JsonPropertyName = new byte[]{100, 105, 115, 97, 98, 108, 101, 100};
        /// <summary>
        /// JSON property name for <see cref = "Disabled"/>.
        /// </summary>
        public static readonly string DisabledJsonPropertyName = "disabled";
        private static readonly ImmutableDictionary<string, PropertyValidator<NotDisabled>> __CorvusLocalProperties = CreateLocalPropertyValidators();
        private readonly JsonElement jsonElementBacking;
        private readonly ImmutableDictionary<string, JsonAny>? objectBacking;
        /// <summary>
        /// Initializes a new instance of the <see cref = "NotDisabled"/> struct.
        /// </summary>
        /// <param name = "value">The backing <see cref = "JsonElement"/>.</param>
        public NotDisabled(JsonElement value)
        {
            this.jsonElementBacking = value;
            this.objectBacking = default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NotDisabled"/> struct.
        /// </summary>
        /// <param name = "value">A property dictionary.</param>
        public NotDisabled(ImmutableDictionary<string, JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.objectBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NotDisabled"/> struct.
        /// </summary>
        /// <param name = "jsonObject">The <see cref = "JsonObject"/> from which to construct the value.</param>
        public NotDisabled(JsonObject jsonObject)
        {
            if (jsonObject.HasJsonElement)
            {
                this.jsonElementBacking = jsonObject.AsJsonElement;
                this.objectBacking = default;
            }
            else
            {
                this.jsonElementBacking = default;
                this.objectBacking = jsonObject.AsPropertyDictionary;
            }
        }

        /// <summary>
        /// Gets Disabled.
        /// </summary>
        /// <remarks>
        /// {Property title}.
        /// {Property description}.
        /// </remarks>
        /// <example>
        /// {Property examples}.
        /// </example>
        public Corvus.Json.JsonNotAny Disabled
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
                {
                    if (properties.TryGetValue(DisabledJsonPropertyName, out JsonAny result))
                    {
                        return result;
                    }
                }

                if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
                {
                    if (this.jsonElementBacking.TryGetProperty(DisabledUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new Corvus.Json.JsonNotAny(result);
                    }
                }

                return default;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement => this.objectBacking is null;
        /// <summary>
        /// Gets the value as a JsonElement.
        /// </summary>
        public JsonElement AsJsonElement
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return JsonObject.PropertiesToJsonElement(objectBacking);
                }

                return this.jsonElementBacking;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny>)
                {
                    return JsonValueKind.Object;
                }

                return this.jsonElementBacking.ValueKind;
            }
        }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return new JsonAny(objectBacking);
                }

                return new JsonAny(this.jsonElementBacking);
            }
        }

        /// <summary>
        /// Conversion from any.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NotDisabled(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new NotDisabled(value.AsJsonElement);
            }

            return value.As<NotDisabled>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator JsonAny(NotDisabled value)
        {
            return value.AsAny;
        }

        /// <summary>
        /// Conversion from object.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NotDisabled(JsonObject value)
        {
            return new NotDisabled(value);
        }

        /// <summary>
        /// Conversion to object.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator JsonObject(NotDisabled value)
        {
            return value.AsObject;
        }

        /// <summary>
        /// Implicit conversion to a property dictionary.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator ImmutableDictionary<string, JsonAny>(NotDisabled value)
        {
            return value.AsObject.AsPropertyDictionary;
        }

        /// <summary>
        /// Implicit conversion from a property dictionary.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NotDisabled(ImmutableDictionary<string, JsonAny> value)
        {
            return new NotDisabled(value);
        }

        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name = "lhs">The left hand side of the comparison.</param>
        /// <param name = "rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(NotDisabled lhs, NotDisabled rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name = "lhs">The left hand side of the comparison.</param>
        /// <param name = "rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(NotDisabled lhs, NotDisabled rhs)
        {
            return !lhs.Equals(rhs);
        }

        /// <summary>
        /// Creates an instance of a <see cref = "NotDisabled"/>.
        /// </summary>
        public static NotDisabled Create(Corvus.Json.JsonNotAny? disabled = null)
        {
            var builder = ImmutableDictionary.CreateBuilder<string, JsonAny>();
            if (disabled is Corvus.Json.JsonNotAny disabled__)
            {
                builder.Add(DisabledJsonPropertyName, disabled__);
            }

            return builder.ToImmutable();
        }

        /// <summary>
        /// Sets disabled.
        /// </summary>
        /// <param name = "value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public NotDisabled WithDisabled(Corvus.Json.JsonNotAny value)
        {
            return this.SetProperty(DisabledJsonPropertyName, value);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is IJsonValue jv)
            {
                return this.Equals(jv.AsAny);
            }

            return obj is null && this.IsNull();
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            JsonValueKind valueKind = this.ValueKind;
            return valueKind switch
            {
                JsonValueKind.Object => this.AsObject.GetHashCode(),
                JsonValueKind.Array => this.AsArray().GetHashCode(),
                JsonValueKind.Number => this.AsNumber().GetHashCode(),
                JsonValueKind.String => this.AsString().GetHashCode(),
                JsonValueKind.True or JsonValueKind.False => this.AsBoolean().GetHashCode(),
                JsonValueKind.Null => JsonNull.NullHashCode,
                _ => JsonAny.UndefinedHashCode,
            };
        }

        /// <summary>
        /// Writes the object to the <see cref = "Utf8JsonWriter"/>.
        /// </summary>
        /// <param name = "writer">The writer to which to write the object.</param>
        public void WriteTo(Utf8JsonWriter writer)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
            {
                JsonObject.WriteProperties(objectBacking, writer);
                return;
            }

            if (this.jsonElementBacking.ValueKind != JsonValueKind.Undefined)
            {
                this.jsonElementBacking.WriteTo(writer);
                return;
            }

            writer.WriteNullValue();
        }

        /// <inheritdoc/>
        public JsonObjectEnumerator EnumerateObject()
        {
            return this.AsObject.EnumerateObject();
        }

        /// <inheritdoc/>
        public bool TryGetProperty(string name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(name, out value);
        }

        /// <inheritdoc/>
        public bool TryGetProperty(ReadOnlySpan<char> name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(name, out value);
        }

        /// <inheritdoc/>
        public bool TryGetProperty(ReadOnlySpan<byte> utf8name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(utf8name, out value);
        }

        /// <inheritdoc/>
        public bool Equals<T>(T other)
            where T : struct, IJsonValue
        {
            JsonValueKind valueKind = this.ValueKind;
            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                JsonValueKind.Object => this.AsObject.Equals(other.AsObject()),
                JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                JsonValueKind.String => this.AsString().Equals(other.AsString()),
                JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                JsonValueKind.Null => true,
                _ => false,
            };
        }

        /// <inheritdoc/>
        public bool Equals(NotDisabled other)
        {
            JsonValueKind valueKind = this.ValueKind;
            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                JsonValueKind.Object => this.AsObject.Equals(other.AsObject),
                JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                JsonValueKind.String => this.AsString().Equals(other.AsString()),
                JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                JsonValueKind.Null => true,
                _ => false,
            };
        }

        /// <inheritdoc/>
        public bool HasProperty(string name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(name, out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(name.ToString(), out JsonElement _);
            }

            return false;
        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<char> name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(name.ToString(), out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(name, out JsonElement _);
            }

            return false;
        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<byte> utf8name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(System.Text.Encoding.UTF8.GetString(utf8name), out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(utf8name, out JsonElement _);
            }

            return false;
        }

        /// <inheritdoc/>
        public NotDisabled SetProperty<TValue>(string name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public NotDisabled SetProperty<TValue>(ReadOnlySpan<char> name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public NotDisabled SetProperty<TValue>(ReadOnlySpan<byte> utf8name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(utf8name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public NotDisabled RemoveProperty(string name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public NotDisabled RemoveProperty(ReadOnlySpan<char> name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public NotDisabled RemoveProperty(ReadOnlySpan<byte> utf8Name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(utf8Name);
            }

            return this;
        }

        /// <inheritdoc/>
        public T As<T>()
            where T : struct, IJsonValue
        {
            return this.As<NotDisabled, T>();
        }

        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }

            JsonValueKind valueKind = this.ValueKind;
            result = this.ValidateObject(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

            return result;
        }

        /// <summary>
        /// Gets the value as a <see cref = "JsonObject"/>.
        /// </summary>
        private JsonObject AsObject
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return new JsonObject(objectBacking);
                }

                return new JsonObject(this.jsonElementBacking);
            }
        }

        private static ImmutableDictionary<string, PropertyValidator<NotDisabled>> CreateLocalPropertyValidators()
        {
            ImmutableDictionary<string, PropertyValidator<NotDisabled>>.Builder builder = ImmutableDictionary.CreateBuilder<string, PropertyValidator<NotDisabled>>();
            builder.Add(DisabledJsonPropertyName, __CorvusValidateDisabled);
            return builder.ToImmutable();
        }

        private static ValidationContext __CorvusValidateDisabled(in NotDisabled that, in ValidationContext validationContext, ValidationLevel level)
        {
            Corvus.Json.JsonNotAny property = that.Disabled;
            return property.Validate(validationContext, level);
        }

        private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

            int propertyCount = 0;
            foreach (Property property in this.EnumerateObject())
            {
                string propertyName = property.Name;
                if (__CorvusLocalProperties.TryGetValue(propertyName, out PropertyValidator<NotDisabled>? propertyValidator))
                {
                    result = result.WithLocalProperty(propertyCount);
                    var propertyResult = propertyValidator(this, result.CreateChildContext(), level);
                    result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }
                }

                propertyCount++;
            }

            return result;
        }
    }
}