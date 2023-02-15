using System.Net;
using Minnet.Configuration;

namespace Minnet.Stratum;

public record StratumEndpoint(IPEndPoint IPEndPoint, PoolEndpoint PoolEndpoint);
