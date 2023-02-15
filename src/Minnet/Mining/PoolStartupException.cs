using Minnet.Configuration;

namespace Minnet.Mining;

public class PoolStartupException : Exception
{
    public PoolStartupException(string msg, string poolId = null) : base(msg)
    {
        PoolId = poolId;
    }

    public PoolStartupException()
    {
    }

    public string PoolId { get; }
}
