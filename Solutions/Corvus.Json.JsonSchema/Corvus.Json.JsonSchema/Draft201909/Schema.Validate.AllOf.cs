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

namespace Corvus.Json.JsonSchema.Draft201909;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Schema
{
    private ValidationContext ValidateAllOf(in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationProperty("allOf");
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationArrayIndex(0);
        }

        ValidationContext allOfResult0 = this.As<Corvus.Json.JsonSchema.Draft201909.Core>().Validate(validationContext.CreateChildContext(), level);
        if (!allOfResult0.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult0, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult0, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult0, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult0, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // Index
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationArrayIndex(1);
        }

        ValidationContext allOfResult1 = this.As<Corvus.Json.JsonSchema.Draft201909.Applicator>().Validate(validationContext.CreateChildContext(), level);
        if (!allOfResult1.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult1, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult1, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult1, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult1, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // Index
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationArrayIndex(2);
        }

        ValidationContext allOfResult2 = this.As<Corvus.Json.JsonSchema.Draft201909.Validation>().Validate(validationContext.CreateChildContext(), level);
        if (!allOfResult2.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult2, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult2, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult2, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult2, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // Index
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationArrayIndex(3);
        }

        ValidationContext allOfResult3 = this.As<Corvus.Json.JsonSchema.Draft201909.MetaData>().Validate(validationContext.CreateChildContext(), level);
        if (!allOfResult3.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult3, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult3, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult3, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult3, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // Index
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationArrayIndex(4);
        }

        ValidationContext allOfResult4 = this.As<Corvus.Json.JsonSchema.Draft201909.Format>().Validate(validationContext.CreateChildContext(), level);
        if (!allOfResult4.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult4, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult4, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult4, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult4, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // Index
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PushValidationLocationArrayIndex(5);
        }

        ValidationContext allOfResult5 = this.As<Corvus.Json.JsonSchema.Draft201909.Content>().Validate(validationContext.CreateChildContext(), level);
        if (!allOfResult5.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult5, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult5, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult5, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult5, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // Index
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // allOf
        }

        return result;
    }
}