
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckV1Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TaskIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1Request" /> class.
        /// </summary>
        /// <param name="taskIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckV1Request(
            global::System.Collections.Generic.IList<string> taskIds)
        {
            this.TaskIds = taskIds ?? throw new global::System.ArgumentNullException(nameof(taskIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckV1Request" /> class.
        /// </summary>
        public CheckV1Request()
        {
        }
    }
}