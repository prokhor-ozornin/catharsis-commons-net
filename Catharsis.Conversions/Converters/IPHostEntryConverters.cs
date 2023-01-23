using System.Net;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class IPHostEntryConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<IPAddress> Enumerable(this IConversion<IPHostEntry> conversion) => conversion.To(host => host.ToEnumerable());
}