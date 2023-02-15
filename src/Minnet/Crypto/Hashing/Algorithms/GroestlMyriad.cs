using Minnet.Contracts;
using Minnet.Native;

namespace Minnet.Crypto.Hashing.Algorithms;

[Identifier("groestl-myriad")]
public unsafe class GroestlMyriad : IHashAlgorithm
{
    public void Digest(ReadOnlySpan<byte> data, Span<byte> result, params object[] extra)
    {
        Contract.Requires<ArgumentException>(result.Length >= 32);

        fixed (byte* input = data)
        {
            fixed (byte* output = result)
            {
                Multihash.groestl_myriad(input, output, (uint) data.Length);
            }
        }
    }
}
