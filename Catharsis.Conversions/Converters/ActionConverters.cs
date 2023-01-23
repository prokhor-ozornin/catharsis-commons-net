using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class ActionConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task Task(this IConversion<Action> conversion, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default) => conversion.To(action => action.ToTask(options, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="state"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task Task(this IConversion<Action<object>> conversion, object state, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default) => conversion.To(action => action.ToTask(state, options, cancellation));
}