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
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="options">Task creation flags.</param>
  /// <param name="cancellation">Cancellation token to be observed by the new task.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Task(IConversion{Action{object}}, object, TaskCreationOptions, CancellationToken, string)"/>
  /// <seealso cref="ActionExtensions.ToTask(Action, TaskCreationOptions, CancellationToken)"/>
  public static Task Task(this IConversion<Action> conversion, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(action => action.ToTask(options, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="Action{Object}"/> instance to the instance of <see cref="System.Threading.Tasks.Task"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="state">Data to be used by the task.</param>
  /// <param name="options">Creation options for the new task.</param>
  /// <param name="cancellation">Cancellation token to be observed by the new task.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Task(IConversion{Action}, TaskCreationOptions, CancellationToken, string)"/>
  /// <seealso cref="ActionExtensions.ToTask(Action{object}, object, TaskCreationOptions, CancellationToken)"/>
  public static Task Task(this IConversion<Action<object>> conversion, object state, TaskCreationOptions options = TaskCreationOptions.None, CancellationToken cancellation = default, string error = null) => conversion.To(action => action.ToTask(state, options, cancellation), error);
}