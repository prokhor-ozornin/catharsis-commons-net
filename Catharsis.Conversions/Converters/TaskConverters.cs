using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class TaskConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static ValueTask ValueTask(this IConversion<Task> conversion) => conversion.To(task => task.ToValueTask());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static ValueTask<T> ValueTask<T>(this IConversion<Task<T>> conversion) => conversion.To(task => task.ToValueTask());
}