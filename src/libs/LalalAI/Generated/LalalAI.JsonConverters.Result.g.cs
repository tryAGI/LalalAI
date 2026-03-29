#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace LalalAI.JsonConverters
{
    /// <inheritdoc />
    public class ResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::LalalAI.Result>
    {
        /// <inheritdoc />
        public override global::LalalAI.Result Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1ResponseResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1ResponseResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CheckV1ResponseResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::LalalAI.CheckV1ProgressResult? progress = default;
            if (discriminator?.Status == global::LalalAI.CheckV1ResponseResultDiscriminatorStatus.Progress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1ProgressResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1ProgressResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CheckV1ProgressResult)}");
                progress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.CheckV1ErrorResult? error1 = default;
            if (discriminator?.Status == global::LalalAI.CheckV1ResponseResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1ErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1ErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CheckV1ErrorResult)}");
                error1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.CheckV1CancelledResult? cancelled = default;
            if (discriminator?.Status == global::LalalAI.CheckV1ResponseResultDiscriminatorStatus.Cancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1CancelledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1CancelledResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CheckV1CancelledResult)}");
                cancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.CheckV1SuccessResult? success = default;
            if (discriminator?.Status == global::LalalAI.CheckV1ResponseResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1SuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1SuccessResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.CheckV1SuccessResult)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::LalalAI.ErrorResult? error2 = default;
            if (discriminator?.Status == global::LalalAI.CheckV1ResponseResultDiscriminatorStatus.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.ErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.ErrorResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::LalalAI.ErrorResult)}");
                error2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::LalalAI.Result(
                discriminator?.Status,
                progress,

                error1,

                cancelled,

                success,

                error2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::LalalAI.Result value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1ProgressResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1ProgressResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.CheckV1ProgressResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Progress, typeInfo);
            }
            else if (value.IsError1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1ErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1ErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.CheckV1ErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error1, typeInfo);
            }
            else if (value.IsCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1CancelledResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1CancelledResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.CheckV1CancelledResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cancelled, typeInfo);
            }
            else if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.CheckV1SuccessResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.CheckV1SuccessResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.CheckV1SuccessResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeInfo);
            }
            else if (value.IsError2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::LalalAI.ErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::LalalAI.ErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::LalalAI.ErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error2, typeInfo);
            }
        }
    }
}