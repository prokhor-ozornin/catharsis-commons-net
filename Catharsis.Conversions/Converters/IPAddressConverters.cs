using System.Net;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters to/from <see cref="IPAddress"/> type.</para>
/// </summary>
/// <seealso cref="IPAddress"/>
public static class IPAddressConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<IPAddress> conversion) => conversion.To(address => address.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="IpAddress(IConversion{uint})"/>
  public static IPAddress IpAddress(this IConversion<long> conversion) => conversion.To(value => new IPAddress(value));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="IpAddress(IConversion{long})"/>
  public static IPAddress IpAddress(this IConversion<uint> conversion) => conversion.To(value => new IPAddress(value));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IPHostEntry IpHost(this IConversion<IPAddress> conversion) => conversion.To(address => address.ToIpHost());
}