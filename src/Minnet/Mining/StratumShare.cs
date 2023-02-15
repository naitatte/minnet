using Minnet.Blockchain;
using Minnet.Stratum;

namespace Minnet.Mining;

public record StratumShare(StratumConnection Connection, Share Share);
