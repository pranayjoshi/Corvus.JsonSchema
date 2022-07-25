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

namespace Corvus.Json.JsonSchema.Draft7;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct TypeEntity
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity"/>.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity AsSimpleTypesEntity
        {
            get
            {
                return (Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity"/>.
        /// </summary>
        public bool IsSimpleTypesEntity
        {
            get
            {
                return ((Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsSimpleTypesEntity(out Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity result)
        {
            result = (Corvus.Json.JsonSchema.Draft7.Validation.SimpleTypesEntity)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray"/>.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray AsSimpleTypesEntityArray
        {
            get
            {
                return (Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray"/>.
        /// </summary>
        public bool IsSimpleTypesEntityArray
        {
            get
            {
                return ((Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsSimpleTypesEntityArray(out Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray result)
        {
            result = (Corvus.Json.JsonSchema.Draft7.Validation.TypeEntity.SimpleTypesEntityArray)this;
            return result.IsValid();
        }
    }
}