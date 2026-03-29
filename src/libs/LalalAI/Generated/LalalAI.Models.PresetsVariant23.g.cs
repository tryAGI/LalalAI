#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PresetsVariant23 : global::System.IEquatable<PresetsVariant23>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LalalAI.CheckV1ProgressResultPresetsDiscriminatorLabel? Label { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.DemuserSplitterPresetsV1? Demuser { get; init; }
#else
        public global::LalalAI.DemuserSplitterPresetsV1? Demuser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Demuser))]
#endif
        public bool IsDemuser => Demuser != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.VoiceCleanPresetsV1? VoiceClean { get; init; }
#else
        public global::LalalAI.VoiceCleanPresetsV1? VoiceClean { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceClean))]
#endif
        public bool IsVoiceClean => VoiceClean != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.StemSeparatorSplitterPresetsV1? StemSeparator { get; init; }
#else
        public global::LalalAI.StemSeparatorSplitterPresetsV1? StemSeparator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StemSeparator))]
#endif
        public bool IsStemSeparator => StemSeparator != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.MultistemSplitterPresetsV1? Multistem { get; init; }
#else
        public global::LalalAI.MultistemSplitterPresetsV1? Multistem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Multistem))]
#endif
        public bool IsMultistem => Multistem != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PresetsVariant23(global::LalalAI.DemuserSplitterPresetsV1 value) => new PresetsVariant23((global::LalalAI.DemuserSplitterPresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.DemuserSplitterPresetsV1?(PresetsVariant23 @this) => @this.Demuser;

        /// <summary>
        /// 
        /// </summary>
        public PresetsVariant23(global::LalalAI.DemuserSplitterPresetsV1? value)
        {
            Demuser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PresetsVariant23(global::LalalAI.VoiceCleanPresetsV1 value) => new PresetsVariant23((global::LalalAI.VoiceCleanPresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.VoiceCleanPresetsV1?(PresetsVariant23 @this) => @this.VoiceClean;

        /// <summary>
        /// 
        /// </summary>
        public PresetsVariant23(global::LalalAI.VoiceCleanPresetsV1? value)
        {
            VoiceClean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PresetsVariant23(global::LalalAI.StemSeparatorSplitterPresetsV1 value) => new PresetsVariant23((global::LalalAI.StemSeparatorSplitterPresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.StemSeparatorSplitterPresetsV1?(PresetsVariant23 @this) => @this.StemSeparator;

        /// <summary>
        /// 
        /// </summary>
        public PresetsVariant23(global::LalalAI.StemSeparatorSplitterPresetsV1? value)
        {
            StemSeparator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PresetsVariant23(global::LalalAI.MultistemSplitterPresetsV1 value) => new PresetsVariant23((global::LalalAI.MultistemSplitterPresetsV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.MultistemSplitterPresetsV1?(PresetsVariant23 @this) => @this.Multistem;

        /// <summary>
        /// 
        /// </summary>
        public PresetsVariant23(global::LalalAI.MultistemSplitterPresetsV1? value)
        {
            Multistem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PresetsVariant23(
            global::LalalAI.CheckV1ProgressResultPresetsDiscriminatorLabel? label,
            global::LalalAI.DemuserSplitterPresetsV1? demuser,
            global::LalalAI.VoiceCleanPresetsV1? voiceClean,
            global::LalalAI.StemSeparatorSplitterPresetsV1? stemSeparator,
            global::LalalAI.MultistemSplitterPresetsV1? multistem
            )
        {
            Label = label;

            Demuser = demuser;
            VoiceClean = voiceClean;
            StemSeparator = stemSeparator;
            Multistem = multistem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Multistem as object ??
            StemSeparator as object ??
            VoiceClean as object ??
            Demuser as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Demuser?.ToString() ??
            VoiceClean?.ToString() ??
            StemSeparator?.ToString() ??
            Multistem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDemuser && !IsVoiceClean && !IsStemSeparator && !IsMultistem || !IsDemuser && IsVoiceClean && !IsStemSeparator && !IsMultistem || !IsDemuser && !IsVoiceClean && IsStemSeparator && !IsMultistem || !IsDemuser && !IsVoiceClean && !IsStemSeparator && IsMultistem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.DemuserSplitterPresetsV1?, TResult>? demuser = null,
            global::System.Func<global::LalalAI.VoiceCleanPresetsV1?, TResult>? voiceClean = null,
            global::System.Func<global::LalalAI.StemSeparatorSplitterPresetsV1?, TResult>? stemSeparator = null,
            global::System.Func<global::LalalAI.MultistemSplitterPresetsV1?, TResult>? multistem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDemuser && demuser != null)
            {
                return demuser(Demuser!);
            }
            else if (IsVoiceClean && voiceClean != null)
            {
                return voiceClean(VoiceClean!);
            }
            else if (IsStemSeparator && stemSeparator != null)
            {
                return stemSeparator(StemSeparator!);
            }
            else if (IsMultistem && multistem != null)
            {
                return multistem(Multistem!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.DemuserSplitterPresetsV1?>? demuser = null,
            global::System.Action<global::LalalAI.VoiceCleanPresetsV1?>? voiceClean = null,
            global::System.Action<global::LalalAI.StemSeparatorSplitterPresetsV1?>? stemSeparator = null,
            global::System.Action<global::LalalAI.MultistemSplitterPresetsV1?>? multistem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDemuser)
            {
                demuser?.Invoke(Demuser!);
            }
            else if (IsVoiceClean)
            {
                voiceClean?.Invoke(VoiceClean!);
            }
            else if (IsStemSeparator)
            {
                stemSeparator?.Invoke(StemSeparator!);
            }
            else if (IsMultistem)
            {
                multistem?.Invoke(Multistem!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Demuser,
                typeof(global::LalalAI.DemuserSplitterPresetsV1),
                VoiceClean,
                typeof(global::LalalAI.VoiceCleanPresetsV1),
                StemSeparator,
                typeof(global::LalalAI.StemSeparatorSplitterPresetsV1),
                Multistem,
                typeof(global::LalalAI.MultistemSplitterPresetsV1),
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
        public bool Equals(PresetsVariant23 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.DemuserSplitterPresetsV1?>.Default.Equals(Demuser, other.Demuser) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.VoiceCleanPresetsV1?>.Default.Equals(VoiceClean, other.VoiceClean) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.StemSeparatorSplitterPresetsV1?>.Default.Equals(StemSeparator, other.StemSeparator) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.MultistemSplitterPresetsV1?>.Default.Equals(Multistem, other.Multistem) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PresetsVariant23 obj1, PresetsVariant23 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PresetsVariant23>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PresetsVariant23 obj1, PresetsVariant23 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PresetsVariant23 o && Equals(o);
        }
    }
}
