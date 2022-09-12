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

namespace Corvus.Json.Patch.Model;
public readonly partial struct JsonPatchDocument
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PatchOperation
    {
        private ValidationContext ValidateOneOf(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationProperty("oneOf");
            }

            int oneOfCount = 0;
            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationArrayIndex(0);
            }

            ValidationContext oneOfResult0 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.AddEntity>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult0.IsValid)
            {
                result = result.MergeChildContext(oneOfResult0, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult0);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult0);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult0);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // Index
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationArrayIndex(1);
            }

            ValidationContext oneOfResult1 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.RemoveEntity>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult1.IsValid)
            {
                result = result.MergeChildContext(oneOfResult1, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult1);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult1);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult1);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // Index
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationArrayIndex(2);
            }

            ValidationContext oneOfResult2 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.ReplaceEntity>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult2.IsValid)
            {
                result = result.MergeChildContext(oneOfResult2, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult2);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult2);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult2);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // Index
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationArrayIndex(3);
            }

            ValidationContext oneOfResult3 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.Move>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult3.IsValid)
            {
                result = result.MergeChildContext(oneOfResult3, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult3);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult3);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult3);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // Index
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationArrayIndex(4);
            }

            ValidationContext oneOfResult4 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.Copy>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult4.IsValid)
            {
                result = result.MergeChildContext(oneOfResult4, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult4);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult4);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult4);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // Index
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PushValidationLocationArrayIndex(5);
            }

            ValidationContext oneOfResult5 = this.As<Corvus.Json.Patch.Model.JsonPatchDocument.Test>().Validate(validationContext.CreateChildContext(), level);
            if (oneOfResult5.IsValid)
            {
                result = result.MergeChildContext(oneOfResult5, level >= ValidationLevel.Detailed);
                oneOfCount += 1;
                if (oneOfCount > 1 && level == ValidationLevel.Flag)
                {
                    result = result.WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult5);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult5);
                }
                else
                {
                    result = result.MergeResults(result.IsValid, level, oneOfResult5);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // Index
            }

            if (oneOfCount == 1)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: true, "Validation 10.2.1.3. onef - validated against the oneOf schema.");
                }
            }
            else if (oneOfCount == 0)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - failed to validate against any of the oneOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - failed to validate against any of the oneOf schema.");
                }
                else
                {
                    result = result.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - validated against more than one of the oneOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.WithResult(isValid: false, "Validation 10.2.1.3. oneOf - failed to validate against more than one of the oneOf schema.");
                }
                else
                {
                    result = result.WithResult(isValid: false);
                }
            }

            if (level > ValidationLevel.Flag)
            {
                result = result.PopLocation(); // oneOf
            }

            return result;
        }
    }
}