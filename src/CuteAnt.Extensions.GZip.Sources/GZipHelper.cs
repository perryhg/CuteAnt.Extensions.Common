using System;
using System.IO;
using System.IO.Compression;
using CuteAnt.Buffers;

namespace CuteAnt.IO
{
  internal static class GZipHelper
  {
    internal static byte[] Compression(byte[] data)
    {
      if (null == data) { throw new ArgumentNullException(nameof(data)); }

      using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
      {
        var outputStream = pooledOutputStream.Object;
        outputStream.Reinitialize(data.Length);
#if NET40
        using (var gzWriter = new GZipStream(outputStream, CompressionMode.Compress, true))
#else
        using (var gzWriter = new GZipStream(outputStream, CompressionLevel.Fastest, true))
#endif
        {
          gzWriter.Write(data, 0, data.Length);
        }

        return outputStream.ToByteArray();
      }
    }

    internal static ArraySegmentWrapper<byte> Compression(byte[] data, BufferManager bufferManager)
    {
      if (null == data) { throw new ArgumentNullException(nameof(data)); }
      if (null == bufferManager) { throw new ArgumentNullException(nameof(bufferManager)); }

      using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
      {
        var outputStream = pooledOutputStream.Object;
        outputStream.Reinitialize(data.Length, bufferManager);
#if NET40
        using (var gzWriter = new GZipStream(outputStream, CompressionMode.Compress, true))
#else
        using (var gzWriter = new GZipStream(outputStream, CompressionLevel.Fastest, true))
#endif
        {
          gzWriter.Write(data, 0, data.Length);
        }

        return outputStream.ToArraySegment();
      }
    }

    internal static byte[] Compression(byte[] data, int offset, int count)
    {
      if (null == data) { throw new ArgumentNullException(nameof(data)); }
      if (offset < 0) { throw new ArgumentOutOfRangeException(nameof(offset), "Non-negative number required."); }
      if (count < 0) { throw new ArgumentOutOfRangeException(nameof(count), "Non-negative number required."); }
      if (data.Length - offset < count) { throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."); }

      using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
      {
        var outputStream = pooledOutputStream.Object;
        outputStream.Reinitialize(count);
#if NET40
        using (var gzWriter = new GZipStream(outputStream, CompressionMode.Compress, true))
#else
        using (var gzWriter = new GZipStream(outputStream, CompressionLevel.Fastest, true))
#endif
        {
          gzWriter.Write(data, offset, count);
        }

        return outputStream.ToByteArray();
      }
    }

    internal static ArraySegmentWrapper<byte> Compression(byte[] data, int offset, int count, BufferManager bufferManager)
    {
      if (null == data) { throw new ArgumentNullException(nameof(data)); }
      if (offset < 0) { throw new ArgumentOutOfRangeException(nameof(offset), "Non-negative number required."); }
      if (count < 0) { throw new ArgumentOutOfRangeException(nameof(count), "Non-negative number required."); }
      if (data.Length - offset < count) { throw new ArgumentException("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection."); }
      if (null == bufferManager) { throw new ArgumentNullException(nameof(bufferManager)); }

      using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
      {
        var outputStream = pooledOutputStream.Object;
        outputStream.Reinitialize(count, bufferManager);
#if NET40
        using (var gzWriter = new GZipStream(outputStream, CompressionMode.Compress, true))
#else
        using (var gzWriter = new GZipStream(outputStream, CompressionLevel.Fastest, true))
#endif
        {
          gzWriter.Write(data, offset, count);
        }

        return outputStream.ToArraySegment();
      }
    }

    internal static byte[] Decompression(byte[] compressedData)
    {
      if (null == compressedData) { throw new ArgumentNullException(nameof(compressedData)); }

      var bufferManager = BufferManager.GlobalManager;
      var bufferSize = compressedData.Length * 2;
      var buffer = bufferManager.TakeBuffer(bufferSize);
      try
      {
        using (var inputStream = new MemoryStream(compressedData, 0, compressedData.Length))
        using (var gzReader = new GZipStream(inputStream, CompressionMode.Decompress))
        using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
        {
          var outputStream = pooledOutputStream.Object;
          outputStream.Reinitialize(bufferSize, bufferManager);
          var readBytes = 0;
          while ((readBytes = gzReader.Read(buffer, 0, buffer.Length)) > 0)
          {
            outputStream.Write(buffer, 0, readBytes);
          }

          return outputStream.ToByteArray();
        }
      }
      finally
      {
        bufferManager.ReturnBuffer(buffer);
      }
    }

    internal static ArraySegmentWrapper<byte> Decompression(byte[] compressedData, BufferManager bufferManager)
    {
      if (null == compressedData) { throw new ArgumentNullException(nameof(compressedData)); }
      if (null == bufferManager) { throw new ArgumentNullException(nameof(bufferManager)); }

      var bufferSize = compressedData.Length * 2;
      var buffer = bufferManager.TakeBuffer(bufferSize);
      try
      {
        using (var inputStream = new MemoryStream(compressedData, 0, compressedData.Length))
        using (var gzReader = new GZipStream(inputStream, CompressionMode.Decompress))
        using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
        {
          var outputStream = pooledOutputStream.Object;
          outputStream.Reinitialize(bufferSize, bufferManager);
          var readBytes = 0;
          while ((readBytes = gzReader.Read(buffer, 0, buffer.Length)) > 0)
          {
            outputStream.Write(buffer, 0, readBytes);
          }

          return outputStream.ToArraySegment();
        }
      }
      finally
      {
        bufferManager.ReturnBuffer(buffer);
      }
    }

    internal static byte[] Decompression(byte[] compressedData, int offset, int count)
    {
      using (var inputStream = new MemoryStream(compressedData, offset, count))
      {
        var bufferManager = BufferManager.GlobalManager;
        var bufferSize = compressedData.Length * 2;
        var buffer = bufferManager.TakeBuffer(bufferSize);
        try
        {
          using (var gzReader = new GZipStream(inputStream, CompressionMode.Decompress))
          using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
          {
            var outputStream = pooledOutputStream.Object;
            outputStream.Reinitialize(bufferSize, bufferManager);
            var readBytes = 0;
            while ((readBytes = gzReader.Read(buffer, 0, buffer.Length)) > 0)
            {
              outputStream.Write(buffer, 0, readBytes);
            }

            return outputStream.ToByteArray();
          }
        }
        finally
        {
          bufferManager.ReturnBuffer(buffer);
        }
      }
    }

    internal static ArraySegmentWrapper<byte> Decompression(byte[] compressedData, int offset, int count, BufferManager bufferManager)
    {
      if (null == bufferManager) { throw new ArgumentNullException(nameof(bufferManager)); }

      using (var inputStream = new MemoryStream(compressedData, offset, count))
      {
        var bufferSize = compressedData.Length * 2;
        var buffer = bufferManager.TakeBuffer(bufferSize);
        try
        {
          using (var gzReader = new GZipStream(inputStream, CompressionMode.Decompress))
          using (var pooledOutputStream = BufferManagerOutputStreamManager.Create())
          {
            var outputStream = pooledOutputStream.Object;
            outputStream.Reinitialize(bufferSize, bufferManager);
            var readBytes = 0;
            while ((readBytes = gzReader.Read(buffer, 0, buffer.Length)) > 0)
            {
              outputStream.Write(buffer, 0, readBytes);
            }

            return outputStream.ToArraySegment();
          }
        }
        finally
        {
          bufferManager.ReturnBuffer(buffer);
        }
      }
    }
  }
}
