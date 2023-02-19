namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="TSource"></typeparam>
public interface IConversion<out TSource>
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TResult"></typeparam>
  /// <param name="converter"></param>
  /// <param name="error">Error description phrase for a failed conversion.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  TResult To<TResult>(Func<TSource, TResult> converter, string error = null);
}