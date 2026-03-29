#nullable enable

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExtractionLevelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.ExtractionLevel>
    {
        /// <inheritdoc />
        public override global::LalalAI.ExtractionLevel Read(
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
                        return global::LalalAI.ExtractionLevelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::LalalAI.ExtractionLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::LalalAI.ExtractionLevel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.ExtractionLevel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::LalalAI.ExtractionLevelExtensions.ToValueString(value));
        }
    }
}
