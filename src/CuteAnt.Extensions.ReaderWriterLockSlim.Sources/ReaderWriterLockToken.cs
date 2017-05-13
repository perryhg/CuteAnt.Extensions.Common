using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Threading
{
  internal struct ReaderWriterLockToken : IDisposable
  {
    private ReaderWriterLockSlim _rwlock;
    private Boolean _isReadMode;

    public ReaderWriterLockToken(ReaderWriterLockSlim rwlock, Boolean isReadMode)
    {
      _rwlock = rwlock;
      _isReadMode = isReadMode;
      if (_rwlock == null) { return; }
      if (_isReadMode)
      {
        _rwlock.EnterReadLock();
      }
      else
      {
        _rwlock.EnterWriteLock();
      }
    }

    public void Dispose()
    {
      var rwlock = _rwlock;
      _rwlock = null;

      if (rwlock != null)
      {
        try
        {
          if (_isReadMode)
          {
            rwlock.ExitReadLock();
          }
          else
          {
            rwlock.ExitWriteLock();
          }
        }
        catch { }
      }
    }
  }
}
