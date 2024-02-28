using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class IReadOnlyAttributesExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="attributes"></param>
  /// <param name="name"></param>
  /// <param name="defaultValue"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static T Get<T>(this IReadOnlyAttributes attributes, string name, T defaultValue = default)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    return (T) attributes.GetValueOrDefault(name, defaultValue);
  }
}