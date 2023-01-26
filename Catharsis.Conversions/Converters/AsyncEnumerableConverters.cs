using Catharsis.Extensions;

#if NET7_0_OR_GREATER
using System.Collections.Immutable;
#endif

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="IAsyncEnumerable{T}"/>
public static class AsyncEnumerableConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<T> Enumerable<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToEnumerable());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static T[] Array<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToArray());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Array{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<T[]> ArrayAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToArrayAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static List<T> List<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToList());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="List{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<List<T>> ListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToListAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="LinkedListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static LinkedList<T> LinkedList<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToLinkedList());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="LinkedList{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<LinkedList<T>> LinkedListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToLinkedListAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlyListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static IReadOnlyList<T> ReadOnlyList<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToReadOnlyList());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlyList{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<IReadOnlyList<T>> ReadOnlyListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToReadOnlyListAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="HashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken)"/>
  public static HashSet<T> HashSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null) => conversion.To(sequence => sequence.ToHashSet(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="HashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T})"/>
  public static Task<HashSet<T>> HashSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToHashSetAsync(comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="SortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken)"/>
  public static SortedSet<T> SortedSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null) => conversion.To(sequence => sequence.ToSortedSet(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="SortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T})"/>
  public static Task<SortedSet<T>> SortedSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToSortedSetAsync(comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="DictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/>
  public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToDictionary(key, comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Dictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey})"/>
  public static Task<Dictionary<TKey, TValue>> DictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, CancellationToken cancellation = default) where TKey : notnull => conversion.To(sequence => sequence.ToDictionaryAsync(key, comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlyDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/>
  public static IReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionary(key, comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlyDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey})"/>
  public static Task<IReadOnlyDictionary<TKey, TValue>> ReadOnlyDictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, CancellationToken cancellation = default) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionaryAsync(key, comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTuple{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey})"/>
  public static IEnumerable<(T item, int index)> ValueTuple<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToValueTuple());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTuple{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToValueTuple(key, comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTupleAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, CancellationToken)"/>
  public static Task<IEnumerable<(T item, int index)>> ValueTupleAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToValueTupleAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTupleAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static Task<IEnumerable<(TKey Key, TValue Value)>> ValueTupleAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null, CancellationToken cancellation = default) where TKey : notnull => conversion.To(sequence => sequence.ToValueTupleAsync(key, comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="StackAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static Stack<T> Stack<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToStack());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Stack{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<Stack<T>> StackAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToStackAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="QueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static Queue<T> Queue<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToQueue());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Queue{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<Queue<T>> QueueAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToQueueAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IAsyncEnumerable{byte}}, CancellationToken)"/>
  public static MemoryStream MemoryStream(this IConversion<IAsyncEnumerable<byte>> conversion) => conversion.To(sequence => sequence.ToMemoryStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStream(IConversion{IAsyncEnumerable{byte}})"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IAsyncEnumerable<byte>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IAsyncEnumerable{byte[]}}, CancellationToken)"/>
  public static MemoryStream MemoryStream(this IConversion<IAsyncEnumerable<byte[]>> conversion) => conversion.To(sequence => sequence.ToMemoryStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStream(IConversion{IAsyncEnumerable{byte[]}})"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IAsyncEnumerable<byte[]>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation));

  #if NET7_0_OR_GREATER
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlySetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken)"/>
  public static IReadOnlySet<T> ReadOnlySet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null) => conversion.To(sequence => sequence.ToReadOnlySet(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlySet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T})"/>
  public static Task<IReadOnlySet<T>> ReadOnlySetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToReadOnlySetAsync(comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TElement"></typeparam>
  /// <typeparam name="TPriority"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="PriorityQueueAsync{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, CancellationToken)"/>
  public static PriorityQueue<TElement, TPriority> PriorityQueue<TElement, TPriority>(this IConversion<IAsyncEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null) => conversion.To(sequence => sequence.ToPriorityQueue(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TElement"></typeparam>
  /// <typeparam name="TPriority"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="PriorityQueue{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority})"/>
  public static Task<PriorityQueue<TElement, TPriority>> PriorityQueueAsync<TElement, TPriority>(this IConversion<IAsyncEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToPriorityQueueAsync(comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static ImmutableArray<T> ImmutableArray<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToImmutableArray());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableArray{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<ImmutableArray<T>> ImmutableArrayAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToImmutableArrayAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static ImmutableList<T> ImmutableList<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToImmutableList());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableList{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<ImmutableList<T>> ImmutableListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToImmutableListAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableHashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken)"/>
  public static ImmutableHashSet<T> ImmutableHashSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null) => conversion.To(sequence => sequence.ToImmutableHashSet(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableHashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T})"/>
  public static Task<ImmutableHashSet<T>> ImmutableHashSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToImmutableHashSetAsync(comparer, cancellation));

  /// <summary>
  ///  
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableSortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken)"/>
  public static ImmutableSortedSet<T> ImmutableSortedSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null) => conversion.To(sequence => sequence.ToImmutableSortedSet(comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableSortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T})"/>
  public static Task<ImmutableSortedSet<T>> ImmutableSortedSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToImmutableSortedSetAsync(comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/>
  public static ImmutableDictionary<TKey, TValue> ImmutableDictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableDictionary(key, comparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey})"/>
  public static Task<ImmutableDictionary<TKey, TValue>> ImmutableDictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, CancellationToken cancellation = default) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableDictionaryAsync(key, comparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="keyComparer"></param>
  /// <param name="valueComparer"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableSortedDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, CancellationToken)"/>
  public static ImmutableSortedDictionary<TKey, TValue> ImmutableSortedDictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> keyComparer = null, IEqualityComparer<TValue> valueComparer = null) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableSortedDictionary(key, keyComparer, valueComparer));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="keyComparer"></param>
  /// <param name="valueComparer"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableSortedDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue})"/>
  public static Task<ImmutableSortedDictionary<TKey, TValue>> ImmutableSortedDictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> keyComparer = null, IEqualityComparer<TValue> valueComparer = null, CancellationToken cancellation = default) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableSortedDictionaryAsync(key, keyComparer, valueComparer, cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableQueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/>
  public static ImmutableQueue<T> ImmutableQueue<T>(this IConversion<IAsyncEnumerable<T>> conversion) => conversion.To(sequence => sequence.ToImmutableQueue());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ImmutableQueue{T}(IConversion{IAsyncEnumerable{T}})"/>
  public static Task<ImmutableQueue<T>> ImmutableQueueAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default) => conversion.To(sequence => sequence.ToImmutableQueueAsync(cancellation));
  #endif
}