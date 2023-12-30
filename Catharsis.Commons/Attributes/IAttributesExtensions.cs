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
  /// <param name="defaultValue"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static T Get<T>(this IAttributes attributes, string name, T defaultValue = default)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    return (T) (attributes.TryGetValue(name, out var result) ? result : defaultValue);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public static T Set<T>(this IAttributes attributes, string name, T value)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    attributes[name] = value;
    
    return value;
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

    return (T) attributes.GetOrSet(name, value);
  }

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
  public static T Get<T>(this IAttributes<T> attributes, string name, T defaultValue = default)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    return attributes.TryGetValue(name, out var result) ? result : defaultValue;
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
  public static T Set<T>(this IAttributes<T> attributes, string name, T value)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    attributes[name] = value;

    return value;
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
  public static T Retrieve<T>(this IAttributes<T> attributes, string name, T value = default)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    return attributes.GetOrSet(name, value);
  }
}