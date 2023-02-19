namespace Catharsis.Conversions;

using Extensions;

#if NET7_0_OR_GREATER
using System.Collections.Immutable;
#endif

/// <summary>
///   <para>Set of converters for <see cref="IEnumerable{T}"/> types.</para>
/// </summary>
/// <seealso cref="IEnumerable{T}"/>
public static class IEnumerableConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static T[] Array<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.AsArray(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IAsyncEnumerable<T> AsyncEnumerable<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToAsyncEnumerable(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static LinkedList<T> LinkedList<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToLinkedList(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IReadOnlyList<T> ReadOnlyList<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToReadOnlyList(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static SortedSet<T> SortedSet<T>(this IConversion<IEnumerable<T>> conversion, IComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToSortedSet(comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Stack<T> Stack<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToStack(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Queue<T> Queue<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToQueue(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ArraySegment<T> ArraySegment<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToArraySegment(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Memory<T> Memory<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemory(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ReadOnlyMemory<T> ReadOnlyMemory<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToReadOnlyMemory(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IEnumerable<int> Range(this IConversion<IEnumerable<Range>> conversion, string error = null) => conversion.To(sequence => sequence.ToRange(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTuple{TKey, TValue}(IConversion{IEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, string)"/>
  public static IEnumerable<(T item, int index)> ValueTuple<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToValueTuple(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="key"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ValueTuple{T}(IConversion{IEnumerable{T}}, string)"/>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToValueTuple(key, comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>(this IConversion<IEnumerable<(TKey Key, TValue Value)>> conversion, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToDictionary(comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TKey"></typeparam>
  /// <typeparam name="TValue"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary<TKey, TValue>(this IConversion<IEnumerable<(TKey Key, TValue Value)>> conversion, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionary(comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IEnumerable{byte}}, CancellationToken, string)"/>
  public static MemoryStream MemoryStream(this IConversion<IEnumerable<byte>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemoryStream(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStream(IConversion{IEnumerable{byte}}, string)"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IEnumerable<byte>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IEnumerable{byte[]}}, CancellationToken, string)"/>
  public static MemoryStream MemoryStream(this IConversion<IEnumerable<byte[]>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemoryStream(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IEnumerable{byte}}, CancellationToken, string)"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IEnumerable<byte[]>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation), error);

  #if NET7_0_OR_GREATER
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IReadOnlySet<T> ReadOnlySet<T>(this IConversion<IEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToReadOnlySet(comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TElement"></typeparam>
  /// <typeparam name="TPriority"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="comparer"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static PriorityQueue<TElement, TPriority> PriorityQueue<TElement, TPriority>(this IConversion<IEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null, string error = null) => conversion.To(sequence => sequence.ToPriorityQueue(comparer), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ImmutableQueue<T> ImmutableQueue<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToImmutableQueue(), error);
  #endif
}