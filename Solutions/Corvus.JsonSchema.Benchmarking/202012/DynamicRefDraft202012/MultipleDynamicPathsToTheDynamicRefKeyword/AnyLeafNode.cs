
    //------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword
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
    public readonly struct AnyLeafNode :
            IJsonObject<AnyLeafNode>,
                    IEquatable<AnyLeafNode>
    {

        
    
    
    
    
    
    
    

    
        private readonly JsonElement jsonElementBacking;

            private readonly ImmutableDictionary<string, JsonAny>? objectBacking;
    
    
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnyLeafNode"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public AnyLeafNode(JsonElement value)
        {
            this.jsonElementBacking = value;
                this.objectBacking = default;
                            }

            /// <summary>
        /// Initializes a new instance of the <see cref="AnyLeafNode"/> struct.
        /// </summary>
        /// <param name="value">A property dictionary.</param>
        public AnyLeafNode(ImmutableDictionary<string, JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.objectBacking = value;
                                        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnyLeafNode"/> struct.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> from which to construct the value.</param>
        public AnyLeafNode(JsonObject jsonObject)
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
        /// Initializes a new instance of the <see cref="AnyLeafNode"/> struct.
        /// </summary>
        /// <param name="conversion">The <see cref="DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity"/> from which to construct the value.</param>
        public AnyLeafNode(DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity conversion)
        {
            if (conversion.HasJsonElement)
            {
                this.jsonElementBacking = conversion.AsJsonElement;
                        this.objectBacking = default;
                
                                    }
            else
            {
                this.jsonElementBacking = default;
                        if (conversion.ValueKind == JsonValueKind.Object)
                {
                    this.objectBacking = conversion;
                }
                else
                {
                    this.objectBacking = default;
                }
                
                                    }
        }
    

    
            /// <summary>
        /// Gets the value as a <see cref="DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity" />.
        /// </summary>
        public DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity AsInnerEntity
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref="DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity" />.
        /// </summary>
        public bool IsInnerEntity
        {
            get
            {
                return ((DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity)this).Validate().IsValid;
            }
        }

    
    
            /// <summary>
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement =>
    
                this.objectBacking is null
            
    
                
                ;

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
        /// Conversion from <see cref="DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity" />.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator AnyLeafNode(DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity value)
        {
            return new AnyLeafNode(value);
        }

        /// <summary>
        /// Conversion to <see cref="DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity" />.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity(AnyLeafNode value)
        {
                    if (value.ValueKind == JsonValueKind.Object)
            {
                return new DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity(value.AsObject);
            }
                                                    return default;
        }
    
        
        /// <summary>
        /// Conversion from any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator AnyLeafNode(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new AnyLeafNode(value.AsJsonElement);
            }

            return value.As<AnyLeafNode>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(AnyLeafNode value)
        {
            return value.AsAny;
        }

    
    
        /// <summary>
        /// Conversion from object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator AnyLeafNode(JsonObject value)
        {
            return new AnyLeafNode(value);
        }

        /// <summary>
        /// Conversion to object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonObject(AnyLeafNode value)
        {
            return value.AsObject;
        }

                /// <summary>
        /// Implicit conversion to a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ImmutableDictionary<string, JsonAny>(AnyLeafNode  value)
        {
            return value.AsObject.AsPropertyDictionary;
        }

        /// <summary>
        /// Implicit conversion from a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator AnyLeafNode (ImmutableDictionary<string, JsonAny> value)
        {
            return new AnyLeafNode (value);
        }

    
    
    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(AnyLeafNode lhs, AnyLeafNode rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(AnyLeafNode lhs, AnyLeafNode rhs)
        {
            return !lhs.Equals(rhs);
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
        /// Writes the object to the <see cref="Utf8JsonWriter"/>.
        /// </summary>
        /// <param name="writer">The writer to which to write the object.</param>
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
        public bool Equals(AnyLeafNode other)
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

            return false;        }

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

            return false;        }

        /// <inheritdoc/>
        public AnyLeafNode SetProperty<TValue>(string name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public AnyLeafNode SetProperty<TValue>(ReadOnlySpan<char> name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public AnyLeafNode SetProperty<TValue>(ReadOnlySpan<byte> utf8name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(utf8name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public AnyLeafNode RemoveProperty(string name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public AnyLeafNode RemoveProperty(ReadOnlySpan<char> name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public AnyLeafNode RemoveProperty(ReadOnlySpan<byte> utf8Name)
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
            return this.As<AnyLeafNode, T>();
        }


    
        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }
        
        

                result = this.ValidateRef(result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }
    
    
    
    
    
        
    
    
    
    
    
    
    

                return result;
        }

            /// <summary>
        /// Gets the value as a <see cref="JsonObject"/>.
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
    
    
    
    
    
    
    
    
    
    
            private ValidationContext ValidateRef(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;

            ValidationContext refResult = this.As<DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode.InnerEntity>().Validate(validationContext.CreateChildContext(), level);

            if (!refResult.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = validationContext.MergeResults(false, level, refResult);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = validationContext.MergeResults(false, level, refResult);
                }
                else
                {
                    result = validationContext.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, refResult);
                }

                result = result.MergeChildContext(refResult, false);
            }

            return result;
        }
    
    
    
            

            

            

            

    
    
    
    
    
    
    
        /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly struct InnerEntity :
            IJsonObject<InnerEntity>,
                    IEquatable<InnerEntity>
    {

        
    
    
    
    
    
    
    

    
        private readonly JsonElement jsonElementBacking;

            private readonly ImmutableDictionary<string, JsonAny>? objectBacking;
    
    
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InnerEntity"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public InnerEntity(JsonElement value)
        {
            this.jsonElementBacking = value;
                this.objectBacking = default;
                            }

            /// <summary>
        /// Initializes a new instance of the <see cref="InnerEntity"/> struct.
        /// </summary>
        /// <param name="value">A property dictionary.</param>
        public InnerEntity(ImmutableDictionary<string, JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.objectBacking = value;
                                        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerEntity"/> struct.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> from which to construct the value.</param>
        public InnerEntity(JsonObject jsonObject)
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
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement =>
    
                this.objectBacking is null
            
    
                
                ;

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
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator InnerEntity(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new InnerEntity(value.AsJsonElement);
            }

            return value.As<InnerEntity>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(InnerEntity value)
        {
            return value.AsAny;
        }

    
    
        /// <summary>
        /// Conversion from object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator InnerEntity(JsonObject value)
        {
            return new InnerEntity(value);
        }

        /// <summary>
        /// Conversion to object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonObject(InnerEntity value)
        {
            return value.AsObject;
        }

                /// <summary>
        /// Implicit conversion to a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ImmutableDictionary<string, JsonAny>(InnerEntity  value)
        {
            return value.AsObject.AsPropertyDictionary;
        }

        /// <summary>
        /// Implicit conversion from a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator InnerEntity (ImmutableDictionary<string, JsonAny> value)
        {
            return new InnerEntity (value);
        }

    
    
    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(InnerEntity lhs, InnerEntity rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(InnerEntity lhs, InnerEntity rhs)
        {
            return !lhs.Equals(rhs);
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
        /// Writes the object to the <see cref="Utf8JsonWriter"/>.
        /// </summary>
        /// <param name="writer">The writer to which to write the object.</param>
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

    
                /// <summary>
        /// Enumerate the object as the given item type
        /// </summary>
        public JsonObjectEnumerator<DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode> EnumerateProperties()
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return new JsonObjectEnumerator<DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode>(properties);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return new JsonObjectEnumerator<DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode>(this.jsonElementBacking);
            }

            return default;

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
        public bool Equals(InnerEntity other)
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

            return false;        }

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

            return false;        }

        /// <inheritdoc/>
        public InnerEntity SetProperty<TValue>(string name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public InnerEntity SetProperty<TValue>(ReadOnlySpan<char> name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public InnerEntity SetProperty<TValue>(ReadOnlySpan<byte> utf8name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(utf8name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public InnerEntity RemoveProperty(string name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public InnerEntity RemoveProperty(ReadOnlySpan<char> name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public InnerEntity RemoveProperty(ReadOnlySpan<byte> utf8Name)
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
            return this.As<InnerEntity, T>();
        }


    
        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }
                    result = result.UsingEvaluatedProperties();
        
        

    
                JsonValueKind valueKind = this.ValueKind;
    
    
    
    
        
    
    
    
    
    
    
                result = this.ValidateObject(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

    

                return result;
        }

            /// <summary>
        /// Gets the value as a <see cref="JsonObject"/>.
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

        
        
        
        
                        if (!result.HasEvaluatedLocalProperty(propertyCount))
                {
                    result = property.ValueAs<DynamicRefDraft202012Feature.MultipleDynamicPathsToTheDynamicRefKeyword.AnyLeafNode>().Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }
                    result = result.WithLocalProperty(propertyCount);
                }
        
        
        
                
                propertyCount++;

                    }

        
        
        
            return result;
        }

    
            

            

            

            

    
    
    
    
    
    
    }
    

    
    }
    }
    