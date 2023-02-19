using System.Net;
using System.Net.Sockets;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="UdpClient"/> type.</para>
/// </summary>
/// <seealso cref="UdpClient"/>
public static class UdpClientConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{UdpClient}, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<UdpClient> conversion, string error = null) => conversion.To(udp => udp.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{UdpClient}, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<UdpClient> conversion, string error = null) => conversion.To(udp => udp.ToBytesAsync(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="endpoint"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<byte[]> Enumerable(this IConversion<UdpClient> conversion, IPEndPoint endpoint = null, bool close = false, string error = null) => conversion.To(udp => udp.ToEnumerable(endpoint, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<UdpClient> conversion, bool close = false, string error = null) => conversion.To(udp => udp.ToAsyncEnumerable(close), error);
}