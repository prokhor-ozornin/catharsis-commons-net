namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class ITimedExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="sequence"></param>
  /// <param name="from"></param>
  /// <param name="to"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<T> CreatedIn<T>(this IEnumerable<T> sequence, DateTimeOffset? from = null, DateTimeOffset? to = null) where T : ITimed
  {
    if (sequence is null) throw new ArgumentNullException(nameof(sequence));

    if (from is not null)
    {
      sequence = sequence.Where(element => element.CreatedOn >= from);
    }

    if (to is not null)
    {
      sequence = sequence.Where(element => element.CreatedOn <= to);
    }    

    return sequence;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="sequence"></param>
  /// <param name="from"></param>
  /// <param name="to"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<T> UpdatedIn<T>(this IEnumerable<T> sequence, DateTimeOffset? from = null, DateTimeOffset? to = null) where T : ITimed
  {
    if (sequence is null) throw new ArgumentNullException(nameof(sequence));

    if (from is not null)
    {
      sequence = sequence.Where(element => element.UpdatedOn >= from);
    }

    if (to is not null)
    {
      sequence = sequence.Where(element => element.UpdatedOn <= to);
    }

    return sequence;
  }
}