using Newtonsoft.Json;

namespace Minnet.Blockchain.Cryptonote.StratumRequests;

public class CryptonoteSubmitShareRequest
{
    [JsonProperty("id")]
    public string WorkerId { get; set; }

    [JsonProperty("job_id")]
    public string JobId { get; set; }

    public string Nonce { get; set; }

    [JsonProperty("result")]
    public string Hash { get; set; }
}
