using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Task"/> types.</para>
/// </summary>
/// <seealso cref="Task"/>
/// <seealso cref="Task{TResult}"/>
public static class TaskConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="Task"/> instance to the instance of <see cref="System.Threading.Tasks.ValueTask"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTask{T}(IConversion{Task{T}}, string)"/>
  public static ValueTask ValueTask(this IConversion<Task> conversion, string error = null) => conversion.To(task => task.ToValueTask(), error);

  /// <summary>
  ///   <para>Converts given <see cref="Task{T}"/> instance to the instance of <see cref="System.Threading.Tasks.ValueTask{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTask(IConversion{Task}, string)"/>
  public static ValueTask<T> ValueTask<T>(this IConversion<Task<T>> conversion, string error = null) => conversion.To(task => task.ToValueTask(), error);
}