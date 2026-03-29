#nullable enable

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class StemSeparatorSplitterPresetsV1StemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.StemSeparatorSplitterPresetsV1Stem>
    {
        /// <inheritdoc />
        public override global::LalalAI.StemSeparatorSplitterPresetsV1Stem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::LalalAI.StemSeparatorSplitterPresetsV1StemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LalalAI.StemSeparatorSplitterPresetsV1Stem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LalalAI.StemSeparatorSplitterPresetsV1Stem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.StemSeparatorSplitterPresetsV1Stem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LalalAI.StemSeparatorSplitterPresetsV1StemExtensions.ToValueString(value));
        }
    }
}
