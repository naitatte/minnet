using Newtonsoft.Json;

namespace Minnet.Blockchain.Cryptonote.DaemonResponses;

public class SplitIntegratedAddressResponse
{
    [JsonProperty("standard_address")]
    public string StandardAddress { get; set; }

    public string Payment { get; set; }
}
