using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Minnet.Tests.Util;

public class Globals
{
    public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
    {
        ContractResolver = new CamelCasePropertyNamesContractResolver()
    };
}
