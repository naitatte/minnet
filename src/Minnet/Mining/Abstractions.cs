using Minnet.Blockchain;
using Minnet.Configuration;

namespace Minnet.Mining;

public interface IMiningPool
{
    PoolConfig Config { get; }
    PoolStats PoolStats { get; }
    BlockchainStats NetworkStats { get; }
    double ShareMultiplier { get; }
    void Configure(PoolConfig pc, ClusterConfig cc);
    double HashrateFromShares(double shares, double interval);
    Task RunAsync(CancellationToken ct);
}
