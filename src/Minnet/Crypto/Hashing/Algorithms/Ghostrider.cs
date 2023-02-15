using Minnet.Native;
using static Minnet.Native.Cryptonight.Algorithm;

namespace Minnet.Crypto.Hashing.Algorithms;

[Identifier("ghostrider")]
public class Ghostrider : IHashAlgorithm
{
    public void Digest(ReadOnlySpan<byte> data, Span<byte> result, params object[] extra)
    {
        Cryptonight.CryptonightHash(data, result, GHOSTRIDER_RTM, 0);
    }
}
