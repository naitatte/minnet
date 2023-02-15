using Minnet.JsonRpc;

namespace Minnet.Rpc;

public record RpcResponse<T>(T Response, JsonRpcError Error = null);
