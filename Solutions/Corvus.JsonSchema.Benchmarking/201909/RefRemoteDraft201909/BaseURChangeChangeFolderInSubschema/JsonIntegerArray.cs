
    //------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace RefRemoteDraft201909Feature.BaseURChangeChangeFolderInSubschema
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using Corvus.Json;

        /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly struct JsonIntegerArray :
                IJsonArray<JsonIntegerArray>,
                IEquatable<JsonIntegerArray>
    {

        
    
    
    
    
    
    
    

    
        private readonly JsonElement jsonElementBacking;

    
            private readonly ImmutableList<JsonAny>? arrayBacking;
    
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonIntegerArray"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public JsonIntegerArray(JsonElement value)
        {
            this.jsonElementBacking = value;
                    this.arrayBacking = default;
                        }

    
            /// <summary>
        /// Initializes a new instance of the <see cref="JsonIntegerArray"/> struct.
        /// </summary>
        /// <param name="value">An array list.</param>
        public JsonIntegerArray(ImmutableList<JsonAny> value)
        {
            this.jsonElementBacking = default;
                                            this.arrayBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonIntegerArray"/> struct.
        /// </summary>
        /// <param name="jsonArray">The <see cref="JsonArray"/> from which to construct the value.</param>
        public JsonIntegerArray(JsonArray jsonArray)
        {
            if (jsonArray.HasJsonElement)
            {
                this.jsonElementBacking = jsonArray.AsJsonElement;
                this.arrayBacking = default;
            }
            else
            {
                this.jsonElementBacking = default;
                this.arrayBacking = jsonArray.AsItemsList;
            }

                                        }
    
    
    
    
    
    

            /// <inheritdoc/>
        public int Length
        {
            get
            {
                if (this.arrayBacking is ImmutableList<JsonAny> items)
                {
                    return items.Count;
                }

                return this.jsonElementBacking.GetArrayLength();
            }
        }
    
    
        
            /// <summary>
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement =>
    
    
                        this.arrayBacking is null
                
                ;

        /// <summary>
        /// Gets the value as a JsonElement.
        /// </summary>
        public JsonElement AsJsonElement
        {
            get
            {
    
                    if (this.arrayBacking is ImmutableList<JsonAny> arrayBacking)
                {
                    return JsonArray.ItemsToJsonElement(arrayBacking);
                }
    
    
    
    
                return this.jsonElementBacking;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
    
                    if (this.arrayBacking is ImmutableList<JsonAny>)
                {
                    return JsonValueKind.Array;
                }

    
    
    
    
                return this.jsonElementBacking.ValueKind;
            }
        }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
    
                    if (this.arrayBacking is ImmutableList<JsonAny> arrayBacking)
                {
                    return new JsonAny(arrayBacking);
                }

    
    
    
    
                return new JsonAny(this.jsonElementBacking);
            }
        }

    
        
        /// <summary>
        /// Conversion from any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonIntegerArray(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new JsonIntegerArray(value.AsJsonElement);
            }

            return value.As<JsonIntegerArray>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(JsonIntegerArray value)
        {
            return value.AsAny;
        }

    
        /// <summary>
        /// Conversion from array.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonIntegerArray(JsonArray value)
        {
            return new JsonIntegerArray(value);
        }

        /// <summary>
        /// Conversion to array.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonArray(JsonIntegerArray value)
        {
            return value.AsArray;
        }
       
        /// <summary>
        /// Implicit conversion to an <see cref="ImmutableList{T}"/> of <see cref="JsonAny"/>.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ImmutableList<JsonAny>(JsonIntegerArray value)
        {
            return value.AsArray.AsItemsList;
        }

        /// <summary>
        /// Implicit conversion from an <see cref="ImmutableList{T}"/> of <see cref="JsonAny"/>.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonIntegerArray(ImmutableList<JsonAny> value)
        {
            return new JsonIntegerArray(value);
        }
    
    
    
    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(JsonIntegerArray lhs, JsonIntegerArray rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(JsonIntegerArray lhs, JsonIntegerArray rhs)
        {
            return !lhs.Equals(rhs);
        }

                    /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="items">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static JsonIntegerArray From(params Corvus.Json.JsonInteger[] items)
        {
            var builder = ImmutableList.CreateBuilder<JsonAny>();
            foreach (var item in items)
            {
                builder.Add(item);
            }

            return new JsonIntegerArray(builder.ToImmutable());
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static JsonIntegerArray From(Corvus.Json.JsonInteger item1)
        {
            return new JsonIntegerArray(ImmutableList.Create((JsonAny)item1));
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The first item from which to create the array.</param>
        /// <param name="item2">The second item from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static JsonIntegerArray From(Corvus.Json.JsonInteger item1, Corvus.Json.JsonInteger item2)
        {
            return new JsonIntegerArray(ImmutableList.Create((JsonAny)item1, (JsonAny)item2));
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The first item from which to create the array.</param>
        /// <param name="item2">The second item from which to create the array.</param>
        /// <param name="item3">The third item from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static JsonIntegerArray From(Corvus.Json.JsonInteger item1, Corvus.Json.JsonInteger item2, Corvus.Json.JsonInteger item3)
        {
            return new JsonIntegerArray(ImmutableList.Create((JsonAny)item1, (JsonAny)item2, (JsonAny)item3));
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The first item from which to create the array.</param>
        /// <param name="item2">The second item from which to create the array.</param>
        /// <param name="item3">The third item from which to create the array.</param>
        /// <param name="item4">The fourth item from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static JsonIntegerArray From(Corvus.Json.JsonInteger item1, Corvus.Json.JsonInteger item2, Corvus.Json.JsonInteger item3, Corvus.Json.JsonInteger item4)
        {
            return new JsonIntegerArray(ImmutableList.Create((JsonAny)item1, (JsonAny)item2, (JsonAny)item3, (JsonAny)item4));
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
                    JsonValueKind.Object => this.AsObject().GetHashCode(),
                        JsonValueKind.Array => this.AsArray.GetHashCode(),
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
    
                if (this.arrayBacking is ImmutableList<JsonAny> arrayBacking)
            {
                JsonArray.WriteItems(arrayBacking, writer);
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
        /// Enumerate the items in the array as a <see cref="Corvus.Json.JsonInteger" />.
        /// </summary>
        public JsonArrayEnumerator<Corvus.Json.JsonInteger> EnumerateItems()
        {
            if (this.arrayBacking is ImmutableList<JsonAny> items)
            {
                return new JsonArrayEnumerator<Corvus.Json.JsonInteger>(items);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Array)
            {
                return new JsonArrayEnumerator<Corvus.Json.JsonInteger>(this.jsonElementBacking);
            }

            return default;
        }
                /// <inheritdoc/>
        public JsonArrayEnumerator EnumerateArray()
        {
            return this.AsArray.EnumerateArray();
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
                    JsonValueKind.Object => this.AsObject().Equals(other.AsObject()),
                        JsonValueKind.Array => this.AsArray.Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

        /// <inheritdoc/>
        public bool Equals(JsonIntegerArray other)
        {
            JsonValueKind valueKind = this.ValueKind;

            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                                JsonValueKind.Object => this.AsObject().Equals(other.AsObject()),
                        JsonValueKind.Array => this.AsArray.Equals(other.AsArray),
                        JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

    
    
        /// <inheritdoc/>
        public JsonIntegerArray Add<TItem>(TItem item)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(item);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray Add<TItem1, TItem2>(TItem1 item1, TItem2 item2)
            where TItem1 : struct, IJsonValue
            where TItem2 : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(item1, item2);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray Add<TItem1, TItem2, TItem3>(TItem1 item1, TItem2 item2, TItem3 item3)
            where TItem1 : struct, IJsonValue
            where TItem2 : struct, IJsonValue
            where TItem3 : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(item1, item2, item3);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray Add<TItem1, TItem2, TItem3, TItem4>(TItem1 item1, TItem2 item2, TItem3 item3, TItem4 item4)
            where TItem1 : struct, IJsonValue
            where TItem2 : struct, IJsonValue
            where TItem3 : struct, IJsonValue
            where TItem4 : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(item1, item2, item3, item4);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray Add<TItem>(params TItem[] items)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(items);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray AddRange<TItem>(IEnumerable<TItem> items)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.AddRange(items);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray Insert<TItem>(int index, TItem item)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Insert(index, item);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray Replace<TItem>(TItem oldValue, TItem newValue)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.Replace(oldValue, newValue);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray RemoveAt(int index)
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.RemoveAt(index);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray RemoveRange(int index, int count)
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.RemoveRange(index, count);
            }

            return this;
        }

        /// <inheritdoc/>
        public JsonIntegerArray SetItem<TItem>(int index, TItem value)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.SetItem(index, value);
            }

            return this;
        }

    
        /// <inheritdoc/>
        public T As<T>()
            where T : struct, IJsonValue
        {
            return this.As<JsonIntegerArray, T>();
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
    
    
                    result = this.ValidateType(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }
        
        
        
        
    
    
    
        
    
    
    
    
    
    
    

                result = this.ValidateArray(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }
                return result;
        }


    
    
    
    
    
    
            /// <summary>
        /// Gets the value as a <see cref="JsonArray"/>.
        /// </summary>
        private JsonArray AsArray
        {
            get
            {
                if (this.arrayBacking is ImmutableList<JsonAny> arrayBacking)
                {
                    return new JsonArray(arrayBacking);
                }

                return new JsonArray(this.jsonElementBacking);
            }
        }
    
    
    
    
    
            private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;

            if (valueKind != JsonValueKind.Array)
            {
                return result;
            }

         
            int arrayLength = 0;
         
        
                     JsonArrayEnumerator arrayEnumerator = this.EnumerateArray();

            while (arrayEnumerator.MoveNext())
            {
        
        
                        result = arrayEnumerator.Current.As<Corvus.Json.JsonInteger>().Validate(result, level);
                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }

                result = result.WithLocalItemIndex(arrayLength);

        
                arrayLength++;
            }
        
        
        
        
            return result;
        }

    
    
            

            

            

            

    
    
    
            
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;

        
        
                
            ValidationContext localResultArray = Corvus.Json.Validate.TypeArray(valueKind, result, level);
            if (level == ValidationLevel.Flag && localResultArray.IsValid)
            {
                return validationContext;
            }

            if (localResultArray.IsValid)
            {
                isValid = true;
            }

        
        
        
        
        
            result = result.MergeResults(
                isValid,
                level
        
        
                
                , localResultArray
        
        
        
        
                        );

            return result;
        }

    
    
    
    }
    }
    