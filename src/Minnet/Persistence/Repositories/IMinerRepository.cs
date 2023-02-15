using System.Data;
using Minnet.Persistence.Model;

namespace Minnet.Persistence.Repositories;

public interface IMinerRepository
{
    Task<MinerSettings> GetSettingsAsync(IDbConnection con, IDbTransaction tx, string poolId, string address);
    Task UpdateSettingsAsync(IDbConnection con, IDbTransaction tx, MinerSettings settings);
}
