using System.Net.Sockets;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class TcpClientConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<byte> Bytes(this IConversion<TcpClient> conversion) => conversion.To(tcp => tcp.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<TcpClient> conversion) => conversion.To(tcp => tcp.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<byte> Enumerable(this IConversion<TcpClient> conversion, bool close = false) => conversion.To(tcp => tcp.ToEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<byte[]> Enumerable(this IConversion<TcpClient> conversion, int count, bool close = false) => conversion.To(tcp => tcp.ToEnumerable(count, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<TcpClient> conversion, bool close = false) => conversion.To(tcp => tcp.ToAsyncEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<TcpClient> conversion, int count, bool close = false) => conversion.To(tcp => tcp.ToAsyncEnumerable(count, close));
}