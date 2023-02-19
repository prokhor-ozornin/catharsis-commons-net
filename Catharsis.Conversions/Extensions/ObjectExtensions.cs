namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class ObjectExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  public static IConversion<T> Convert<T>(this T source) => source is not null ? new Conversion<T>(source) : throw new ArgumentNullException(nameof(source));
}