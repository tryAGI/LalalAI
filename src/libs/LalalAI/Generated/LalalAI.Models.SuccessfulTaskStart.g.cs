
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuccessfulTaskStart
    {
        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// ID of the created split task.<br/>
        /// Example: e1fc1d8f-502e-4de0-bf3b-b30543d11c77
        /// </summary>
        /// <example>e1fc1d8f-502e-4de0-bf3b-b30543d11c77</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

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
        /// Initializes a new instance of the <see cref="SuccessfulTaskStart" /> class.
        /// </summary>
        /// <param name="taskId">
        /// ID of the created split task.<br/>
        /// Example: e1fc1d8f-502e-4de0-bf3b-b30543d11c77
        /// </param>
        /// <param name="sourceId">
        /// Source file ID.<br/>
        /// Example: a1b2c3d4-5e6f-7g8h-9i0j-k1l2m3n4o5p6
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuccessfulTaskStart(
            string taskId,
            string sourceId,
            string? status)
        {
            this.Status = status;
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessfulTaskStart" /> class.
        /// </summary>
        public SuccessfulTaskStart()
        {
        }
    }
}