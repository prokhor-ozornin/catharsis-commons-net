namespace Catharsis.Commons;

/// <summary>
///   <para>Set of extension methods for <see cref="IConversion{TSource}"/> interface.</para>
/// </summary>
/// <seealso cref="IConversion{TSource}"/>
public static class IConversionExtensions
{
  /// <summary>
  ///   <para>Checks whether a given conversion is not a <see langword="null"/> reference.</para>
  /// </summary>
  /// <param name="conversion">Conversion instance.</param>
  /// <typeparam name="TSource">Type of source object.</typeparam>
  /// <returns>Back reference to the given <paramref name="conversion"/> instance.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  public static IConversion<TSource> To<TSource>(this IConversion<TSource> conversion) => conversion ?? throw new ArgumentNullException(nameof(conversion));
}