
#nullable enable

namespace LalalAI
{
    public sealed partial class LalalAIClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::LalalAI.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-License-Key",
                Value = apiKey,
            });
        }
    }
}