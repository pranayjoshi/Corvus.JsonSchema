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
    public readonly partial struct ReplaceEntity
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity"/>.
        /// </summary>
        public Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity AsPatchOperationCommonEntity
        {
            get
            {
                return (Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity"/>.
        /// </summary>
        public bool IsPatchOperationCommonEntity
        {
            get
            {
                return ((Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsPatchOperationCommonEntity(out Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity result)
        {
            result = (Corvus.Json.Patch.Model.JsonPatchDocument.PatchOperationCommonEntity)this;
            return result.IsValid();
        }
    }
}