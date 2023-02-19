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
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static byte[] Bytes(this IConversion<PhysicalAddress> conversion, string error = null) => conversion.To(address => address.ToBytes(), error);
}