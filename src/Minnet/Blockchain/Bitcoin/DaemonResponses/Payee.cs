using Newtonsoft.Json;

namespace Minnet.Blockchain.Bitcoin.DaemonResponses;

public class PayeeBlockTemplateExtra
{
    public string Payee { get; set; }

    [JsonProperty("payee_amount")]
    public long? PayeeAmount { get; set; }
}
