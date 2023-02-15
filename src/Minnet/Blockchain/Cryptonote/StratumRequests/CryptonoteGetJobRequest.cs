using Newtonsoft.Json;

namespace Minnet.Blockchain.Cryptonote.StratumRequests;

public class CryptonoteGetJobRequest
{
    [JsonProperty("id")]
    public string WorkerId { get; set; }
}
