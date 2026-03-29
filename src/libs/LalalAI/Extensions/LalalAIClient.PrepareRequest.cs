#nullable enable

namespace LalalAI;

public partial class LalalAIClient
{
    /// <summary>
    /// After Bearer auth is set, convert to X-License-Key header.
    /// LALAL.AI uses X-License-Key header instead of Authorization: Bearer.
    /// </summary>
    partial void Authorized(global::System.Net.Http.HttpClient client)
    {
        var apiKey = Authorizations.FirstOrDefault()?.Value;
        if (apiKey is { Length: > 0 })
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("X-License-Key", apiKey);
        }
    }
}
