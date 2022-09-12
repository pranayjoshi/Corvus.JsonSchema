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

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct RemoveEntity
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

            ValidationContext allOfResult0 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommon>().Validate(validationContext.CreateChildContext(), level);
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
                result = result.PopLocation(); // allOf
            }

            return result;
        }
    }
}