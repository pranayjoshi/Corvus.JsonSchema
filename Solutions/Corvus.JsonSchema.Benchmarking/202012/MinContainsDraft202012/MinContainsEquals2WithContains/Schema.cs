
    //------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace MinContainsDraft202012Feature.MinContainsEquals2WithContains
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
    public readonly struct Schema :
                IJsonArray<Schema>,
                IEquatable<Schema>
    {

        
    
    
    
    
    
    
    

    
        private readonly JsonElement jsonElementBacking;

    
            private readonly ImmutableList<JsonAny>? arrayBacking;
    
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Schema"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public Schema(JsonElement value)
        {
            this.jsonElementBacking = value;
                    this.arrayBacking = default;
                        }

    
            /// <summary>
        /// Initializes a new instance of the <see cref="Schema"/> struct.
        /// </summary>
        /// <param name="value">An array list.</param>
        public Schema(ImmutableList<JsonAny> value)
        {
            this.jsonElementBacking = default;
                                            this.arrayBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Schema"/> struct.
        /// </summary>
        /// <param name="jsonArray">The <see cref="JsonArray"/> from which to construct the value.</param>
        public Schema(JsonArray jsonArray)
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
        /// <inheritdoc/>
        public JsonAny this[int index]
        {
            get
            {
                if (this.arrayBacking is ImmutableList<JsonAny> items)
                {
                    return items[index];
                }

                return new JsonAny(this.jsonElementBacking[index]);
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
        public static implicit operator Schema(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new Schema(value.AsJsonElement);
            }

            return value.As<Schema>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(Schema value)
        {
            return value.AsAny;
        }

    
        /// <summary>
        /// Conversion from array.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator Schema(JsonArray value)
        {
            return new Schema(value);
        }

        /// <summary>
        /// Conversion to array.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonArray(Schema value)
        {
            return value.AsArray;
        }
       
        /// <summary>
        /// Implicit conversion to an <see cref="ImmutableList{T}"/> of <see cref="JsonAny"/>.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ImmutableList<JsonAny>(Schema value)
        {
            return value.AsArray.AsItemsList;
        }

        /// <summary>
        /// Implicit conversion from an <see cref="ImmutableList{T}"/> of <see cref="JsonAny"/>.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator Schema(ImmutableList<JsonAny> value)
        {
            return new Schema(value);
        }
    
    
    
    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(Schema lhs, Schema rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(Schema lhs, Schema rhs)
        {
            return !lhs.Equals(rhs);
        }

                            /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="items">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static Schema From(params JsonAny[] items)
        {
            return new Schema(items.ToImmutableList());
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The items from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static Schema From(JsonAny item1)
        {
            return new Schema(ImmutableList.Create(item1));
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The first item from which to create the array.</param>
        /// <param name="item2">The second item from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static Schema From(JsonAny item1, JsonAny item2)
        {
            return new Schema(ImmutableList.Create(item1, item2));
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The first item from which to create the array.</param>
        /// <param name="item2">The second item from which to create the array.</param>
        /// <param name="item3">The third item from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static Schema From(JsonAny item1, JsonAny item2, JsonAny item3)
        {
            return new Schema(ImmutableList.Create(item1, item2, item3));
        }

        /// <summary>
        /// Create an array from the given items.
        /// </summary>
        /// <param name="item1">The first item from which to create the array.</param>
        /// <param name="item2">The second item from which to create the array.</param>
        /// <param name="item3">The third item from which to create the array.</param>
        /// <param name="item4">The fourth item from which to create the array.</param>
        /// <returns>The new array created from the items.</returns>
        public static Schema From(JsonAny item1, JsonAny item2, JsonAny item3, JsonAny item4)
        {
            return new Schema(ImmutableList.Create(item1, item2, item3, item4));
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
        public bool Equals(Schema other)
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
        public Schema Add<TItem>(TItem item)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(item);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema Add<TItem1, TItem2>(TItem1 item1, TItem2 item2)
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
        public Schema Add<TItem1, TItem2, TItem3>(TItem1 item1, TItem2 item2, TItem3 item3)
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
        public Schema Add<TItem1, TItem2, TItem3, TItem4>(TItem1 item1, TItem2 item2, TItem3 item3, TItem4 item4)
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
        public Schema Add<TItem>(params TItem[] items)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Add(items);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema AddRange<TItem>(IEnumerable<TItem> items)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.AddRange(items);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema Insert<TItem>(int index, TItem item)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsArray.Insert(index, item);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema Replace<TItem>(TItem oldValue, TItem newValue)
            where TItem : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.Replace(oldValue, newValue);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema RemoveAt(int index)
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.RemoveAt(index);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema RemoveRange(int index, int count)
        {
            if (this.ValueKind == JsonValueKind.Array)
            {
                return this.AsArray.RemoveRange(index, count);
            }

            return this;
        }

        /// <inheritdoc/>
        public Schema SetItem<TItem>(int index, TItem value)
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
            return this.As<Schema, T>();
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
         
                    int containsCount = 0;

        
                     JsonArrayEnumerator arrayEnumerator = this.EnumerateArray();

            while (arrayEnumerator.MoveNext())
            {
        
                        ValidationContext containsResult = arrayEnumerator.Current.As<MinContainsDraft202012Feature.MinContainsEquals2WithContains.Schema.ContainsEntity>().Validate(result.CreateChildContext(), level);

                if (containsResult.IsValid)
                {
                    result = result.WithLocalItemIndex(arrayLength);
                    containsCount++;

                            }

        
        
                arrayLength++;
            }
        
        
        
                    
                        if (containsCount < 2)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, $"6.4.5. minContains - {containsCount} is less than minimum number of matching items 2.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "6.4.5. minContains - item count is less than minimum number of matching items 2.");
                }
                else
                {
                    return result.WithResult(isValid: false);
                }
            }

            

        
            return result;
        }

    
    
            

            

            

            

    
    
    
    
    
    
    
        /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly struct ContainsEntity :
                    IJsonValue,
            IEquatable<ContainsEntity>
    {

        
    
            private static readonly ContainsEntity __CorvusConstValue = JsonAny.Parse("1");
    
    
    
    
    
    

    
        private readonly JsonElement jsonElementBacking;

    
    
            private readonly double? numberBacking;
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsEntity"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public ContainsEntity(JsonElement value)
        {
            this.jsonElementBacking = value;
                        this.numberBacking = default;
                    }

    
    
            /// <summary>
        /// Initializes a new instance of the <see cref="ContainsEntity"/> struct.
        /// </summary>
        /// <param name="jsonNumber">The <see cref="JsonNumber"/> from which to construct the value.</param>
        public ContainsEntity(JsonNumber jsonNumber)
        {
            if (jsonNumber.HasJsonElement)
            {
                this.jsonElementBacking = jsonNumber.AsJsonElement;
                this.numberBacking = default;
            }
            else
            {
                this.jsonElementBacking = default;
                this.numberBacking = jsonNumber.GetDouble();
            }
                                        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsEntity"/> struct.
        /// </summary>
        /// <param name="value">A number value.</param>
        public ContainsEntity(double value)
        {
            this.jsonElementBacking = default;
                                            this.numberBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsEntity"/> struct.
        /// </summary>
        /// <param name="value">A number value.</param>
        public ContainsEntity(int value)
        {
            this.jsonElementBacking = default;
                                            this.numberBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsEntity"/> struct.
        /// </summary>
        /// <param name="value">A number value.</param>
        public ContainsEntity(float value)
        {
            this.jsonElementBacking = default;
                                            this.numberBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsEntity"/> struct.
        /// </summary>
        /// <param name="value">A number value.</param>
        public ContainsEntity(long value)
        {
            this.jsonElementBacking = default;
                                            this.numberBacking = value;
        }
    
    
    
    
    

    
    
    
            /// <summary>
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement =>
    
    
                            this.numberBacking is null
            
                ;

        /// <summary>
        /// Gets the value as a JsonElement.
        /// </summary>
        public JsonElement AsJsonElement
        {
            get
            {
    
    
                    if (this.numberBacking is double numberBacking)
                {
                    return JsonNumber.NumberToJsonElement(numberBacking);
                }

    
    
    
                return this.jsonElementBacking;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
    
    
                    if (this.numberBacking is double)
                {
                    return JsonValueKind.Number;
                }

    
    
    
                return this.jsonElementBacking.ValueKind;
            }
        }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
    
    
                    if (this.numberBacking is double numberBacking)
                {
                    return new JsonAny(numberBacking);
                }

    
    
    
                return new JsonAny(this.jsonElementBacking);
            }
        }

    
        
        /// <summary>
        /// Conversion from any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ContainsEntity(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new ContainsEntity(value.AsJsonElement);
            }

            return value.As<ContainsEntity>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(ContainsEntity value)
        {
            return value.AsAny;
        }

    
    
    
    
        /// <summary>
        /// Conversion from double.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ContainsEntity(double value)
        {
            return new ContainsEntity(value);
        }

        /// <summary>
        /// Conversion to double.
        /// </summary>
        /// <param name="number">The number from which to convert.</param>
        public static implicit operator double(ContainsEntity number)
        {
            return number.AsNumber.GetDouble();
        }

        /// <summary>
        /// Conversion from float.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ContainsEntity(float value)
        {
            return new ContainsEntity(value);
        }

        /// <summary>
        /// Conversion to float.
        /// </summary>
        /// <param name="number">The number from which to convert.</param>
        public static implicit operator float(ContainsEntity number)
        {
            return number.AsNumber.GetSingle();
        }

        /// <summary>
        /// Conversion from long.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ContainsEntity(long value)
        {
            return new ContainsEntity(value);
        }

        /// <summary>
        /// Conversion to long.
        /// </summary>
        /// <param name="number">The number from which to convert.</param>
        public static implicit operator long(ContainsEntity number)
        {
            return number.AsNumber.GetInt64();
        }

        /// <summary>
        /// Conversion from int.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ContainsEntity(int value)
        {
            return new ContainsEntity(value);
        }

        /// <summary>
        /// Conversion to int.
        /// </summary>
        /// <param name="number">The number from which to convert.</param>
        public static implicit operator int(ContainsEntity number)
        {
            return number.AsNumber.GetInt32();
        }

        /// <summary>
        /// Conversion from number.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ContainsEntity(JsonNumber value)
        {
            return new ContainsEntity(value);
        }

        /// <summary>
        /// Conversion to number.
        /// </summary>
        /// <param name="number">The value from which to convert.</param>
        public static implicit operator JsonNumber(ContainsEntity number)
        {
            return number.AsNumber;
        }

    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(ContainsEntity lhs, ContainsEntity rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(ContainsEntity lhs, ContainsEntity rhs)
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
                    JsonValueKind.Object => this.AsObject().GetHashCode(),
                        JsonValueKind.Array => this.AsArray().GetHashCode(),
                        JsonValueKind.Number => this.AsNumber.GetHashCode(),
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
    
    
                if (this.numberBacking is double numberBacking)
            {
                writer.WriteNumberValue(numberBacking);
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
                        JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber.Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

        /// <inheritdoc/>
        public bool Equals(ContainsEntity other)
        {
            JsonValueKind valueKind = this.ValueKind;

            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                                JsonValueKind.Object => this.AsObject().Equals(other.AsObject()),
                        JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber.Equals(other.AsNumber),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

    
    
        /// <inheritdoc/>
        public T As<T>()
            where T : struct, IJsonValue
        {
            return this.As<ContainsEntity, T>();
        }


    
        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext validationContext, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }
        
        

    
    
    
                result = Corvus.Json.Validate.ValidateConst(this, result, level, __CorvusConstValue);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

    
    
        
    
    
    
    
    
    
    

                return result;
        }

    
    
            /// <summary>
        /// Gets the value as a <see cref="JsonNumber"/>.
        /// </summary>
        private JsonNumber AsNumber
        {
            get
            {
                if (this.numberBacking is double numberBacking)
                {
                    return new JsonNumber(numberBacking);
                }

                return new JsonNumber(this.jsonElementBacking);
            }
        }
    
    
    
    
    
    
    
    
    
    
    
            

            

            

            

    
    
    
    
    
    
    }
    

    
    }
    }
    