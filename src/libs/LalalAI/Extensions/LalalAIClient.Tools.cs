#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace LalalAI;

public static class LalalAIClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that checks the status of one or more tasks.
    /// </summary>
    public static AIFunction AsCheckTaskStatusTool(this LalalAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Comma-separated list of task IDs to check status for")] string taskIds,
                   CancellationToken cancellationToken) =>
            {
                var ids = taskIds.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var response = await client.Common.CheckCheckAsync(
                    taskIds: ids,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "LalalAI_CheckTaskStatus",
            description: "Check the status of one or more LALAL.AI audio processing tasks. Returns status (progress/success/error/cancelled) and download URLs when complete.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the remaining processing minutes.
    /// </summary>
    public static AIFunction AsGetMinutesLeftTool(this LalalAIClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Common.LimitsGetMinutesLeftAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "LalalAI_GetMinutesLeft",
            description: "Get the number of remaining processing minutes available on the LALAL.AI account.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available voice packs.
    /// </summary>
    public static AIFunction AsListVoicePacksTool(this LalalAIClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.VoiceChange.VoicePacksListPacksAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "LalalAI_ListVoicePacks",
            description: "List all voice packs available for voice changing on LALAL.AI, including custom and built-in packs.");
    }

    /// <summary>
    /// Creates an AIFunction tool that cancels tasks by ID.
    /// </summary>
    public static AIFunction AsCancelTasksTool(this LalalAIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Comma-separated list of task IDs to cancel")] string taskIds,
                   CancellationToken cancellationToken) =>
            {
                var ids = taskIds.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                var response = await client.Common.CancelCancelAsync(
                    taskIds: ids,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "LalalAI_CancelTasks",
            description: "Cancel one or more in-progress LALAL.AI audio processing tasks.");
    }
}
