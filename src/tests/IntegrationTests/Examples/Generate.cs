/* order: 10, title: Stem Separation, slug: stem-separation */

namespace LalalAI.IntegrationTests.Examples;

[TestClass]
public class StemSeparation
{
    //// LALAL.AI provides audio stem separation, voice cleaning, and voice changing
    //// via a simple async task API. Create a client with your license key.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LALALAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("LALALAI_API_KEY environment variable is not found.");

        using var client = new LalalAIClient(apiKey);

        //// The client provides methods for uploading files, splitting stems,
        //// cleaning voice, changing voice, and checking task status.
        Assert.IsNotNull(client);
    }
}
