
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommonErrorResponse
    {
        /// <summary>
        /// Error details<br/>
        /// Example: {"detail":[{"loc":["body","split_input","source_id"],"msg":"Field required","type":"missing"},{"loc":["body","split_input","presets"],"msg":"Field required","type":"missing"}]}
        /// </summary>
        /// <example>{"detail":[{"loc":["body","split_input","source_id"],"msg":"Field required","type":"missing"},{"loc":["body","split_input","presets"],"msg":"Field required","type":"missing"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.IList<object>> Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonErrorResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Error details<br/>
        /// Example: {"detail":[{"loc":["body","split_input","source_id"],"msg":"Field required","type":"missing"},{"loc":["body","split_input","presets"],"msg":"Field required","type":"missing"}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommonErrorResponse(
            global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.IList<object>> detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonErrorResponse" /> class.
        /// </summary>
        public CommonErrorResponse()
        {
        }
    }
}