using Newtonsoft.Json;

namespace Minnet.Blockchain.Equihash.DaemonResponses;

public class ZCashShieldingResponse
{
    [JsonProperty("opid")]
    public string OperationId { get; set; }
}
