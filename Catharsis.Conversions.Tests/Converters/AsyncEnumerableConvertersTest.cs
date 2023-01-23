using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="AsyncEnumerableConverters"/>.</para>
/// </summary>
public sealed class AsyncEnumerableConvertersTest : UnitTest
{
  private IConversion<IAsyncEnumerable<object>> Conversion { get; } = Enumerable.Empty<object>().ToAsyncEnumerable().Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.Enumerable{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.Enumerable<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.Array{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Array_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.Array<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ArrayAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ArrayAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ArrayAsync<object>(null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.List{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void List_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.List<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ListAsync{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ListAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ListAsync<object>(null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.LinkedList{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkedList_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.LinkedList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.LinkedListAsync{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkedListAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.LinkedListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.LinkedListAsync<object>(null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ReadOnlyList{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyList_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlyList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ReadOnlyListAsync{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyListAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlyListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlyListAsync<object>(null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.HashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void HashSet_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.HashSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.HashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void HashSetAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.HashSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.HashSetAsync<object>(null, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.SortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedSet_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.SortedSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.SortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedSetAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.SortedSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.SortedSetAsync<object>(null, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ReadOnlySet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlySet_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlySet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ReadOnlySetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlySetAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlySetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlySetAsync<object>(null, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.Dictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void Dictionary_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.Dictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.Dictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.DictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void DictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.DictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.DictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.DictionaryAsync(key => key, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ReadOnlyDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyDictionary_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlyDictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.ReadOnlyDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ReadOnlyDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyDictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ReadOnlyDictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ReadOnlyDictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ReadOnlyDictionaryAsync(key => key, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="AsyncEnumerableConverters.ValueTuple{T}(IConversion{IAsyncEnumerable{T}})"/></description></item>
  ///     <item><description><see cref="AsyncEnumerableConverters.ValueTuple{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTuple_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => AsyncEnumerableConverters.ValueTuple<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.ValueTuple<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => AsyncEnumerableConverters.ValueTuple<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.ValueTuple<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="AsyncEnumerableConverters.ValueTupleAsync{T}(IConversion{IAsyncEnumerable{T}})"/></description></item>
  ///     <item><description><see cref="AsyncEnumerableConverters.ValueTupleAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, CancellationToken)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTupleAsync_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => AsyncEnumerableConverters.ValueTupleAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => Conversion.ValueTupleAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => AsyncEnumerableConverters.ValueTupleAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => Conversion.ValueTupleAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.Stack{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Stack_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.Stack<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.StackAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void StackAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.StackAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.StackAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.Queue{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Queue_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.Queue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.QueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void QueueAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.QueueAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.QueueAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.PriorityQueue{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority})"/> method.</para>
  /// </summary>
  [Fact]
  public void PriorityQueue_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.PriorityQueue<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.PriorityQueueAsync{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void PriorityQueueAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.PriorityQueueAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => AsyncEnumerableConverters.PriorityQueueAsync<object, object>(null, null, Cancellation)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }
  
  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="AsyncEnumerableConverters.MemoryStream(IConversion{IAsyncEnumerable{byte}})"/></description></item>
  ///     <item><description><see cref="AsyncEnumerableConverters.MemoryStream(IConversion{IAsyncEnumerable{byte[]}})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void MemoryStream_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte>>) null).MemoryStream()).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte[]>>) null).MemoryStream()).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="AsyncEnumerableConverters.MemoryStreamAsync(IConversion{IAsyncEnumerable{byte}}, CancellationToken)"/></description></item>
  ///     <item><description><see cref="AsyncEnumerableConverters.MemoryStreamAsync(IConversion{IAsyncEnumerable{byte[]}}, CancellationToken)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void MemoryStreamAsync_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte>>) null).MemoryStreamAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte[]>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte[]>>) null).MemoryStreamAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableArray{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableArray_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableArray<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableArrayAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableArrayAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableArrayAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableList{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableList_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableListAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableListAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableHashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableHashSet_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableHashSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableHashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableHashSetAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableHashSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableHashSetAsync(null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableSortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedSet_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableSortedSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableSortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedSetAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableSortedSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableSortedSetAsync(null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableDictionary_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableDictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.ImmutableDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("key");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableDictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableDictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableDictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("key").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableDictionaryAsync(key => key, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableSortedDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedDictionary_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableSortedDictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.ImmutableSortedDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("key");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableSortedDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedDictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableSortedDictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableSortedDictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("key").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableSortedDictionaryAsync(key => key, null, null, Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableQueue{T}(IConversion{IAsyncEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableQueue_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableQueue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="AsyncEnumerableConverters.ImmutableQueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableQueueAsync_Method()
  {
    AssertionExtensions.Should(() => AsyncEnumerableConverters.ImmutableQueueAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableQueueAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }
}