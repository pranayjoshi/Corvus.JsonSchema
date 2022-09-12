//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Text.Json;
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
{
    public readonly partial struct TypeEntity
    {
        /// <summary>
        /// A type generated from a JsonSchema specification.
        /// </summary>
        public readonly partial struct SimpleTypesArray
        {
            private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
            {
                ValidationContext result = validationContext;
                if (valueKind != JsonValueKind.Array)
                {
                    return result;
                }

                int arrayLength = 0;
                using JsonArrayEnumerator<Corvus.Json.JsonSchema.Draft202012.Validation.SimpleTypes> arrayEnumerator = this.EnumerateArray();
                while (arrayEnumerator.MoveNext())
                {
                    if (level > ValidationLevel.Flag)
                    {
                        result = result.PushValidationLocationArrayIndex(arrayLength);
                    }

                    using JsonArrayEnumerator<Corvus.Json.JsonSchema.Draft202012.Validation.SimpleTypes> innerEnumerator = this.EnumerateArray();
                    int innerIndex = -1;
                    while (innerIndex < arrayLength && innerEnumerator.MoveNext())
                    {
                        innerIndex++;
                    }

                    while (innerEnumerator.MoveNext())
                    {
                        if (innerEnumerator.Current.Equals(arrayEnumerator.Current))
                        {
                            if (level >= ValidationLevel.Detailed)
                            {
                                result = result.WithResult(isValid: false, $"6.4.3. uniqueItems - duplicate items were found at indices {arrayLength} and {innerIndex}.");
                            }
                            else if (level >= ValidationLevel.Basic)
                            {
                                result = result.WithResult(isValid: false, "6.4.3. uniqueItems - duplicate items were found.");
                            }
                            else
                            {
                                return result.WithResult(isValid: false);
                            }
                        }
                    }

                    result = arrayEnumerator.Current.Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    result = result.WithLocalItemIndex(arrayLength);
                    if (level > ValidationLevel.Flag)
                    {
                        result = result.PopLocation(); // array index
                    }

                    arrayLength++;
                }

                if (arrayLength < 1)
                {
                    if (level >= ValidationLevel.Detailed)
                    {
                        result = result.WithResult(isValid: false, $"6.4.2. minItems - {arrayLength} is less than the minimum number of items 1.");
                    }
                    else if (level >= ValidationLevel.Basic)
                    {
                        result = result.WithResult(isValid: false, "6.4.2. minItems - item count is less than the minimum number of items 1.");
                    }
                    else
                    {
                        return result.WithResult(isValid: false);
                    }
                }

                return result;
            }
        }
    }
}