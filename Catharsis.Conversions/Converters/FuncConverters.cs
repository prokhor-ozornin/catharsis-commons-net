using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class FuncConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<T> Task<T>(this IConversion<Func<T>> conversion, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default) => conversion.To(function => function.ToTask(options, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="state"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<T> Task<T>(this IConversion<Func<object, T>> conversion, object state, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default) => conversion.To(function => function.ToTask(state, options, cancellation));
}