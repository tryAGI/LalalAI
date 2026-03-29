
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// Unique uuid4 key to ensure idempotent requests.<br/>
    /// Prevents duplicate task execution with the same parameters.<br/>
    /// Can be reused until the task starts. Once processing begins, reusing this key will return an error.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class MultistemSplitParametersIdempotencyKey
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}