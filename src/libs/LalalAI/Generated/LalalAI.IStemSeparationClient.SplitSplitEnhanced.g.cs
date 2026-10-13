#nullable enable

namespace LalalAI
{
    public partial interface IStemSeparationClient
    {
        /// <summary>
        /// Split a file into stems using the stem separator presets<br/>
        /// Extracts one stem from a song. You get two files: the stem and the rest of the song without it.<br/>
        /// For speech recordings use `/split/voice_clean/` (noise in the background) or `/split/demuser/` (music in the background).<br/>
        /// **Stems**<br/>
        /// | Stem | What it extracts | `auto` currently picks |<br/>
        /// |---|---|---|<br/>
        /// | `vocals` | Singing: lead and backing vocals | andromeda |<br/>
        /// | `drum` | Drums | andromeda |<br/>
        /// | `bass` | Bass | andromeda |<br/>
        /// | `piano` | Piano | andromeda |<br/>
        /// | `guitar` | Any guitar, electric and acoustic together | andromeda |<br/>
        /// | `electric_guitar` | Electric guitar only | perseus |<br/>
        /// | `acoustic_guitar` | Acoustic guitar only | perseus |<br/>
        /// | `synthesizer` | Synthesizers | phoenix |<br/>
        /// | `strings` | String instruments | phoenix |<br/>
        /// | `wind` | Wind instruments | phoenix |<br/>
        /// To extract a guitar, use `guitar` even if you expect only an electric one: it runs on a newer model.<br/>
        /// Use `electric_guitar` or `acoustic_guitar` only to separate the two kinds of guitar from each other.<br/>
        /// Leave `splitter` as `auto` to get new models as soon as they are released, see [Stem Separation](#tag/stem-separation).<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "&lt;stem&gt;", "url": "..."}<br/>
        /// {"type": "back", "label": "no_&lt;stem&gt;", "url": "..."}<br/>
        /// ```<br/>
        /// **Lead and backing vocals**<br/>
        /// For the `vocals` stem, set `multivocal: "lead_back"` to get lead and backing vocals as separate tracks.<br/>
        /// `/check/` then returns 4 tracks. The backing vocals track is left out if the song has none.<br/>
        /// - `vocals@0` (`stem`): lead vocals.<br/>
        /// - `vocals@1` (`stem`): backing vocals.<br/>
        /// - `no_vocals` (`back`): instrumental.<br/>
        /// - `mix_no_lead` (`back`): instrumental with backing vocals.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitEnhancedAsync(

            global::LalalAI.StemSeparatorSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split a file into stems using the stem separator presets<br/>
        /// Extracts one stem from a song. You get two files: the stem and the rest of the song without it.<br/>
        /// For speech recordings use `/split/voice_clean/` (noise in the background) or `/split/demuser/` (music in the background).<br/>
        /// **Stems**<br/>
        /// | Stem | What it extracts | `auto` currently picks |<br/>
        /// |---|---|---|<br/>
        /// | `vocals` | Singing: lead and backing vocals | andromeda |<br/>
        /// | `drum` | Drums | andromeda |<br/>
        /// | `bass` | Bass | andromeda |<br/>
        /// | `piano` | Piano | andromeda |<br/>
        /// | `guitar` | Any guitar, electric and acoustic together | andromeda |<br/>
        /// | `electric_guitar` | Electric guitar only | perseus |<br/>
        /// | `acoustic_guitar` | Acoustic guitar only | perseus |<br/>
        /// | `synthesizer` | Synthesizers | phoenix |<br/>
        /// | `strings` | String instruments | phoenix |<br/>
        /// | `wind` | Wind instruments | phoenix |<br/>
        /// To extract a guitar, use `guitar` even if you expect only an electric one: it runs on a newer model.<br/>
        /// Use `electric_guitar` or `acoustic_guitar` only to separate the two kinds of guitar from each other.<br/>
        /// Leave `splitter` as `auto` to get new models as soon as they are released, see [Stem Separation](#tag/stem-separation).<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "&lt;stem&gt;", "url": "..."}<br/>
        /// {"type": "back", "label": "no_&lt;stem&gt;", "url": "..."}<br/>
        /// ```<br/>
        /// **Lead and backing vocals**<br/>
        /// For the `vocals` stem, set `multivocal: "lead_back"` to get lead and backing vocals as separate tracks.<br/>
        /// `/check/` then returns 4 tracks. The backing vocals track is left out if the song has none.<br/>
        /// - `vocals@0` (`stem`): lead vocals.<br/>
        /// - `vocals@1` (`stem`): backing vocals.<br/>
        /// - `no_vocals` (`back`): instrumental.<br/>
        /// - `mix_no_lead` (`back`): instrumental with backing vocals.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LalalAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.AutoSDKHttpResponse<global::LalalAI.Task>> SplitSplitEnhancedAsResponseAsync(

