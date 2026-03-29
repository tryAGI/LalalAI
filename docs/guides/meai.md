# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The LalalAI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to LALAL.AI's audio stem separation task management, processing minutes tracking, and voice pack listing.

## Installation

```bash
dotnet add package tryAGI.LalalAI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsCheckTaskStatusTool()` | `LalalAI_CheckTaskStatus` | Check status of audio processing tasks |
| `AsGetMinutesLeftTool()` | `LalalAI_GetMinutesLeft` | Get remaining processing minutes |
| `AsListVoicePacksTool()` | `LalalAI_ListVoicePacks` | List available voice packs |
| `AsCancelTasksTool()` | `LalalAI_CancelTasks` | Cancel in-progress tasks |

## Usage

```csharp
using Microsoft.Extensions.AI;
using LalalAI;

var client = new LalalAIClient(
    apiKey: Environment.GetEnvironmentVariable("LALALAI_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsCheckTaskStatusTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Check the status of my audio processing task abc123"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
