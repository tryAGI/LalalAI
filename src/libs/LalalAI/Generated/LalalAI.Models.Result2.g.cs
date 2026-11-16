#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LalalAI
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Result2 : global::System.IEquatable<Result2>
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
        public bool TryPickProgress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.CheckV1ProgressResult? value)
        {
            value = Progress;
            return IsProgress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.CheckV1ProgressResult PickProgress() => Progress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Progress' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.CheckV1ErrorResult? Error { get; init; }
#else
        public global::LalalAI.CheckV1ErrorResult? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.CheckV1ErrorResult? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.CheckV1ErrorResult PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

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
        public bool TryPickCancelled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.CheckV1CancelledResult? value)
        {
            value = Cancelled;
            return IsCancelled;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.CheckV1CancelledResult PickCancelled() => Cancelled is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cancelled' but the value was {ToString()}.");

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
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.CheckV1SuccessResult? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.CheckV1SuccessResult PickSuccess() => Success is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LalalAI.ErrorResult? ServerError { get; init; }
#else
        public global::LalalAI.ErrorResult? ServerError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerError))]
#endif
        public bool IsServerError => ServerError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServerError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LalalAI.ErrorResult? value)
        {
            value = ServerError;
            return IsServerError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LalalAI.ErrorResult PickServerError() => ServerError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::LalalAI.CheckV1ProgressResult value) => new Result2((global::LalalAI.CheckV1ProgressResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1ProgressResult?(Result2 @this) => @this.Progress;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::LalalAI.CheckV1ProgressResult? value)
        {
            Progress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromProgress(global::LalalAI.CheckV1ProgressResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::LalalAI.CheckV1ErrorResult value) => new Result2((global::LalalAI.CheckV1ErrorResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1ErrorResult?(Result2 @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::LalalAI.CheckV1ErrorResult? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromError(global::LalalAI.CheckV1ErrorResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::LalalAI.CheckV1CancelledResult value) => new Result2((global::LalalAI.CheckV1CancelledResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1CancelledResult?(Result2 @this) => @this.Cancelled;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::LalalAI.CheckV1CancelledResult? value)
        {
            Cancelled = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromCancelled(global::LalalAI.CheckV1CancelledResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::LalalAI.CheckV1SuccessResult value) => new Result2((global::LalalAI.CheckV1SuccessResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.CheckV1SuccessResult?(Result2 @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::LalalAI.CheckV1SuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromSuccess(global::LalalAI.CheckV1SuccessResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::LalalAI.ErrorResult value) => new Result2((global::LalalAI.ErrorResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LalalAI.ErrorResult?(Result2 @this) => @this.ServerError;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::LalalAI.ErrorResult? value)
        {
            ServerError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromServerError(global::LalalAI.ErrorResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public Result2(
            global::LalalAI.CheckV1ResponseResultDiscriminatorStatus? status,
            global::LalalAI.CheckV1ProgressResult? progress,
            global::LalalAI.CheckV1ErrorResult? error,
            global::LalalAI.CheckV1CancelledResult? cancelled,
            global::LalalAI.CheckV1SuccessResult? success,
            global::LalalAI.ErrorResult? serverError
            )
        {
            Status = status;

            Progress = progress;
            Error = error;
            Cancelled = cancelled;
            Success = success;
            ServerError = serverError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServerError as object ??
            Success as object ??
            Cancelled as object ??
            Error as object ??
            Progress as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Progress?.ToString() ??
            Error?.ToString() ??
            Cancelled?.ToString() ??
            Success?.ToString() ??
            ServerError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsProgress && !IsError && !IsCancelled && !IsSuccess && !IsServerError || !IsProgress && IsError && !IsCancelled && !IsSuccess && !IsServerError || !IsProgress && !IsError && IsCancelled && !IsSuccess && !IsServerError || !IsProgress && !IsError && !IsCancelled && IsSuccess && !IsServerError || !IsProgress && !IsError && !IsCancelled && !IsSuccess && IsServerError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LalalAI.CheckV1ProgressResult, TResult>? progress = null,
            global::System.Func<global::LalalAI.CheckV1ErrorResult, TResult>? error = null,
            global::System.Func<global::LalalAI.CheckV1CancelledResult, TResult>? cancelled = null,
            global::System.Func<global::LalalAI.CheckV1SuccessResult, TResult>? success = null,
            global::System.Func<global::LalalAI.ErrorResult, TResult>? serverError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Progress is { } __value0 && progress != null)
            {
                return progress(__value0);
            }
            else if (Error is { } __value1 && error != null)
            {
                return error(__value1);
            }
            else if (Cancelled is { } __value2 && cancelled != null)
            {
                return cancelled(__value2);
            }
            else if (Success is { } __value3 && success != null)
            {
                return success(__value3);
            }
            else if (ServerError is { } __value4 && serverError != null)
            {
                return serverError(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LalalAI.CheckV1ProgressResult>? progress = null,

            global::System.Action<global::LalalAI.CheckV1ErrorResult>? error = null,

            global::System.Action<global::LalalAI.CheckV1CancelledResult>? cancelled = null,

            global::System.Action<global::LalalAI.CheckV1SuccessResult>? success = null,

            global::System.Action<global::LalalAI.ErrorResult>? serverError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Progress is { } __value0)
            {
                progress?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
            else if (Cancelled is { } __value2)
            {
                cancelled?.Invoke(__value2);
            }
            else if (Success is { } __value3)
            {
                success?.Invoke(__value3);
            }
            else if (ServerError is { } __value4)
            {
                serverError?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LalalAI.CheckV1ProgressResult>? progress = null,
            global::System.Action<global::LalalAI.CheckV1ErrorResult>? error = null,
            global::System.Action<global::LalalAI.CheckV1CancelledResult>? cancelled = null,
            global::System.Action<global::LalalAI.CheckV1SuccessResult>? success = null,
            global::System.Action<global::LalalAI.ErrorResult>? serverError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Progress is { } __value0)
            {
                progress?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
            else if (Cancelled is { } __value2)
            {
                cancelled?.Invoke(__value2);
            }
            else if (Success is { } __value3)
            {
                success?.Invoke(__value3);
            }
            else if (ServerError is { } __value4)
            {
                serverError?.Invoke(__value4);
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
                Error,
                typeof(global::LalalAI.CheckV1ErrorResult),
                Cancelled,
                typeof(global::LalalAI.CheckV1CancelledResult),
                Success,
                typeof(global::LalalAI.CheckV1SuccessResult),
                ServerError,
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
        public bool Equals(Result2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1ProgressResult?>.Default.Equals(Progress, other.Progress) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1ErrorResult?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1CancelledResult?>.Default.Equals(Cancelled, other.Cancelled) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.CheckV1SuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::LalalAI.ErrorResult?>.Default.Equals(ServerError, other.ServerError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Result2 obj1, Result2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Result2 obj1, Result2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result2 o && Equals(o);
        }
    }
}
