using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IAsyncEnumerableConverters"/>.</para>
/// </summary>
public sealed class IAsyncEnumerableConvertersTest : UnitTest
{
  private IConversion<IAsyncEnumerable<object>> Conversion { get; } = Enumerable.Empty<object>().ToAsyncEnumerable().Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.Enumerable{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.Enumerable<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.Array{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Array_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.Array<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ArrayAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ArrayAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ArrayAsync<object>(null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.List{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void List_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.List<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ListAsync{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ListAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ListAsync<object>(null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.LinkedList{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkedList_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.LinkedList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.LinkedListAsync{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkedListAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.LinkedListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.LinkedListAsync<object>(null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ReadOnlyList{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyList_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlyList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ReadOnlyListAsync{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyListAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlyListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlyListAsync<object>(null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.HashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void HashSet_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.HashSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.HashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void HashSetAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.HashSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.HashSetAsync<object>(null, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.SortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedSet_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.SortedSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.SortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedSetAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.SortedSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.SortedSetAsync<object>(null, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ReadOnlySet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlySet_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlySet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ReadOnlySetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlySetAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlySetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlySetAsync<object>(null, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.Dictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Dictionary_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.Dictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.Dictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.DictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.DictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.DictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.DictionaryAsync(key => key, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ReadOnlyDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyDictionary_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlyDictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.ReadOnlyDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ReadOnlyDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyDictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ReadOnlyDictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ReadOnlyDictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ReadOnlyDictionaryAsync(key => key, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IAsyncEnumerableConverters.ValueTuple{T}(IConversion{IAsyncEnumerable{T}})"/></description></item>
  ///     <item><description><see cref="IAsyncEnumerableConverters.ValueTuple{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTuple_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IAsyncEnumerableConverters.ValueTuple<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.ValueTuple<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IAsyncEnumerableConverters.ValueTuple<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.ValueTuple<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IAsyncEnumerableConverters.ValueTupleAsync{T}(IConversion{IAsyncEnumerable{T}})"/></description></item>
  ///     <item><description><see cref="IAsyncEnumerableConverters.ValueTupleAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, CancellationToken, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTupleAsync_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IAsyncEnumerableConverters.ValueTupleAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => Conversion.ValueTupleAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IAsyncEnumerableConverters.ValueTupleAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => Conversion.ValueTupleAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.Stack{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stack_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.Stack<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.StackAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StackAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.StackAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.StackAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.Queue{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Queue_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.Queue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.QueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void QueueAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.QueueAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.QueueAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.PriorityQueue{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PriorityQueue_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.PriorityQueue<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.PriorityQueueAsync{TElement, TPriority}(IConversion{IAsyncEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PriorityQueueAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.PriorityQueueAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.PriorityQueueAsync<object, object>(null, null, Attributes.CancellationToken())).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IAsyncEnumerableConverters.MemoryStream(IConversion{IAsyncEnumerable{byte}}, string)"/></description></item>
  ///     <item><description><see cref="IAsyncEnumerableConverters.MemoryStream(IConversion{IAsyncEnumerable{byte[]}}, string)"/></description></item>
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
  ///     <item><description><see cref="IAsyncEnumerableConverters.MemoryStreamAsync(IConversion{IAsyncEnumerable{byte}}, CancellationToken, string)"/></description></item>
  ///     <item><description><see cref="IAsyncEnumerableConverters.MemoryStreamAsync(IConversion{IAsyncEnumerable{byte[]}}, CancellationToken, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void MemoryStreamAsync_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte>>) null).MemoryStreamAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte[]>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IAsyncEnumerable<byte[]>>) null).MemoryStreamAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableArray{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableArray_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableArray<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableArrayAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableArrayAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableArrayAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableArrayAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableList{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableList_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableListAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableListAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableListAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableListAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableHashSet{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableHashSet_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableHashSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableHashSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IEqualityComparer{T}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableHashSetAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableHashSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableHashSetAsync(null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableSortedSet{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedSet_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableSortedSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableSortedSetAsync{T}(IConversion{IAsyncEnumerable{T}}, IComparer{T}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedSetAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableSortedSetAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableSortedSetAsync(null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableDictionary_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableDictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.ImmutableDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("key");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IEqualityComparer{TKey}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableDictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableDictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableDictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("key").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableDictionaryAsync(key => key, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableSortedDictionary{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedDictionary_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableSortedDictionary<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    AssertionExtensions.Should(() => Conversion.ImmutableSortedDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("key");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableSortedDictionaryAsync{TKey, TValue}(IConversion{IAsyncEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, IEqualityComparer{TValue}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableSortedDictionaryAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableSortedDictionaryAsync<object, object>(null, key => key)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableSortedDictionaryAsync<object, object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("key").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableSortedDictionaryAsync(key => key, null, null, Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableQueue{T}(IConversion{IAsyncEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableQueue_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableQueue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IAsyncEnumerableConverters.ImmutableQueueAsync{T}(IConversion{IAsyncEnumerable{T}}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableQueueAsync_Method()
  {
    AssertionExtensions.Should(() => IAsyncEnumerableConverters.ImmutableQueueAsync<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.ImmutableQueueAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }
}