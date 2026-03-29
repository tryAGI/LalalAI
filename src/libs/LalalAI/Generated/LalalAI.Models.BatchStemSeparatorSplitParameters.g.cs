
#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchStemSeparatorSplitParameters
    {
        /// <summary>
        /// List of split parameters to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LalalAI.StemSeparatorSplitParameters> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStemSeparatorSplitParameters" /> class.
        /// </summary>
        /// <param name="items">
        /// List of split parameters to process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchStemSeparatorSplitParameters(
            global::System.Collections.Generic.IList<global::LalalAI.StemSeparatorSplitParameters> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchStemSeparatorSplitParameters" /> class.
        /// </summary>
        public BatchStemSeparatorSplitParameters()
        {
        }
    }
}