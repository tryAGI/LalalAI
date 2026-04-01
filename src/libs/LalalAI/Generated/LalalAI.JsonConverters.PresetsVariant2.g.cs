#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public class PresetsVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.PresetsVariant2>
    {
        /// <inheritdoc />
        public override global::LalalAI.PresetsVariant2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1CancelledResultPresetsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1CancelledResultPresetsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CheckV1CancelledResultPresetsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LalalAI.DemuserSplitterPresetsV1? demuser = default;
            if (discriminator?.Label == global::LalalAI.CheckV1CancelledResultPresetsDiscriminatorLabel.Demuser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.DemuserSplitterPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.DemuserSplitterPresetsV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.DemuserSplitterPresetsV1)}");
                demuser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.VoiceCleanPresetsV1? voiceClean = default;
            if (discriminator?.Label == global::LalalAI.CheckV1CancelledResultPresetsDiscriminatorLabel.VoiceClean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.VoiceCleanPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.VoiceCleanPresetsV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.VoiceCleanPresetsV1)}");
                voiceClean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.StemSeparatorSplitterPresetsV1? stemSeparator = default;
            if (discriminator?.Label == global::LalalAI.CheckV1CancelledResultPresetsDiscriminatorLabel.StemSeparator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.StemSeparatorSplitterPresetsV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.StemSeparatorSplitterPresetsV1)}");
                stemSeparator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.MultistemSplitterPresetsV1? multistem = default;
            if (discriminator?.Label == global::LalalAI.CheckV1CancelledResultPresetsDiscriminatorLabel.Multistem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.MultistemSplitterPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.MultistemSplitterPresetsV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.MultistemSplitterPresetsV1)}");
                multistem = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LalalAI.PresetsVariant2(
                discriminator?.Label,
                demuser,

                voiceClean,

                stemSeparator,

                multistem
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.PresetsVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDemuser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.DemuserSplitterPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.DemuserSplitterPresetsV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.DemuserSplitterPresetsV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Demuser!, typeInfo);
            }
            else if (value.IsVoiceClean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.VoiceCleanPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.VoiceCleanPresetsV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.VoiceCleanPresetsV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceClean!, typeInfo);
            }
            else if (value.IsStemSeparator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.StemSeparatorSplitterPresetsV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.StemSeparatorSplitterPresetsV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StemSeparator!, typeInfo);
            }
            else if (value.IsMultistem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.MultistemSplitterPresetsV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.MultistemSplitterPresetsV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.MultistemSplitterPresetsV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Multistem!, typeInfo);
            }
        }
    }
}