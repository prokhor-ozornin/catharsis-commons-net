namespace Catharsis.Commons;

/// <summary>
///   <para>A set of extension methods for the <see cref="ILogicalCollection{T}"/> interface.</para>
/// </summary>
public static class ILogicalCollectionExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="collection"></param>
  /// <param name="item"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ILogicalCollection<T> And<T>(this ILogicalCollection<T> collection, T item)
  {
    if (collection is null) throw new ArgumentNullException(nameof(collection));

    collection.Add((LogicalOperation.And, item));
    
    return collection;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="collection"></param>
  /// <param name="item"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ILogicalCollection<T> Or<T>(this ILogicalCollection<T> collection, T item)
  {
    if (collection is null) throw new ArgumentNullException(nameof(collection));

    collection.Add((LogicalOperation.Or, item));

    return collection;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="collection"></param>
  /// <param name="item"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ILogicalCollection<T> Not<T>(this ILogicalCollection<T> collection, T item)
  {
    if (collection is null) throw new ArgumentNullException(nameof(collection));

    collection.Add((LogicalOperation.Not, item));

    return collection;
  }
}