using Catharsis.Extensions;

#if NET8_0_OR_GREATER
using System.Collections.Immutable;
#endif

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="IAsyncEnumerable{T}"/> type.</para>
/// </summary>
/// <seealso cref="IAsyncEnumerable{T}"/>
public static class IAsyncEnumerableConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="IEnumerable{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="IAsyncEnumerableExtensions.ToEnumerable{T}(IAsyncEnumerable{T})"/>
  public static IEnumerable<T> Enumerable<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToEnumerable(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the <see cref="T"/> array.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToArray{T}(IAsyncEnumerable{T})"/>
  public static T[] Array<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToArray(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{T[]}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Array{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  public static Task<T[]> ArrayAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToArrayAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="List{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  public static List<T> List<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToList(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{List{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="List{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  public static Task<List<T>> ListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToListAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.LinkedList{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="LinkedListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  public static LinkedList<T> LinkedList<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToLinkedList(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{LinkedList{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="LinkedList{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  public static Task<LinkedList<T>> LinkedListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToLinkedListAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="IReadOnlyList{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlyListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  public static IReadOnlyList<T> ReadOnlyList<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToReadOnlyList(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{IReadOnlyList{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlyList{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  public static Task<IReadOnlyList<T>> ReadOnlyListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToReadOnlyListAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.HashSet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="HashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken, string)"/>
  public static HashSet<T> HashSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToHashSet(comparer), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{HashSet{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="HashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, string)"/>
  public static Task<HashSet<T>> HashSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToHashSetAsync(comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.SortedSet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="SortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken, string)"/>
  public static SortedSet<T> SortedSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToSortedSet(comparer), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{SortedSet{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="SortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, string)"/>
  public static Task<SortedSet<T>> SortedSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToSortedSetAsync(comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="System.Collections.Generic.Dictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="DictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken, string)"/>
  public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToDictionary(key, comparer), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="Task{Dictionary{TKey, TValue}}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Dictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, string)"/>
  public static Task<Dictionary<TKey, TValue>> DictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, CancellationToken cancellation = default, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToDictionaryAsync(key, comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="IReadOnlyDictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector's delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlyDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken, string)"/>
  public static IReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionary(key, comparer), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="Task{IReadOnlyDictionary{TKey, TValue}}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlyDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, string)"/>
  public static Task<IReadOnlyDictionary<TKey, TValue>> ReadOnlyDictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, CancellationToken cancellation = default, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToReadOnlyDictionaryAsync(key, comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="IEnumerable{(T, int)}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTuple{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, string)"/>
  public static IEnumerable<(T item, int index)> ValueTuple<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToValueTuple(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="IEnumerable{(TKey, TValue)}"/> type.</para>
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
  /// <seealso cref="ValueTuple{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  public static IEnumerable<(TKey Key, TValue Value)> ValueTuple<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToValueTuple(key, comparer), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{IEnumerable{(T, int)}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTupleAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, CancellationToken, string)"/>
  public static Task<IEnumerable<(T item, int index)>> ValueTupleAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToValueTupleAsync(cancellation), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="Task{IEnumerable{(TKey, TValue)}}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting tuple's first element.</typeparam>
  /// <typeparam name="TValue">Type of the resulting tuple's second element.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ValueTupleAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  public static Task<IEnumerable<(TKey Key, TValue Value)>> ValueTupleAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> comparer = null, CancellationToken cancellation = default, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToValueTupleAsync(key, comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.Stack{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StackAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToStack{T}(IAsyncEnumerable{T})"/>
  public static Stack<T> Stack<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToStack(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{Stack{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Stack{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToStackAsync{T}(IAsyncEnumerable{T}, CancellationToken)"/>
  public static Task<Stack<T>> StackAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToStackAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Generic.Queue{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="QueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToQueue{T}(IAsyncEnumerable{T})"/>
  public static Queue<T> Queue<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToQueue(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{Queue{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Queue{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToQueueAsync{T}(IAsyncEnumerable{T}, CancellationToken)"/>
  public static Task<Queue<T>> QueueAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToQueueAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{byte}"/> instance to the instance of <see cref="System.IO.MemoryStream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IAsyncEnumerable{byte}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToMemoryStream(IAsyncEnumerable{byte})"/>
  public static MemoryStream MemoryStream(this IConversion<IAsyncEnumerable<byte>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemoryStream(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{byte}"/> instance to the instance of <see cref="Task{MemoryStream}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStream(IConversion{IAsyncEnumerable{byte}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToMemoryStreamAsync(IAsyncEnumerable{byte}, CancellationToken)"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IAsyncEnumerable<byte>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{byte[]}"/> instance to the instance of <see cref="System.IO.MemoryStream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStreamAsync(IConversion{IAsyncEnumerable{byte[]}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToMemoryStream(IAsyncEnumerable{byte[]})"/>
  public static MemoryStream MemoryStream(this IConversion<IAsyncEnumerable<byte[]>> conversion, string error = null) => conversion.To(sequence => sequence.ToMemoryStream(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="IAsyncEnumerable{byte[]}"/> instance to the instance of <see cref="Task{MemoryStream}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="MemoryStream(IConversion{IAsyncEnumerable{byte[]}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToMemoryStreamAsync(IAsyncEnumerable{byte[]}, CancellationToken)"/>
  public static Task<MemoryStream> MemoryStreamAsync(this IConversion<IAsyncEnumerable<byte[]>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToMemoryStreamAsync(cancellation), error);

#if NET8_0_OR_GREATER
  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="IReadOnlySet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlySetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToReadOnlySet{T}(IAsyncEnumerable{T}, IEqualityComparer{T})"/>
  public static IReadOnlySet<T> ReadOnlySet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToReadOnlySet(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{IReadOnlySet{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlySet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToReadOnlySetAsync{T}(IAsyncEnumerable{T}, IEqualityComparer{T}, CancellationToken)"/>
  public static Task<IReadOnlySet<T>> ReadOnlySetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToReadOnlySetAsync(comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{(TElement, TPriority)}"/> instance to the instance of <see cref="System.Collections.Generic.PriorityQueue{TElement, TPriority}"/> type.</para>
  /// </summary>
  /// <typeparam name="TElement">Type of elements in the resulting queue.</typeparam>
  /// <typeparam name="TPriority">Type of priority associated with enqueued elements in the resulting queue.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="PriorityQueueAsync{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToPriorityQueue{TElement, TPriority}(IAsyncEnumerable{(TElement Element, TPriority Priority)}, IComparer{TPriority})"/>
  public static PriorityQueue<TElement, TPriority> PriorityQueue<TElement, TPriority>(this IConversion<IAsyncEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null, string error = null) => conversion.To(sequence => sequence.ToPriorityQueue(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{(TElement, TPriority)}"/> instance to the instance of <see cref="Task{PriorityQueue{TElement, TPriority}}"/> type.</para>
  /// </summary>
  /// <typeparam name="TElement">Type of elements in the resulting queue.</typeparam>
  /// <typeparam name="TPriority">Type of priority associated with enqueued elements in the resulting queue.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="PriorityQueue{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToPriorityQueueAsync{TElement, TPriority}(IAsyncEnumerable{(TElement Element, TPriority Priority)}, IComparer{TPriority}, CancellationToken)"/>
  public static Task<PriorityQueue<TElement, TPriority>> PriorityQueueAsync<TElement, TPriority>(this IConversion<IAsyncEnumerable<(TElement Element, TPriority Priority)>> conversion, IComparer<TPriority> comparer = null, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToPriorityQueueAsync(comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableArray{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableArray{T}(IAsyncEnumerable{T})"/>
  public static ImmutableArray<T> ImmutableArray<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToImmutableArray(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{ImmutableArray{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableArray{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableArrayAsync{T}(IAsyncEnumerable{T}, CancellationToken)"/>
  public static Task<ImmutableArray<T>> ImmutableArrayAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToImmutableArrayAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableList{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableList{T}(IAsyncEnumerable{T})"/>
  public static ImmutableList<T> ImmutableList<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToImmutableList(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{ImmutableList{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableList{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableListAsync{T}(IAsyncEnumerable{T}, CancellationToken)"/>
  public static Task<ImmutableList<T>> ImmutableListAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToImmutableListAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableHashSet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableHashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableHashSet{T}(IAsyncEnumerable{T}, IEqualityComparer{T})"/>
  public static ImmutableHashSet<T> ImmutableHashSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToImmutableHashSet(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{ImmutableHashSet{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableHashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableHashSetAsync{T}(IAsyncEnumerable{T}, IEqualityComparer{T}, CancellationToken)"/>
  public static Task<ImmutableHashSet<T>> ImmutableHashSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IEqualityComparer<T> comparer = null, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToImmutableHashSetAsync(comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableSortedSet{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableSortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableSortedSet{T}(IAsyncEnumerable{T}, IComparer{T})"/>
  public static ImmutableSortedSet<T> ImmutableSortedSet<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null, string error = null) => conversion.To(sequence => sequence.ToImmutableSortedSet(comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{ImmutableSortedSet{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="comparer">Comparer to perform comparison of objects.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableSortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableSortedSetAsync{T}(IAsyncEnumerable{T}, IComparer{T}, CancellationToken)"/>
  public static Task<ImmutableSortedSet<T>> ImmutableSortedSetAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, IComparer<T> comparer = null, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToImmutableSortedSetAsync(comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableDictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableDictionary{TKey, TValue}(IAsyncEnumerable{TValue}, Func{TValue, TKey}, IEqualityComparer{TKey})"/>
  public static ImmutableDictionary<TKey, TValue> ImmutableDictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableDictionary(key, comparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="Task{ImmutableDictionary{TKey, TValue}}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="comparer">Comparer to perform comparison of objects for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableDictionaryAsync{TKey, TValue}(IAsyncEnumerable{TValue}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/>
  public static Task<ImmutableDictionary<TKey, TValue>> ImmutableDictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IEqualityComparer<TKey> comparer = null, CancellationToken cancellation = default, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableDictionaryAsync(key, comparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableSortedDictionary{TKey, TValue}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="keyComparer">Comparer to perform comparison of keys.</param>
  /// <param name="valueComparer">Comparer to perform comparison of values for equality.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableSortedDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableSortedDictionary{TKey, TValue}(IAsyncEnumerable{TValue}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue})"/>
  public static ImmutableSortedDictionary<TKey, TValue> ImmutableSortedDictionary<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> keyComparer = null, IEqualityComparer<TValue> valueComparer = null, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableSortedDictionary(key, keyComparer, valueComparer), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{TValue}"/> instance to the instance of <see cref="Task{ImmutableSortedDictionary{TKey, TValue}}"/> type.</para>
  /// </summary>
  /// <typeparam name="TKey">Type of the resulting dictionary's keys.</typeparam>
  /// <typeparam name="TValue">Type of the resulting dictionary's values.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="key">Key selector delegate.</param>
  /// <param name="keyComparer">Comparer to perform comparison of keys.</param>
  /// <param name="valueComparer">Comparer to perform comparison of values for equality.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableSortedDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableSortedDictionaryAsync{TKey, TValue}(IAsyncEnumerable{TValue}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, CancellationToken)"/>
  public static Task<ImmutableSortedDictionary<TKey, TValue>> ImmutableSortedDictionaryAsync<TKey, TValue>(this IConversion<IAsyncEnumerable<TValue>> conversion, Func<TValue, TKey> key, IComparer<TKey> keyComparer = null, IEqualityComparer<TValue> valueComparer = null, CancellationToken cancellation = default, string error = null) where TKey : notnull => conversion.To(sequence => sequence.ToImmutableSortedDictionaryAsync(key, keyComparer, valueComparer, cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="System.Collections.Immutable.ImmutableQueue{T}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableQueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableQueue{T}(IAsyncEnumerable{T})"/>
  public static ImmutableQueue<T> ImmutableQueue<T>(this IConversion<IAsyncEnumerable<T>> conversion, string error = null) => conversion.To(sequence => sequence.ToImmutableQueue(), error);

  /// <summary>
  ///   <para>Converts given <see cref="IAsyncEnumerable{T}"/> instance to the instance of <see cref="Task{ImmutableQueue{T}}"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of sequence elements.</typeparam>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ImmutableQueue{T}(IConversion{IAsyncEnumerable{T}}, string)"/>
  /// <seealso cref="IAsyncEnumerableExtensions.ToImmutableQueueAsync{T}(IAsyncEnumerable{T}, CancellationToken)"/>
  public static Task<ImmutableQueue<T>> ImmutableQueueAsync<T>(this IConversion<IAsyncEnumerable<T>> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(sequence => sequence.ToImmutableQueueAsync(cancellation), error);
  #endif
}