using System.Collections.Specialized;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="NameValueCollection"/> type.</para>
/// </summary>
/// <seealso cref="NameValueCollection"/>
public static class NameValueCollectionConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="NameValueCollection"/> instance to the instance of <see cref="Dictionary{string, String}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="NameValueCollectionExtensions.ToDictionary(NameValueCollection)"/>
  public static Dictionary<string, string> Dictionary(this IConversion<NameValueCollection> conversion, string error = null) => conversion.To(collection => collection.ToDictionary(), error);

  /// <summary>
  ///   <para>Converts given <see cref="NameValueCollection"/> instance to the instance of <see cref="IEnumerable{(string, string)}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="NameValueCollectionExtensions.ToValueTuple(NameValueCollection)"/>
  public static IEnumerable<(string Name, string Value)> ValueTuple(this IConversion<NameValueCollection> conversion, string error = null) => conversion.To(collection => collection.ToValueTuple(), error);
}