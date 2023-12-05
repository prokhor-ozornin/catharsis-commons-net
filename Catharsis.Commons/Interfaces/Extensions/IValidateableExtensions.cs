namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class IValidateableExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  public static bool Check(this IValidateable validateable)
  {
    if (validateable is null) throw new ArgumentNullException(nameof(validateable));

    return validateable.Validator();
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="validateable"></param>
  /// <param name="exception"></param>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="InvalidOperationException"></exception>
  public static T Validate<T>(this T validateable, Exception exception = null) where T : IValidateable
  {
    if (validateable is null) throw new ArgumentNullException(nameof(validateable));

    if (!validateable.Validator())
    {
      throw exception ?? new InvalidOperationException();
    }

    return validateable;
  }
}