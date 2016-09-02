using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace System
{
  internal static class CaTicksExtensions
  {
#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static TimeSpan Multiply(this TimeSpan timeSpan, double value)
    {
      double ticksD = checked((double)timeSpan.Ticks * value);
      long ticks = checked((long)ticksD);
      return TimeSpan.FromTicks(ticks);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static TimeSpan Divide(this TimeSpan timeSpan, double value)
    {
      double ticksD = checked((double)timeSpan.Ticks / value);
      long ticks = checked((long)ticksD);
      return TimeSpan.FromTicks(ticks);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static double Divide(this TimeSpan first, TimeSpan second)
    {
      double ticks1 = (double)first.Ticks;
      double ticks2 = (double)second.Ticks;
      return ticks1 / ticks2;
    }
  }
}
