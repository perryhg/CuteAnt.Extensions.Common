using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
#if !NET40
using System.Runtime.CompilerServices;
#endif

namespace System
{
  internal static class CaDatetimeExtensions
  {
    // http://www.csharp-examples.net/string-format-datetime/
    // http://msdn.microsoft.com/en-us/library/system.globalization.datetimeformatinfo.aspx
    private const string TIME_FORMAT = "HH:mm:ss.fff 'GMT'"; // Example: 09:50:43.341 GMT
    private const string DATE_FORMAT = "yyyy-MM-dd"; // Example: 2010-09-02 - Variant of UniversalSorta­bleDateTimePat­tern
    private const string DATETIME_FORMAT = "yyyy-MM-dd " + TIME_FORMAT; // Example: 2010-09-02 09:50:43.341 GMT - Variant of UniversalSorta­bleDateTimePat­tern

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string Format(this DateTime dt)
    {
      return dt.ToString(DATETIME_FORMAT, CultureInfo.InvariantCulture);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string FormatDate(this DateTime dt)
    {
      return dt.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string FormatTime(this DateTime dt)
    {
      return dt.ToString(TIME_FORMAT, CultureInfo.InvariantCulture);
    }

#if !NET40
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
    public static string FormatWith(this DateTime dt, string format)
    {
      if (string.IsNullOrWhiteSpace(format)) { throw new ArgumentNullException(nameof(format)); }
      return dt.ToString(format, CultureInfo.InvariantCulture);
    }
  }
}
