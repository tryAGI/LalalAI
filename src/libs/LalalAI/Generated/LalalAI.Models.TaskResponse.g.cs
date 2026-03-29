
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskResponse
    {
        /// <summary>
        /// ID of the created task.<br/>
        /// Example: e1fc1d8f-502e-4de0-bf3b-b30543d11c77
        /// </summary>
        /// <example>e1fc1d8f-502e-4de0-bf3b-b30543d11c77</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// ID of the created task.<br/>
        /// Example: e1fc1d8f-502e-4de0-bf3b-b30543d11c77
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskResponse(
            string taskId)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        public TaskResponse()
        {
        }
    }
}