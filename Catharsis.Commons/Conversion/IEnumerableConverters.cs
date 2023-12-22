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
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the <see cref="T"/> array.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToArraySegment{T}(IEnumerable{T})"/>
  public static T[] Array<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.AsArray(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="IAsyncEnumerable{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToAsyncEnumerable{T}(IEnumerable{T})"/>
  public static IAsyncEnumerable<T> AsyncEnumerable<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToAsyncEnumerable(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.LinkedList{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToLinkedList{T}(IEnumerable{T})"/>
  public static LinkedList<T> LinkedList<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToLinkedList(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="IReadOnlyList{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToReadOnlyList{T}(IEnumerable{T})"/>
  public static IReadOnlyList<T> ReadOnlyList<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToReadOnlyList(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.SortedSet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToSortedSet{T}(IEnumerable{T}, IComparer{T})"/>
  public static SortedSet<T> SortedSet<T>(this IConversion<IEnumerable<T>> conversion, IComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToSortedSet(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.Stack{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToStack{T}(IEnumerable{T})"/>
  public static Stack<T> Stack<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToStack(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.Queue{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToQueue{T}(IEnumerable{T})"/>
  public static Queue<T> Queue<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToQueue(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.ArraySegment{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToArraySegment{T}(IEnumerable{T})"/>
  public static ArraySegment<T> ArraySegment<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToArraySegment(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.Memory{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToMemory{T}(IEnumerable{T})"/>
  public static Memory<T> Memory<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemory(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.ReadOnlyMemory{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToReadOnlyMemory{T}(IEnumerable{T})"/>
  public static ReadOnlyMemory<T> ReadOnlyMemory<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToReadOnlyMemory(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{Range}"/> instance to the instance of <see cref="IEnumerable{int}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToRange(IEnumerable{Range})"/>
  public static IEnumerable<int> Range(this IConversion<IEnumerable<Range>> conversion, string error = null) => conversion.To(sequence => sequence.ToRange(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="IEnumerable{(Task, int)}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTuple{TKey, TValue}(IConversion{IEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, string)"/>
  /// <seealso cref="IEnumerableExtensions.ToValueTuple{T}(IEnumerable{T})"/>
  public static IEnumerable<(T item, int index)> ValueTuple<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToValueTuple(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{TValue}"/> instance to the instance of <see cref="IEnumerable{(TKey, TValue)}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting tuple's first element.</typeparam>
  /// <typeparam name="TValue">Type of the resulting tuple's second element.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTuple{T}(IConversion{IEnumerable{T}}, string)"/>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToValueTuple(key, comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{(TKey, TValue)}"/> instance to the instance of <see cref="System.Collections.Generic.Dictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToDictionary{TKey, TValue}(IEnumerable{(TKey Key, TValue Value)}, IEqualityComparer{TKey})"/>
  public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>(this IConversion<IEnumerable<(TKey Key, TValue Value)>> conversion, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToDictionary(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{(TKey, TValue)}"/> instance to the instance of <see cref="IReadOnlyDictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToReadOnlyDictionary{TKey, TValue}(IEnumerable{(TKey Key, TValue Value)}, IEqualityComparer{TKey})"/>
  public static IReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary<TKey, TValue>(this IConversion<IEnumerable<(TKey Key, TValue Value)>> conversion, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionary(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{byte}"/> instance to the instance of <see cref="System.IO.MemoryStream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IEnumerable{byte}}, CancellationToken, string)"/>
  /// <seealso cref="IEnumerableExtensions.ToMemoryStream(IEnumerable{byte})"/>
  public static MemoryStream MemoryStream(this IConversion<IEnumerable<byte>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemoryStream(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IEnumerable{byte}"/> instance to the instance of <see cref="Task{MemoryStream}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStream(IConversion{IEnumerable{byte}}, string)"/>
  /// <seealso cref="IEnumerableExtensions.ToMemoryStreamAsync(IEnumerable{byte}, CancellationToken)"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IEnumerable<byte>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{byte}"/> instance to the instance of <see cref="System.IO.MemoryStream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IEnumerable{byte[]}}, CancellationToken, string)"/>
  /// <seealso cref="IEnumerableExtensions.ToMemoryStream(IEnumerable{byte[]})"/>
  public static MemoryStream MemoryStream(this IConversion<IEnumerable<byte[]>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemoryStream(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IEnumerable{byte[]}"/> instance to the instance of <see cref="Task{MemoryStream}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IEnumerable{byte}}, CancellationToken, string)"/>
  /// <seealso cref="IEnumerableExtensions.ToMemoryStreamAsync(IEnumerable{byte[]}, CancellationToken)"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IEnumerable<byte[]>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation), error);

#if NET7_0_OR_GREATER
  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="IReadOnlySet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToReadOnlySet{T}(IEnumerable{T}, IEqualityComparer{T})"/>
  public static IReadOnlySet<T> ReadOnlySet<T>(this IConversion<IEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToReadOnlySet(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{(TElement, TPriority)}"/> instance to the instance of <see cref="System.Collections.Generic.PriorityQueue{TElement, TPriority}"/> type.</para>
  /// </summary>
  /// <typeparam name="TElement"></typeparam>
  /// <typeparam name="TPriority"></typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToPriorityQueue{TElement, TPriority}(IEnumerable{(TElement Element, TPriority Priority)}, IComparer{TPriority})"/>
  public static PriorityQueue<TElement, TPriority> PriorityQueue<TElement, TPriority>(this IConversion<IEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null, string error = null) => conversion.To(sequence => sequence.ToPriorityQueue(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableQueue{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IEnumerableExtensions.ToImmutableQueue{T}(IEnumerable{T})"/>
  public static ImmutableQueue<T> ImmutableQueue<T>(this IConversion<IEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToImmutableQueue(), error);
  #endif
}