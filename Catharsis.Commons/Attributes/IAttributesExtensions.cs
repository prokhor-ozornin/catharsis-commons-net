using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class IAttributesExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="attributes"></param>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static T Get<T>(this IAttributes attributes, string name, T value = default)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));
    
    return (T) attributes.GetValueOrDefault(name, value);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="attributes"></param>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static IAttributes Set<T>(this IAttributes attributes, string name, T value)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    attributes.With(name, value);

    return attributes;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="attributes"></param>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static T Retrieve<T>(this IAttributes attributes, string name, T value = default)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    return (T) attributes.SetValueOrDefault(name, value);
  }
}