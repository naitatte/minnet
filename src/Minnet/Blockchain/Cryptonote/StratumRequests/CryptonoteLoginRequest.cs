using Newtonsoft.Json;

namespace Minnet.Blockchain.Cryptonote.StratumRequests;

public class CryptonoteLoginRequest
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("pass")]
    public string Password { get; set; }

    [JsonProperty("agent")]
    public string UserAgent { get; set; }
}
