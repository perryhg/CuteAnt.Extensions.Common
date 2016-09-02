// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// System.ServiceModel.Internals\System\Runtime\Ticks.cs

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;
#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace CuteAnt
{
  internal static class Ticks
  {
    #region take from UnsafeNativeMethods
#if DESKTOPCLR
    private const string KERNEL32 = "kernel32.dll";
    //[SuppressMessage(FxCop.Category.Security, FxCop.Rule.ReviewSuppressUnmanagedCodeSecurityUsage,
    //    Justification = "This PInvoke call has been reviewed")]
    [DllImport(KERNEL32, SetLastError = true)]
    [ResourceExposure(ResourceScope.None)]
    [SecurityCritical]
    private static extern void GetSystemTimeAsFileTime([Out] out FILETIME time);

    [SecurityCritical]
    private static void GetSystemTimeAsFileTime(out long time)
    {
      FILETIME fileTime;
      GetSystemTimeAsFileTime(out fileTime);
      time = 0;
      time |= (uint)fileTime.dwHighDateTime;
      time <<= sizeof(uint) * 8;
      time |= (uint)fileTime.dwLowDateTime;
    }
#endif
    #endregion
    public static long Now
    {
#if DESKTOPCLR
      //[Fx.Tag.SecurityNote(Miscellaneous = "Why isn't the SuppressUnmanagedCodeSecurity attribute working in this case?")]
      [SecuritySafeCritical]
#endif
      get
      {
#if DESKTOPCLR
        long time;
#pragma warning disable 1634
#pragma warning suppress 56523 // function has no error return value
#pragma warning restore 1634
        //UnsafeNativeMethods.GetSystemTimeAsFileTime(out time);
        GetSystemTimeAsFileTime(out time);
        return time;
#else
        return DateTime.UtcNow.Ticks;
#endif
      }
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static long FromMilliseconds(int milliseconds)
    {
      return checked((long)milliseconds * TimeSpan.TicksPerMillisecond);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static int ToMilliseconds(long ticks)
    {
      return checked((int)(ticks / TimeSpan.TicksPerMillisecond));
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static long FromTimeSpan(TimeSpan duration)
    {
      return duration.Ticks;
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static TimeSpan ToTimeSpan(long ticks)
    {
      return new TimeSpan(ticks);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static long Add(long firstTicks, long secondTicks)
    {
      if (firstTicks == long.MaxValue || firstTicks == long.MinValue)
      {
        return firstTicks;
      }
      if (secondTicks == long.MaxValue || secondTicks == long.MinValue)
      {
        return secondTicks;
      }
      if (firstTicks >= 0 && long.MaxValue - firstTicks <= secondTicks)
      {
        return long.MaxValue - 1;
      }
      if (firstTicks <= 0 && long.MinValue - firstTicks >= secondTicks)
      {
        return long.MinValue + 1;
      }
      return checked(firstTicks + secondTicks);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static TimeSpan Max(TimeSpan first, TimeSpan second)
    {
      return first >= second ? first : second;
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static TimeSpan Min(TimeSpan first, TimeSpan second)
    {
      return first < second ? first : second;
    }
  }
}
