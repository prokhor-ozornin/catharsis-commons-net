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
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTask{T}(IConversion{Task{T}}, string)"/>
  public static ValueTask ValueTask(this IConversion<Task> conversion, string error = null) => conversion.To(task => task.ToValueTask(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTask(IConversion{Task}, string)"/>
  public static ValueTask<T> ValueTask<T>(this IConversion<Task<T>> conversion, string error = null) => conversion.To(task => task.ToValueTask(), error);
}