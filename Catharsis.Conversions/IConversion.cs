namespace Catharsis.Conversions;

/// <summary>
///   <para>A custom conversion for an object between a source and destination types.</para>
/// </summary>
/// <typeparam name="TSource">Type of source object.</typeparam>
public interface IConversion<out TSource>
{
  /// <summary>
  ///   <para>Performs a conversion of a source object to a target type, using a specified delegate method.</para>
  /// </summary>
  /// <typeparam name="TResult">Type of resulting object.</typeparam>
  /// <param name="converter">Conversion method to use.</param>
  /// <param name="error">Error description phrase for a failed conversion.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  TResult To<TResult>(Func<TSource, TResult> converter, string error = null);
}