using CircularBuffer;
using Minnet.Configuration;

namespace Minnet.VarDiff;

public class VarDiffContext
{
    public double? LastTs { get; set; }
    public double LastRetarget { get; set; }
    public CircularBuffer<double> TimeBuffer { get; set; }
    public DateTime Created { get; set; }
    public DateTime? LastUpdate { get; set; }
    public VarDiffConfig Config { get; set; }
}
