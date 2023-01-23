using System.Collections.Specialized;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class NameValueCollectionConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Dictionary<string, string> Dictionary(this IConversion<NameValueCollection> conversion) => conversion.To(collection => collection.ToDictionary());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<(string Name, string Value)> ValueTuple(this IConversion<NameValueCollection> conversion) => conversion.To(collection => collection.ToValueTuple());
}