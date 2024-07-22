namespace Catharsis.Commons;

/// <summary>
///   <para>A set of extension methods for the <see cref="IValidateable"/> interface.</para>
/// </summary>
public static class IValidateableExtensions
{
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

    if (!validateable.IsValid())
    {
      throw exception ?? new InvalidOperationException();
    }

    return validateable;
  }
}