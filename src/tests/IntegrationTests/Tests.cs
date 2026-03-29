namespace LalalAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LalalAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LALALAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LALALAI_API_KEY environment variable is not found.");

        var client = new LalalAIClient(apiKey);

        return client;
    }
}
