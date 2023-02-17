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
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTask{T}(IConversion{Task{T}})"/>
  public static ValueTask ValueTask(this IConversion<Task> conversion) => conversion.To(task => task.ToValueTask());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTask(IConversion{Task})"/>
  public static ValueTask<T> ValueTask<T>(this IConversion<Task<T>> conversion) => conversion.To(task => task.ToValueTask());
}