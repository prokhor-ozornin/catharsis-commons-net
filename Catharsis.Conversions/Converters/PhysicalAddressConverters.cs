using System.Net.NetworkInformation;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="PhysicalAddress"/>
public static class PhysicalAddressConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<PhysicalAddress> conversion) => conversion.To(address => address.ToBytes());
}