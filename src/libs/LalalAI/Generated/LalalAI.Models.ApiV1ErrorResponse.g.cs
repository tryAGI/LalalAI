
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiV1ErrorResponse
    {
        /// <summary>
        /// Error message.<br/>
        /// Example: Idempotency key has already been used.
        /// </summary>
        /// <example>Idempotency key has already been used.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Error code.<br/>
        /// Example: idempotency_key_used
        /// </summary>
        /// <example>idempotency_key_used</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1ErrorResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Error message.<br/>
        /// Example: Idempotency key has already been used.
        /// </param>
        /// <param name="code">
        /// Error code.<br/>
        /// Example: idempotency_key_used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiV1ErrorResponse(
            string detail,
            string code)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1ErrorResponse" /> class.
        /// </summary>
        public ApiV1ErrorResponse()
        {
        }
    }
}