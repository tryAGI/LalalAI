#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Presets : global::System.IEquatable<Presets>
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
        public global::LalalAI.PresetsVariant2? Value2 { get; init; }
#else
        public global::LalalAI.PresetsVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Presets(global::LalalAI.VoiceChangePresetsV1 value) => new Presets((global::LalalAI.VoiceChangePresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.VoiceChangePresetsV1?(Presets @this) => @this.VoiceChangePresetsV1;

        /// <summary>
        /// 
        /// </summary>
        public Presets(global::LalalAI.VoiceChangePresetsV1? value)
        {
            VoiceChangePresetsV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Presets(global::LalalAI.PresetsVariant2 value) => new Presets((global::LalalAI.PresetsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.PresetsVariant2?(Presets @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Presets(global::LalalAI.PresetsVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Presets(
            global::LalalAI.VoiceChangePresetsV1? voiceChangePresetsV1,
            global::LalalAI.PresetsVariant2? value2
            )
        {
            VoiceChangePresetsV1 = voiceChangePresetsV1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            VoiceChangePresetsV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VoiceChangePresetsV1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVoiceChangePresetsV1 && !IsValue2 || !IsVoiceChangePresetsV1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.VoiceChangePresetsV1?, TResult>? voiceChangePresetsV1 = null,
            global::System.Func<global::LalalAI.PresetsVariant2?, TResult>? value2 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.VoiceChangePresetsV1?>? voiceChangePresetsV1 = null,
            global::System.Action<global::LalalAI.PresetsVariant2?>? value2 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
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
                Value2,
                typeof(global::LalalAI.PresetsVariant2),
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
        public bool Equals(Presets other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.VoiceChangePresetsV1?>.Default.Equals(VoiceChangePresetsV1, other.VoiceChangePresetsV1) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.PresetsVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Presets obj1, Presets obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Presets>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Presets obj1, Presets obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Presets o && Equals(o);
        }
    }
}
