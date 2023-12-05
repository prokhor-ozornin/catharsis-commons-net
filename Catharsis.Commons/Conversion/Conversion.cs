namespace Catharsis.Commons;

/// <summary>
///   <para>Base class of a conversion for an object between a source and destination types.</para>
/// </summary>
/// <typeparam name="TSource">Type of source object.</typeparam>
public class Conversion<TSource> : IConversion<TSource>
{
  /// <summary>
  ///   <para>Source object.</para>
  /// </summary>
  public TSource Source { get; }

  /// <summary>
  ///   <para>Creates a new instance of conversion.</para>
  /// </summary>
  /// <param name="source">Source object.</param>
  public Conversion(TSource source) => Source = source ?? throw new ArgumentNullException(nameof(source));

  /// <summary>
  ///   <para>Performs a conversion of a source object to a target type, using a specified delegate method.</para>
  /// </summary>
  /// <typeparam name="TResult">Type of resulting object.</typeparam>
  /// <param name="converter">Conversion method to use.</param>
  /// <param name="error">Error description phrase for a failed conversion.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public TResult To<TResult>(Func<TSource, TResult> converter, string error = null)
  {
    try
    {
      return converter(Source);
    }
    catch (Exception e)
    {
      throw new InvalidOperationException(error ?? e.Message, e);
    }
  }
}