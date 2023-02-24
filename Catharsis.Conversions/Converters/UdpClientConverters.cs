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
  ///   <para>Converts given <see cref="UdpClient"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{UdpClient}, string)"/>
  /// <seealso cref="UdpClientExtensions.ToBytes(UdpClient)"/>
  public static IEnumerable<byte> Bytes(this IConversion<UdpClient> conversion, string error = null) => conversion.To(udp => udp.ToBytes(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="UdpClient"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{UdpClient}, string)"/>
  /// <seealso cref="UdpClientExtensions.ToBytesAsync(UdpClient)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<UdpClient> conversion, string error = null) => conversion.To(udp => udp.ToBytesAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="UdpClient"/> instance to the instance of <see cref="IEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="endpoint"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="UdpClientExtensions.ToEnumerable(UdpClient, IPEndPoint, bool)"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<UdpClient> conversion, IPEndPoint endpoint = null, bool close = false, string error = null) => conversion.To(udp => udp.ToEnumerable(endpoint, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="UdpClient"/> instance to the instance of <see cref="IAsyncEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="UdpClientExtensions.ToEnumerable(UdpClient, IPEndPoint, bool)"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<UdpClient> conversion, bool close = false, string error = null) => conversion.To(udp => udp.ToAsyncEnumerable(close), error);
}