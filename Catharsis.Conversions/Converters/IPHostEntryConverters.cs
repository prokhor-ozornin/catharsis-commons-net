using System.Net;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="IPHostEntry"/> type.</para>
/// </summary>
/// <seealso cref="IPHostEntry"/>
public static class IPHostEntryConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<IPAddress> Enumerable(this IConversion<IPHostEntry> conversion) => conversion.To(host => host.ToEnumerable());
}