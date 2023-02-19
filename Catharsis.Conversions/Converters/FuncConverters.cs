using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Func{T}"/> types.</para>
/// </summary>
/// <seealso cref="Func{TResult}"/>
/// <seealso cref="Func{T, TResult}"/>
public static class FuncConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Task{T}(IConversion{Func{object, T}}, object, TaskCreationOptions, CancellationToken, string)"/>
  public static Task<T> Task<T>(this IConversion<Func<T>> conversion, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(function => function.ToTask(options, cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="state"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Task{T}(IConversion{Func{T}}, TaskCreationOptions, CancellationToken, string)"/>
  public static Task<T> Task<T>(this IConversion<Func<object, T>> conversion, object state, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(function => function.ToTask(state, options, cancellation), error);
}