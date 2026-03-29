#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Result : global::System.IEquatable<Result>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LalalAI.CheckV1ResponseResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.CheckV1ProgressResult? Progress { get; init; }
#else
        public global::LalalAI.CheckV1ProgressResult? Progress { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Progress))]
#endif
        public bool IsProgress => Progress != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.CheckV1ErrorResult? Error1 { get; init; }
#else
        public global::LalalAI.CheckV1ErrorResult? Error1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error1))]
#endif
        public bool IsError1 => Error1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.CheckV1CancelledResult? Cancelled { get; init; }
#else
        public global::LalalAI.CheckV1CancelledResult? Cancelled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cancelled))]
#endif
        public bool IsCancelled => Cancelled != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.CheckV1SuccessResult? Success { get; init; }
#else
        public global::LalalAI.CheckV1SuccessResult? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.ErrorResult? Error2 { get; init; }
#else
        public global::LalalAI.ErrorResult? Error2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error2))]
#endif
        public bool IsError2 => Error2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::LalalAI.CheckV1ProgressResult value) => new Result((global::LalalAI.CheckV1ProgressResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1ProgressResult?(Result @this) => @this.Progress;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::LalalAI.CheckV1ProgressResult? value)
        {
            Progress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::LalalAI.CheckV1ErrorResult value) => new Result((global::LalalAI.CheckV1ErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1ErrorResult?(Result @this) => @this.Error1;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::LalalAI.CheckV1ErrorResult? value)
        {
            Error1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::LalalAI.CheckV1CancelledResult value) => new Result((global::LalalAI.CheckV1CancelledResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1CancelledResult?(Result @this) => @this.Cancelled;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::LalalAI.CheckV1CancelledResult? value)
        {
            Cancelled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::LalalAI.CheckV1SuccessResult value) => new Result((global::LalalAI.CheckV1SuccessResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1SuccessResult?(Result @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::LalalAI.CheckV1SuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result(global::LalalAI.ErrorResult value) => new Result((global::LalalAI.ErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LalalAI.ErrorResult?(Result @this) => @this.Error2;

        /// <summary>
        /// 
        /// </summary>
        public Result(global::LalalAI.ErrorResult? value)
        {
            Error2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result(
            global::LalalAI.CheckV1ResponseResultDiscriminatorStatus? status,
            global::LalalAI.CheckV1ProgressResult? progress,
            global::LalalAI.CheckV1ErrorResult? error1,
            global::LalalAI.CheckV1CancelledResult? cancelled,
            global::LalalAI.CheckV1SuccessResult? success,
            global::LalalAI.ErrorResult? error2
            )
        {
            Status = status;

            Progress = progress;
            Error1 = error1;
            Cancelled = cancelled;
            Success = success;
            Error2 = error2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error2 as object ??
            Success as object ??
            Cancelled as object ??
            Error1 as object ??
            Progress as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Progress?.ToString() ??
            Error1?.ToString() ??
            Cancelled?.ToString() ??
            Success?.ToString() ??
            Error2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProgress && !IsError1 && !IsCancelled && !IsSuccess && !IsError2 || !IsProgress && IsError1 && !IsCancelled && !IsSuccess && !IsError2 || !IsProgress && !IsError1 && IsCancelled && !IsSuccess && !IsError2 || !IsProgress && !IsError1 && !IsCancelled && IsSuccess && !IsError2 || !IsProgress && !IsError1 && !IsCancelled && !IsSuccess && IsError2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.CheckV1ProgressResult?, TResult>? progress = null,
            global::System.Func<global::LalalAI.CheckV1ErrorResult?, TResult>? error1 = null,
            global::System.Func<global::LalalAI.CheckV1CancelledResult?, TResult>? cancelled = null,
            global::System.Func<global::LalalAI.CheckV1SuccessResult?, TResult>? success = null,
            global::System.Func<global::LalalAI.ErrorResult?, TResult>? error2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProgress && progress != null)
            {
                return progress(Progress!);
            }
            else if (IsError1 && error1 != null)
            {
                return error1(Error1!);
            }
            else if (IsCancelled && cancelled != null)
            {
                return cancelled(Cancelled!);
            }
            else if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsError2 && error2 != null)
            {
                return error2(Error2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.CheckV1ProgressResult?>? progress = null,
            global::System.Action<global::LalalAI.CheckV1ErrorResult?>? error1 = null,
            global::System.Action<global::LalalAI.CheckV1CancelledResult?>? cancelled = null,
            global::System.Action<global::LalalAI.CheckV1SuccessResult?>? success = null,
            global::System.Action<global::LalalAI.ErrorResult?>? error2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProgress)
            {
                progress?.Invoke(Progress!);
            }
            else if (IsError1)
            {
                error1?.Invoke(Error1!);
            }
            else if (IsCancelled)
            {
                cancelled?.Invoke(Cancelled!);
            }
            else if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError2)
            {
                error2?.Invoke(Error2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Progress,
                typeof(global::LalalAI.CheckV1ProgressResult),
                Error1,
                typeof(global::LalalAI.CheckV1ErrorResult),
                Cancelled,
                typeof(global::LalalAI.CheckV1CancelledResult),
                Success,
                typeof(global::LalalAI.CheckV1SuccessResult),
                Error2,
                typeof(global::LalalAI.ErrorResult),
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
        public bool Equals(Result other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1ProgressResult?>.Default.Equals(Progress, other.Progress) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1ErrorResult?>.Default.Equals(Error1, other.Error1) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1CancelledResult?>.Default.Equals(Cancelled, other.Cancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1SuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.ErrorResult?>.Default.Equals(Error2, other.Error2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Result obj1, Result obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Result obj1, Result obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result o && Equals(o);
        }
    }
}
