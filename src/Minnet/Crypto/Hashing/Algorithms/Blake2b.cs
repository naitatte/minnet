using Minnet.Contracts;
using Minnet.Native;

namespace Minnet.Crypto.Hashing.Algorithms;

[Identifier("blake2b")]
public unsafe class Blake2b : IHashAlgorithm
{
    public void Digest(ReadOnlySpan<byte> data, Span<byte> result, params object[] extra)
    {
        Contract.Requires<ArgumentException>(result.Length >= 32);

        fixed (byte* input = data)
        {
            fixed (byte* output = result)
            {
                Multihash.blake2b(input, output, (uint) data.Length, result.Length);
            }
        }
    }
}
