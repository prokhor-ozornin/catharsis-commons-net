using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class INamedExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="sequence"></param>
  /// <param name="name"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<T> WithName<T>(this IEnumerable<T> sequence, string name) where T : INamed
  {
    if (sequence is null) throw new ArgumentNullException(nameof(sequence));
    if (name is null) throw new ArgumentNullException(nameof(name));

    return name.IsEmpty() ? sequence : sequence.Where(element => element.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()));
  }
}