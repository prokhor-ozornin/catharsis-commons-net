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
  TSource Source { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  IConversion<TSource> Parameter(string name, object value);

  /// <summary>
  ///   <para></para>
  /// </summary>
  IReadOnlyDictionary<string, object> Parameters { get; }
}