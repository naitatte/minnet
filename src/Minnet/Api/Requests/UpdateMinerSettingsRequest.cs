using Minnet.Api.Responses;

namespace Minnet.Api.Requests;

public class UpdateMinerSettingsRequest
{
    public string IpAddress { get; set; }
    public MinerSettings Settings { get; set; }
}
