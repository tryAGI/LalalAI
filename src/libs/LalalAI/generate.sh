install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.json https://www.lalal.ai/api/v1/openapi.json

# Auth: X-License-Key header. --security-scheme handles auth natively.
# Still need to add server URL (missing from spec).
jq '
  .servers = [{"url": "https://www.lalal.ai"}]
' openapi.json > openapi_fixed.json
mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace LalalAI \
  --clientClassName LalalAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-License-Key
