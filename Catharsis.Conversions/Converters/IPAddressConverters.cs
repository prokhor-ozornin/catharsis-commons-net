using System.Net;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class IPAddressConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static byte[] Bytes(this IConversion<IPAddress> conversion) => conversion.To(address => address.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IPAddress IpAddress(this IConversion<long> conversion) => conversion.To(value => new IPAddress(value));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IPAddress IpAddress(this IConversion<uint> conversion) => conversion.To(value => new IPAddress(value));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IPHostEntry IpHost(this IConversion<IPAddress> conversion) => conversion.To(address => address.ToIpHost());
}