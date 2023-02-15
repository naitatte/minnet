namespace Minnet.Api.WebSocketNotifications;

public enum WsNotificationType
{
    Greeting,
    BlockFound,
    NewChainHeight,
    Payment,
    BlockUnlocked,
    BlockUnlockProgress,
    HashrateUpdated
}
