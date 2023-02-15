using System.Net;

namespace Minnet.Banning;

public interface IBanManager
{
    bool IsBanned(IPAddress address);
    void Ban(IPAddress address, TimeSpan duration);
}
