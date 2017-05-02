using System;
using System.Text;

namespace CuteAnt.Buffers
{
  internal static class EncodingExtensions
  {
    public static byte[] GetBytesWithBuffer(this Encoding encoding, Char[] chars, BufferManager bufferManager = null)
    {
      if (null == bufferManager) { bufferManager = BufferManager.GlobalManager; }

      var segment = encoding.GetBufferSegment(chars, bufferManager);
      var bytes = segment.Array;
      if (null == bytes || segment.Count == 0) { return EmptyArray<byte>.Instance; }

      var result = new byte[segment.Count];
      Buffer.BlockCopy(bytes, segment.Offset, result, 0, segment.Count);
      bufferManager.ReturnBuffer(segment);
      return result;
    }

    public static byte[] GetBytesWithBuffer(this Encoding encoding, Char[] chars, Int32 charIndex, Int32 charCount, BufferManager bufferManager = null)
    {
      if (null == bufferManager) { bufferManager = BufferManager.GlobalManager; }

      var segment = encoding.GetBufferSegment(chars, charIndex, charCount, bufferManager);
      var bytes = segment.Array;
      if (null == bytes || segment.Count == 0) { return EmptyArray<byte>.Instance; }

      var result = new byte[segment.Count];
      Buffer.BlockCopy(bytes, segment.Offset, result, 0, segment.Count);
      bufferManager.ReturnBuffer(segment);
      return result;
    }

    public static byte[] GetBytesWithBuffer(this Encoding encoding, String s, BufferManager bufferManager = null)
    {
      if (null == bufferManager) { bufferManager = BufferManager.GlobalManager; }

      var segment = encoding.GetBufferSegment(s, bufferManager);
      var bytes = segment.Array;
      if (null == bytes || segment.Count == 0) { return EmptyArray<byte>.Instance; }

      var result = new byte[segment.Count];
      Buffer.BlockCopy(bytes, segment.Offset, result, 0, segment.Count);
      bufferManager.ReturnBuffer(segment);
      return result;
    }

    public static byte[] GetBytesWithBuffer(this Encoding encoding, String s, Int32 charIndex, Int32 charCount, BufferManager bufferManager = null)
    {
      if (null == bufferManager) { bufferManager = BufferManager.GlobalManager; }

      var segment = encoding.GetBufferSegment(s, charIndex, charCount, bufferManager);
      var bytes = segment.Array;
      if (null == bytes || segment.Count == 0) { return EmptyArray<byte>.Instance; }

      var result = new byte[segment.Count];
      Buffer.BlockCopy(bytes, segment.Offset, result, 0, segment.Count);
      bufferManager.ReturnBuffer(segment);
      return result;
    }
  }
}
