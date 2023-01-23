#if NET7_0
using System.Collections.Immutable;
#endif
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class EnumerableConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static T[] Array<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.AsArray());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<T> AsyncEnumerable<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToAsyncEnumerable());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static LinkedList<T> LinkedList<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToLinkedList());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IReadOnlyList<T> ReadOnlyList<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToReadOnlyList());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  public static SortedSet<T> SortedSet<T>(this IConversion<IEnumerable<T>> conversion, IComparer<T> comparer = null) => conversion.To(sequence => sequence.ToSortedSet(comparer));

#if NET7_0
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  public static IReadOnlySet<T> ReadOnlySet<T>(this IConversion<IEnumerable<T>> conversion, IEqualityComparer<T> comparer = null) => conversion.To(sequence => sequence.ToReadOnlySet(comparer));
#endif

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Stack<T> Stack<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToStack());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Queue<T> Queue<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToQueue());

#if NET7_0
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TElement"></typeparam>
  /// <typeparam name="TPriority"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  public static PriorityQueue<TElement, TPriority> PriorityQueue<TElement, TPriority>(this IConversion<IEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null) => conversion.To(sequence => sequence.ToPriorityQueue(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static ImmutableQueue<T> ImmutableQueue<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToImmutableQueue());
#endif

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static ArraySegment<T> ArraySegment<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToArraySegment());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Memory<T> Memory<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToMemory());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static ReadOnlyMemory<T> ReadOnlyMemory<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToReadOnlyMemory());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<int> Range(this IConversion<IEnumerable<Range>> conversion) => conversion.To(sequence => sequence.ToRange());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<(T item, int index)> ValueTuple<T>(this IConversion<IEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToValueTuple());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToValueTuple(key, comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>(this IConversion<IEnumerable<(TKey Key, TValue Value)>> conversion, IEqualityComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToDictionary(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  public static IReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary<TKey, TValue>(this IConversion<IEnumerable<(TKey Key, TValue Value)>> conversion, IEqualityComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionary(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static MemoryStream MemoryStream(this IConversion<IEnumerable<byte>> conversion) => conversion.To(sequence => sequence.ToMemoryStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IEnumerable<byte>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static MemoryStream MemoryStream(this IConversion<IEnumerable<byte[]>> conversion) => conversion.To(sequence => sequence.ToMemoryStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IEnumerable<byte[]>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation));

}