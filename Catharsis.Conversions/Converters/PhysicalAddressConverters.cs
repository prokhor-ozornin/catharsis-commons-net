using System.Net.NetworkInformation;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="PhysicalAddress"/> type.</para>
/// </summary>
/// <seealso cref="PhysicalAddress"/>
public static class PhysicalAddressConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<PhysicalAddress> conversion, string error = null) => conversion.To(address => address.ToBytes(), error);
}