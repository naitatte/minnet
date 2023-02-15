using System.Net.WebSockets;
using System.Text;

namespace Minnet.Extensions;

public static class WebSocketExtensions
{
    public static async Task SendAsync(this WebSocket socket, string msg, CancellationToken ct)
    {
        var bytes = Encoding.UTF8.GetBytes(msg);
        await socket.SendAsync(bytes, WebSocketMessageType.Text, true, ct);
    }
}
