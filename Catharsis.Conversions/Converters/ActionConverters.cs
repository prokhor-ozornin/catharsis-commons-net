using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Action"/> types.</para>
/// </summary>
/// <seealso cref="Action"/>
/// <seealso cref="Action{T}"/>
public static class ActionConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="Action"/> instance to the instance of <see cref="System.Threading.Tasks.Task"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to use.</param>
  /// <param name="options">Task creation flags.</param>
  /// <param name="cancellation">Task cancellation token.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// 
  /// <seealso cref="Task(IConversion{Action{object}}, object, TaskCreationOptions, CancellationToken)"/>
  public static Task Task(this IConversion<Action> conversion, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(action => action.ToTask(options, cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="state"></param>
  /// <param name="options"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Task(IConversion{Action}, TaskCreationOptions, CancellationToken, string)"/>
  public static Task Task(this IConversion<Action<object>> conversion, object state, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(action => action.ToTask(state, options, cancellation), error);
}