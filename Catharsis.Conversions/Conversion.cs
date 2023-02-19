using Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="TSource"></typeparam>
public class Conversion<TSource> : IConversion<TSource>
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public TSource Source { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="source"></param>
  public Conversion(TSource source) => Source = source ?? throw new ArgumentNullException(nameof(source));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TResult"></typeparam>
  /// <param name="converter"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
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