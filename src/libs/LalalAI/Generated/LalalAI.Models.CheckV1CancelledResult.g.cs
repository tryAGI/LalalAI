
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckV1CancelledResult
    {
        /// <summary>
        /// ID of the source file associated with the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LalalAI.JsonConverters.PresetsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LalalAI.Presets Presets { get; set; }

        /// <summary>
        /// Default Value: cancelled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1CancelledResult" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file associated with the task
        /// </param>
        /// <param name="presets"></param>
        /// <param name="status">
        /// Default Value: cancelled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckV1CancelledResult(
            string sourceId,
            global::LalalAI.Presets presets,
            string? status)
        {
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.Presets = presets;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1CancelledResult" /> class.
        /// </summary>
        public CheckV1CancelledResult()
        {
        }
    }
}