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
  ///   <para>Converts given <see cref="Func{T}"/> instance to the instance of <see cref="System.Threading.Tasks.Task{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Task{T}(IConversion{Func{object, T}}, object, TaskCreationOptions, CancellationToken, string)"/>
  public static Task<T> Task<T>(this IConversion<Func<T>> conversion, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(function => function.ToTask(options, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="Func{object, T}"/> instance to the instance of <see cref="System.Threading.Tasks.Task{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="state"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Task{T}(IConversion{Func{T}}, TaskCreationOptions, CancellationToken, string)"/>
  public static Task<T> Task<T>(this IConversion<Func<object, T>> conversion, object state, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(function => function.ToTask(state, options, cancellation), error);
}