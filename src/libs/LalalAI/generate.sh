dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://www.lalal.ai/api/v1/openapi.json

# Fix auth: convert apiKey header auth to http/bearer + add top-level security array + add server URL
jq '
  .components.securitySchemes = {
    "BearerAuth": {
      "type": "http",
      "scheme": "bearer"
    }
  } |
  .security = [{"BearerAuth": []}] |
  .servers = [{"url": "https://www.lalal.ai"}] |
  (.paths[][] | select(.security?) | .security) = [{"BearerAuth": []}]
' openapi.json > openapi_fixed.json
mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace LalalAI \
  --clientClassName LalalAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
