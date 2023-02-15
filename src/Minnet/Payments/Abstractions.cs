using System.Data;
using Minnet.Configuration;
using Minnet.Mining;
using Minnet.Persistence.Model;

namespace Minnet.Payments;

public interface IPayoutHandler
{
    Task ConfigureAsync(ClusterConfig cc, PoolConfig pc, CancellationToken ct);

    Task<Block[]> ClassifyBlocksAsync(IMiningPool pool, Block[] blocks, CancellationToken ct);
    Task<decimal> UpdateBlockRewardBalancesAsync(IDbConnection con, IDbTransaction tx, IMiningPool pool, Block block, CancellationToken ct);
    Task PayoutAsync(IMiningPool pool, Balance[] balances, CancellationToken ct);
    double AdjustShareDifficulty(double difficulty);
    double AdjustBlockEffort(double effort);

    string FormatAmount(decimal amount);
}

public interface IPayoutScheme
{
    Task UpdateBalancesAsync(IDbConnection con, IDbTransaction tx, IMiningPool pool, IPayoutHandler payoutHandler, Block block, decimal blockReward, CancellationToken ct);
}
