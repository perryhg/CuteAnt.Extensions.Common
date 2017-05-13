using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Threading
{
  internal static class ReaderWriterLockSlimExtensions
  {
    internal static IDisposable CreateToken(this ReaderWriterLockSlim rwlock, bool isReadMode = false)
    {
      if (null == rwlock) { throw new ArgumentNullException(nameof(rwlock)); }
      return new ReaderWriterLockToken(rwlock, isReadMode);
    }
  }
}
