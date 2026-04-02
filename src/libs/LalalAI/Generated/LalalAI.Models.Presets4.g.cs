#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Presets4 : global::System.IEquatable<Presets4>
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
        public global::LalalAI.PresetsVariant24? PresetsVariant24 { get; init; }
#else
        public global::LalalAI.PresetsVariant24? PresetsVariant24 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PresetsVariant24))]
#endif
        public bool IsPresetsVariant24 => PresetsVariant24 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Presets4(global::LalalAI.VoiceChangePresetsV1 value) => new Presets4((global::LalalAI.VoiceChangePresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.VoiceChangePresetsV1?(Presets4 @this) => @this.VoiceChangePresetsV1;

        /// <summary>
        /// 
        /// </summary>
        public Presets4(global::LalalAI.VoiceChangePresetsV1? value)
        {
            VoiceChangePresetsV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Presets4(global::LalalAI.PresetsVariant24 value) => new Presets4((global::LalalAI.PresetsVariant24?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.PresetsVariant24?(Presets4 @this) => @this.PresetsVariant24;

        /// <summary>
        /// 
        /// </summary>
        public Presets4(global::LalalAI.PresetsVariant24? value)
        {
            PresetsVariant24 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Presets4(
            global::LalalAI.VoiceChangePresetsV1? voiceChangePresetsV1,
            global::LalalAI.PresetsVariant24? presetsVariant24
            )
        {
            VoiceChangePresetsV1 = voiceChangePresetsV1;
            PresetsVariant24 = presetsVariant24;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PresetsVariant24 as object ??
            VoiceChangePresetsV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VoiceChangePresetsV1?.ToString() ??
            PresetsVariant24?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVoiceChangePresetsV1 && !IsPresetsVariant24 || !IsVoiceChangePresetsV1 && IsPresetsVariant24;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.VoiceChangePresetsV1?, TResult>? voiceChangePresetsV1 = null,
            global::System.Func<global::LalalAI.PresetsVariant24?, TResult>? presetsVariant24 = null,
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
            else if (IsPresetsVariant24 && presetsVariant24 != null)
            {
                return presetsVariant24(PresetsVariant24!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.VoiceChangePresetsV1?>? voiceChangePresetsV1 = null,
            global::System.Action<global::LalalAI.PresetsVariant24?>? presetsVariant24 = null,
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
            else if (IsPresetsVariant24)
            {
                presetsVariant24?.Invoke(PresetsVariant24!);
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
                PresetsVariant24,
                typeof(global::LalalAI.PresetsVariant24),
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
        public bool Equals(Presets4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.VoiceChangePresetsV1?>.Default.Equals(VoiceChangePresetsV1, other.VoiceChangePresetsV1) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.PresetsVariant24?>.Default.Equals(PresetsVariant24, other.PresetsVariant24) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Presets4 obj1, Presets4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Presets4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Presets4 obj1, Presets4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Presets4 o && Equals(o);
        }
    }
}
