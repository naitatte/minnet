using System.Data;

namespace Minnet.Persistence;

public interface IConnectionFactory
{
    Task<IDbConnection> OpenConnectionAsync();
}
