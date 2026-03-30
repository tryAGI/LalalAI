# CLAUDE.md -- LalalAI SDK

## Overview

Auto-generated C# SDK for [LALAL.AI](https://www.lalal.ai/) -- AI-powered audio stem separation, voice cleaning, voice changing, and noise removal.
OpenAPI spec from `https://www.lalal.ai/api/v1/openapi.json` (v1.1.0).

## Build & Test

```bash
dotnet build LalalAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `X-License-Key` header (native via `--security-scheme`):

```csharp
var client = new LalalAIClient(apiKey); // LALALAI_API_KEY env var
```

## Key Files

- `src/libs/LalalAI/openapi.json` -- Source OpenAPI spec (downloaded + auth-fixed)
- `src/libs/LalalAI/generate.sh` -- Downloads spec, fixes auth with jq, runs autosdk
- `src/libs/LalalAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/LalalAI/Extensions/LalalAIClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new LalalAIClient(apiKey);

// Common -- upload, check status, cancel, delete, limits
client.Common.UploadUploadAsync(...)               // Upload audio file
client.Common.CheckCheckAsync(taskIds)              // Check task status
client.Common.CancelCancelAsync(taskIds)            // Cancel tasks
client.Common.CancelCancelAllAsync()                // Cancel all tasks
client.Common.DeleteDeleteAsync(sourceId)           // Delete source + tracks
client.Common.LimitsGetMinutesLeftAsync()           // Get remaining minutes

// Stem Separation -- split into individual stems
client.StemSeparation.SplitSplitEnhancedAsync(...)  // Vocals, drums, bass, guitar, etc.
client.StemSeparation.SplitSplitDemuserAsync(...)   // Clean voice from background music
client.StemSeparation.SplitSplitVoiceCleanAsync(...)// Clean voice from background noise
client.StemSeparation.SplitSplitMultistemAsync(...)  // Multiple stems in one request

// Batch Stem Separation -- process multiple files at once
client.BatchStemSeparation.BatchSplitSplitBatchEnhancedAsync(...)
client.BatchStemSeparation.BatchSplitSplitBatchDemuserAsync(...)
client.BatchStemSeparation.BatchSplitSplitBatchVoiceCleanAsync(...)

// Voice Change -- change voice using voice packs
client.VoiceChange.ChangeVoiceChangeVoiceAsync(...) // Change voice in audio
client.VoiceChange.VoicePacksListPacksAsync()       // List available voice packs
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsCheckTaskStatusTool()` -- Check audio processing task status and get download URLs
- `AsGetMinutesLeftTool()` -- Get remaining processing minutes
- `AsListVoicePacksTool()` -- List available voice packs for voice changing
- `AsCancelTasksTool()` -- Cancel in-progress audio processing tasks

## Spec Notes

- Base URL: `https://www.lalal.ai`
- 15 endpoints across 4 groups: Common, Stem Separation, Batch Stem Separation, Voice Change
- Auth: `X-License-Key` header -- native via `--security-scheme ApiKey:Header:X-License-Key`
- Async task pattern: upload -> split -> poll check -> download
- Splitter models: andromeda, perseus, orion, phoenix, lyra
- Stems: vocals, drum, piano, bass, electric_guitar, acoustic_guitar, synthesizer, strings, wind
