using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Threading
{
  [System.Runtime.InteropServices.ComVisible(true)]
  internal static class TimeoutShim
  {
#if NET40
    [System.Runtime.InteropServices.ComVisible(false)]
    public static readonly TimeSpan InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, Timeout.Infinite);
#else
    public static readonly TimeSpan InfiniteTimeSpan = Timeout.InfiniteTimeSpan;
#endif
  }
}
