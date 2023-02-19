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
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<IPAddress> conversion, string error = null) => conversion.To(address => address.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="IpAddress(IConversion{uint}, string)"/>
  public static IPAddress IpAddress(this IConversion<long> conversion, string error = null) => conversion.To(value => new IPAddress(value), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="IpAddress(IConversion{long}, string)"/>
  public static IPAddress IpAddress(this IConversion<uint> conversion, string error = null) => conversion.To(value => new IPAddress(value), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IPHostEntry IpHost(this IConversion<IPAddress> conversion, string error = null) => conversion.To(address => address.ToIpHost(), error);
}