
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FailedTaskStart
    {
        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Error message describing why the task failed to start.<br/>
        /// Example: Idempotency key has already been used.
        /// </summary>
        /// <example>Idempotency key has already been used.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Error code.<br/>
        /// Example: idempotency_key_used
        /// </summary>
        /// <example>idempotency_key_used</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.TaskStartErrorCodes?, global::LalalAI.LicenseErrorCodes?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LalalAI.AnyOf<global::LalalAI.TaskStartErrorCodes?, global::LalalAI.LicenseErrorCodes?> Code { get; set; }

        /// <summary>
        /// Source file ID.<br/>
        /// Example: a1b2c3d4-5e6f-7g8h-9i0j-k1l2m3n4o5p6
        /// </summary>
        /// <example>a1b2c3d4-5e6f-7g8h-9i0j-k1l2m3n4o5p6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedTaskStart" /> class.
        /// </summary>
        /// <param name="error">
        /// Error message describing why the task failed to start.<br/>
        /// Example: Idempotency key has already been used.
        /// </param>
        /// <param name="code">
        /// Error code.<br/>
        /// Example: idempotency_key_used
        /// </param>
        /// <param name="sourceId">
        /// Source file ID.<br/>
        /// Example: a1b2c3d4-5e6f-7g8h-9i0j-k1l2m3n4o5p6
        /// </param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FailedTaskStart(
            string error,
            global::LalalAI.AnyOf<global::LalalAI.TaskStartErrorCodes?, global::LalalAI.LicenseErrorCodes?> code,
            string sourceId,
            string? status)
        {
            this.Status = status;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Code = code;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedTaskStart" /> class.
        /// </summary>
        public FailedTaskStart()
        {
        }
    }
}