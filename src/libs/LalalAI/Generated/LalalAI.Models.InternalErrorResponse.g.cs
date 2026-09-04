
#nullable enable

namespace LalalAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternalErrorResponse
    {
        /// <summary>
        /// Something went wrong on our side. The failure is recorded in our logs; nothing about the request needs to be fixed.<br/>
        /// Example: Internal server error
        /// </summary>
        /// <example>Internal server error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalErrorResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Something went wrong on our side. The failure is recorded in our logs; nothing about the request needs to be fixed.<br/>
        /// Example: Internal server error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalErrorResponse(
            string detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalErrorResponse" /> class.
        /// </summary>
        public InternalErrorResponse()
        {
        }

    }
}