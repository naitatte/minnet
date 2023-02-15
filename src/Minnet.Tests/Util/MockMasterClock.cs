using System;
using Minnet.Time;

namespace Minnet.Tests.Util;

public class MockMasterClock : IMasterClock
{
    public DateTime CurrentTime { get; set; }

    public DateTime Now => CurrentTime;

    public static MockMasterClock FromTicks(long value)
    {
        return new MockMasterClock
        {
            CurrentTime = new DateTime(value, DateTimeKind.Utc)
        };
    }
}
