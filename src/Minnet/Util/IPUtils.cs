using System.Net;

namespace Minnet.Util;

public class IPUtils
{
    public static readonly IPAddress IPv4LoopBackOnIPv6 = IPAddress.Parse("::ffff:127.0.0.1");
}
