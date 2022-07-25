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
public readonly partial struct Applicator
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct PropertiesEntity
    {
        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Schema"/>.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft7.Schema AsSchema
        {
            get
            {
                return (Corvus.Json.JsonSchema.Draft7.Schema)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.JsonSchema.Draft7.Schema"/>.
        /// </summary>
        public bool IsSchema
        {
            get
            {
                return ((Corvus.Json.JsonSchema.Draft7.Schema)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Schema"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsSchema(out Corvus.Json.JsonSchema.Draft7.Schema result)
        {
            result = (Corvus.Json.JsonSchema.Draft7.Schema)this;
            return result.IsValid();
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray"/>.
        /// </summary>
        public Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray AsSchemaArray
        {
            get
            {
                return (Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray)this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref = "Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray"/>.
        /// </summary>
        public bool IsSchemaArray
        {
            get
            {
                return ((Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray)this).IsValid();
            }
        }

        /// <summary>
        /// Gets the value as a <see cref = "Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray"/>.
        /// </summary>
        /// <param name = "result">The result of the conversion.</param>
        /// <returns><c>True</c> if the conversion was valid.</returns>
        public bool TryGetAsSchemaArray(out Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray result)
        {
            result = (Corvus.Json.JsonSchema.Draft7.Applicator.SchemaArray)this;
            return result.IsValid();
        }
    }
}