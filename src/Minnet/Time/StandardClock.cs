namespace Minnet.Time;

public class StandardClock : IMasterClock
{
    public DateTime Now => DateTime.UtcNow;
}
