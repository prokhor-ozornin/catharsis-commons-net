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
  ///   <para>Converts given <see cref="IPHostEntry"/> instance to the instance of <see cref="IEnumerable{IPAddress}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static IEnumerable<IPAddress> Enumerable(this IConversion<IPHostEntry> conversion, string error = null) => conversion.To(host => host.ToEnumerable(), error);
}