#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public class Presets4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.Presets4>
    {
        /// <inheritdoc />
        public override global::LalalAI.Presets4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("accent")) __score0++;
            if (__jsonProps.Contains("dereverb_enabled")) __score0++;
            if (__jsonProps.Contains("encoder_format")) __score0++;
            if (__jsonProps.Contains("tonality_reference")) __score0++;
            if (__jsonProps.Contains("voice_pack_id")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::LalalAI.VoiceChangePresetsV1? voiceChangePresetsV1 = default;
            global::LalalAI.PresetsVariant24? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.VoiceChangePresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.VoiceChangePresetsV1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.VoiceChangePresetsV1).Name}");
                        voiceChangePresetsV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.PresetsVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.PresetsVariant24> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.PresetsVariant24).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (voiceChangePresetsV1 == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.VoiceChangePresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.VoiceChangePresetsV1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.VoiceChangePresetsV1).Name}");
                    voiceChangePresetsV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.PresetsVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.PresetsVariant24> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.PresetsVariant24).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::LalalAI.Presets4(
                voiceChangePresetsV1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.Presets4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVoiceChangePresetsV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.VoiceChangePresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.VoiceChangePresetsV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.VoiceChangePresetsV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceChangePresetsV1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.PresetsVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.PresetsVariant24> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.PresetsVariant24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!.Value, typeInfo);
            }
        }
    }
}