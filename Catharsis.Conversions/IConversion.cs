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
  /// <param name="error"></param>
  /// <returns></returns>
  TResult To<TResult>(Func<TSource, TResult> converter, string error = null);
}