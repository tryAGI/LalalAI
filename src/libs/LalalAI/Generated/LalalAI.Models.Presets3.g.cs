#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Presets3 : global::System.IEquatable<Presets3>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.VoiceChangePresetsV1? VoiceChangePresetsV1 { get; init; }
#else
        public global::LalalAI.VoiceChangePresetsV1? VoiceChangePresetsV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceChangePresetsV1))]
#endif
        public bool IsVoiceChangePresetsV1 => VoiceChangePresetsV1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.PresetsVariant23? PresetsVariant23 { get; init; }
#else
        public global::LalalAI.PresetsVariant23? PresetsVariant23 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PresetsVariant23))]
#endif
        public bool IsPresetsVariant23 => PresetsVariant23 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Presets3(global::LalalAI.VoiceChangePresetsV1 value) => new Presets3((global::LalalAI.VoiceChangePresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.VoiceChangePresetsV1?(Presets3 @this) => @this.VoiceChangePresetsV1;

        /// <summary>
        /// 
        /// </summary>
        public Presets3(global::LalalAI.VoiceChangePresetsV1? value)
        {
            VoiceChangePresetsV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Presets3(global::LalalAI.PresetsVariant23 value) => new Presets3((global::LalalAI.PresetsVariant23?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.PresetsVariant23?(Presets3 @this) => @this.PresetsVariant23;

        /// <summary>
        /// 
        /// </summary>
        public Presets3(global::LalalAI.PresetsVariant23? value)
        {
            PresetsVariant23 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Presets3(
            global::LalalAI.VoiceChangePresetsV1? voiceChangePresetsV1,
            global::LalalAI.PresetsVariant23? presetsVariant23
            )
        {
            VoiceChangePresetsV1 = voiceChangePresetsV1;
            PresetsVariant23 = presetsVariant23;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PresetsVariant23 as object ??
            VoiceChangePresetsV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VoiceChangePresetsV1?.ToString() ??
            PresetsVariant23?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVoiceChangePresetsV1 && !IsPresetsVariant23 || !IsVoiceChangePresetsV1 && IsPresetsVariant23;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.VoiceChangePresetsV1?, TResult>? voiceChangePresetsV1 = null,
            global::System.Func<global::LalalAI.PresetsVariant23?, TResult>? presetsVariant23 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVoiceChangePresetsV1 && voiceChangePresetsV1 != null)
            {
                return voiceChangePresetsV1(VoiceChangePresetsV1!);
            }
            else if (IsPresetsVariant23 && presetsVariant23 != null)
            {
                return presetsVariant23(PresetsVariant23!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.VoiceChangePresetsV1?>? voiceChangePresetsV1 = null,
            global::System.Action<global::LalalAI.PresetsVariant23?>? presetsVariant23 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVoiceChangePresetsV1)
            {
                voiceChangePresetsV1?.Invoke(VoiceChangePresetsV1!);
            }
            else if (IsPresetsVariant23)
            {
                presetsVariant23?.Invoke(PresetsVariant23!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VoiceChangePresetsV1,
                typeof(global::LalalAI.VoiceChangePresetsV1),
                PresetsVariant23,
                typeof(global::LalalAI.PresetsVariant23),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Presets3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.VoiceChangePresetsV1?>.Default.Equals(VoiceChangePresetsV1, other.VoiceChangePresetsV1) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.PresetsVariant23?>.Default.Equals(PresetsVariant23, other.PresetsVariant23) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Presets3 obj1, Presets3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Presets3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Presets3 obj1, Presets3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Presets3 o && Equals(o);
        }
    }
}
