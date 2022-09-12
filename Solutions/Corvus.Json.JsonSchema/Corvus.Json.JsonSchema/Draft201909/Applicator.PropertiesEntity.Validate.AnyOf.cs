//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using Corvus.Json;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Applicator
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PropertiesEntity
    {
        private ValidationContext ValidateAnyOf(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (level > ValidationLevel.Basic)
            {
                result = result.PushValidationLocationProperty("anyOf");
            }

            bool foundValid = false;
            if (level > ValidationLevel.Basic)
            {
                result = result.PushValidationLocationArrayIndex(0);
            }

            ValidationContext anyOfResult0 = this.As<Corvus.Json.JsonSchema.Draft201909.Schema>().Validate(validationContext.CreateChildContext(), level);
            if (anyOfResult0.IsValid)
            {
                result = result.MergeChildContext(anyOfResult0, level >= ValidationLevel.Detailed);
                if (level == ValidationLevel.Flag)
                {
                    return result;
                }
                else
                {
                    foundValid = true;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, anyOfResult0);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, anyOfResult0);
                }
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // Index
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PushValidationLocationArrayIndex(1);
            }

            ValidationContext anyOfResult1 = this.As<Corvus.Json.JsonSchema.Draft201909.Applicator.SchemaArray>().Validate(validationContext.CreateChildContext(), level);
            if (anyOfResult1.IsValid)
            {
                result = result.MergeChildContext(anyOfResult1, level >= ValidationLevel.Detailed);
                if (level == ValidationLevel.Flag)
                {
                    return result;
                }
                else
                {
                    foundValid = true;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, anyOfResult1);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, anyOfResult1);
                }
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // Index
            }

            if (foundValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: true, "Validation 10.2.1.2. anyOf - validated against the anyOf schema.");
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.2. anyOf - failed to validate against the anyOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.2. anyOf - failed to validate against the anyOf schema.");
                }
                else
                {
                    result = result.WithResult(isValid: false);
                }
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // anyOf
            }

            return result;
        }
    }
}