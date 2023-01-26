using System.Net;
using System.Net.Sockets;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class UdpClientConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{UdpClient})"/>
  public static IEnumerable<byte> Bytes(this IConversion<UdpClient> conversion) => conversion.To(udp => udp.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{UdpClient})"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<UdpClient> conversion) => conversion.To(udp => udp.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="endpoint"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<byte[]> Enumerable(this IConversion<UdpClient> conversion, IPEndPoint endpoint = null, bool close = false) => conversion.To(udp => udp.ToEnumerable(endpoint, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<UdpClient> conversion, bool close = false) => conversion.To(udp => udp.ToAsyncEnumerable(close));
}