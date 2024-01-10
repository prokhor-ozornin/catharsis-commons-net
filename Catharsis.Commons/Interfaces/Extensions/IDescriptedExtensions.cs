using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class IDescriptedExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="sequence"></param>
  /// <returns></returns>
  public static IEnumerable<T> WithDescription<T>(this IEnumerable<T> sequence, string description) where T : IDescripted
  {
    if (sequence is null) throw new ArgumentNullException(nameof(sequence));
    if (description is null) throw new ArgumentNullException(nameof(description));

    return description.IsEmpty() ? sequence : sequence.Where(element => element.Description.ToLowerInvariant().Contains(description.ToLowerInvariant()));
  }
}