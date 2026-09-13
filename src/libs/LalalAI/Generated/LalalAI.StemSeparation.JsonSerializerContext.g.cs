
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace LalalAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ApiV1ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.CommonErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfStringObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.InternalErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant2), TypeInfoPropertyName = "PresetsVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.DemuserSplitterPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoiceCleanPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitterPresetsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant22), TypeInfoPropertyName = "PresetsVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant23), TypeInfoPropertyName = "PresetsVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant24), TypeInfoPropertyName = "PresetsVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SplitterType), TypeInfoPropertyName = "SplitterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.EncoderFormat), TypeInfoPropertyName = "EncoderFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ExtractionLevel), TypeInfoPropertyName = "ExtractionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::LalalAI.MultistemSplitterPresetsV1StemListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem), TypeInfoPropertyName = "MultistemSplitterPresetsV1StemListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem), TypeInfoPropertyName = "StemSeparatorSplitterPresetsV1Stem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.DemuserSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.VoiceCleanSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>), TypeInfoPropertyName = "AnyOfApiV1ErrorResponseCommonErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.IList<object>>?), TypeInfoPropertyName = "NullableAnyOfStringObjectIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant2?), TypeInfoPropertyName = "NullablePresetsVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant22?), TypeInfoPropertyName = "NullablePresetsVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant23?), TypeInfoPropertyName = "NullablePresetsVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.PresetsVariant24?), TypeInfoPropertyName = "NullablePresetsVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.SplitterType?), TypeInfoPropertyName = "NullableSplitterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.EncoderFormat?), TypeInfoPropertyName = "NullableEncoderFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.ExtractionLevel?), TypeInfoPropertyName = "NullableExtractionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem?), TypeInfoPropertyName = "NullableMultistemSplitterPresetsV1StemListItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem?), TypeInfoPropertyName = "NullableStemSeparatorSplitterPresetsV1Stem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>?), TypeInfoPropertyName = "NullableAnyOfApiV1ErrorResponseCommonErrorResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::LalalAI.AnyOf<string, object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::LalalAI.MultistemSplitterPresetsV1StemListItem>))]
    internal sealed partial class StemSeparationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StemSeparationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StemSeparationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StemSeparationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::LalalAI.JsonConverters.PresetsVariant2JsonConverter());
            options.Converters.Add(new global::LalalAI.JsonConverters.PresetsVariant22JsonConverter());
            options.Converters.Add(new global::LalalAI.JsonConverters.PresetsVariant23JsonConverter());
            options.Converters.Add(new global::LalalAI.JsonConverters.PresetsVariant24JsonConverter());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.AnyOfJsonConverter<global::LalalAI.ApiV1ErrorResponse, global::LalalAI.CommonErrorResponse>());
            options.Converters.Add(new global::LalalAI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::LalalAI.EncoderFormat)

                    || typeToConvert == typeof(global::LalalAI.EncoderFormat?)

                    || typeToConvert == typeof(global::LalalAI.ExtractionLevel)

                    || typeToConvert == typeof(global::LalalAI.ExtractionLevel?)

                    || typeToConvert == typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem)

                    || typeToConvert == typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem?)

                    || typeToConvert == typeof(global::LalalAI.SplitterType)

                    || typeToConvert == typeof(global::LalalAI.SplitterType?)

                    || typeToConvert == typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem)

                    || typeToConvert == typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::LalalAI.EncoderFormat))
                {
                    return new global::LalalAI.JsonConverters.EncoderFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.EncoderFormat?))
                {
                    return new global::LalalAI.JsonConverters.EncoderFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.ExtractionLevel))
                {
                    return new global::LalalAI.JsonConverters.ExtractionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.ExtractionLevel?))
                {
                    return new global::LalalAI.JsonConverters.ExtractionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem))
                {
                    return new global::LalalAI.JsonConverters.MultistemSplitterPresetsV1StemListItemJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.MultistemSplitterPresetsV1StemListItem?))
                {
                    return new global::LalalAI.JsonConverters.MultistemSplitterPresetsV1StemListItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.SplitterType))
                {
                    return new global::LalalAI.JsonConverters.SplitterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.SplitterType?))
                {
                    return new global::LalalAI.JsonConverters.SplitterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem))
                {
                    return new global::LalalAI.JsonConverters.StemSeparatorSplitterPresetsV1StemJsonConverter();
                }

                if (typeToConvert == typeof(global::LalalAI.StemSeparatorSplitterPresetsV1Stem?))
                {
                    return new global::LalalAI.JsonConverters.StemSeparatorSplitterPresetsV1StemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new StemSeparationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}