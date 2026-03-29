/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace LalalAI.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// LALAL.AI provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LALALAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("LALALAI_API_KEY environment variable is not found.");

        using var client = new LalalAIClient(apiKey);

        //// Create tools for checking task status, remaining minutes, voice packs, and task cancellation.
        var checkTaskStatusTool = client.AsCheckTaskStatusTool();
        var getMinutesLeftTool = client.AsGetMinutesLeftTool();
        var listVoicePacksTool = client.AsListVoicePacksTool();
        var cancelTasksTool = client.AsCancelTasksTool();

        Assert.AreEqual("LalalAI_CheckTaskStatus", checkTaskStatusTool.Name);
        Assert.AreEqual("LalalAI_GetMinutesLeft", getMinutesLeftTool.Name);
        Assert.AreEqual("LalalAI_ListVoicePacks", listVoicePacksTool.Name);
        Assert.AreEqual("LalalAI_CancelTasks", cancelTasksTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { checkTaskStatusTool, getMinutesLeftTool, listVoicePacksTool, cancelTasksTool };
        Assert.AreEqual(4, tools.Length);
    }
}