            global::LalalAI.StemSeparatorSplitParameters request,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Split a file into stems using the stem separator presets<br/>
        /// Extracts one stem from a song. You get two files: the stem and the rest of the song without it.<br/>
        /// For speech recordings use `/split/voice_clean/` (noise in the background) or `/split/demuser/` (music in the background).<br/>
        /// **Stems**<br/>
        /// | Stem | What it extracts | `auto` currently picks |<br/>
        /// |---|---|---|<br/>
        /// | `vocals` | Singing: lead and backing vocals | andromeda |<br/>
        /// | `drum` | Drums | andromeda |<br/>
        /// | `bass` | Bass | andromeda |<br/>
        /// | `piano` | Piano | andromeda |<br/>
        /// | `guitar` | Any guitar, electric and acoustic together | andromeda |<br/>
        /// | `electric_guitar` | Electric guitar only | perseus |<br/>
        /// | `acoustic_guitar` | Acoustic guitar only | perseus |<br/>
        /// | `synthesizer` | Synthesizers | phoenix |<br/>
        /// | `strings` | String instruments | phoenix |<br/>
        /// | `wind` | Wind instruments | phoenix |<br/>
        /// To extract a guitar, use `guitar` even if you expect only an electric one: it runs on a newer model.<br/>
        /// Use `electric_guitar` or `acoustic_guitar` only to separate the two kinds of guitar from each other.<br/>
        /// Leave `splitter` as `auto` to get new models as soon as they are released, see [Stem Separation](#tag/stem-separation).<br/>
        /// **Result**<br/>
        /// `/check/` returns 2 tracks:<br/>
        /// ```<br/>
        /// {"type": "stem", "label": "&lt;stem&gt;", "url": "..."}<br/>
        /// {"type": "back", "label": "no_&lt;stem&gt;", "url": "..."}<br/>
        /// ```<br/>
        /// **Lead and backing vocals**<br/>
        /// For the `vocals` stem, set `multivocal: "lead_back"` to get lead and backing vocals as separate tracks.<br/>
        /// `/check/` then returns 4 tracks. The backing vocals track is left out if the song has none.<br/>
        /// - `vocals@0` (`stem`): lead vocals.<br/>
        /// - `vocals@1` (`stem`): backing vocals.<br/>
        /// - `no_vocals` (`back`): instrumental.<br/>
        /// - `mix_no_lead` (`back`): instrumental with backing vocals.
        /// </summary>
        /// <param name="sourceId">
        /// ID of the source file to be processed.<br/>
        /// Example: 2fe8f214-1771-4900-9e7e-570f823bd359
        /// </param>
        /// <param name="presets"></param>
        /// <param name="idempotencyKey">
        /// Unique uuid4 key to ensure idempotent requests.<br/>
        /// Prevents duplicate task execution with the same parameters.<br/>
        /// Can be reused until the task starts. Once processing begins, reusing this key will return an error.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LalalAI.Task> SplitSplitEnhancedAsync(
            string sourceId,
            global::LalalAI.StemSeparatorSplitterPresetsV1 presets,
            string? idempotencyKey = default,
            global::LalalAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}