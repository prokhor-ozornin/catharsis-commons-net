using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="EnumerableConverters"/>.</para>
/// </summary>
public sealed class EnumerableConvertersTest : UnitTest
{
  private IConversion<IEnumerable<object>> Conversion { get; } = Enumerable.Empty<object>().Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.Array{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Array_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.Array<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.AsyncEnumerable{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.AsyncEnumerable<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.LinkedList{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkedList_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.LinkedList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.ReadOnlyList{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyList_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.ReadOnlyList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.SortedSet{T}(IConversion{IEnumerable{T}}, IComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedSet_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.SortedSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.ReadOnlySet{T}(IConversion{IEnumerable{T}}, IEqualityComparer{T})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlySet_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.ReadOnlySet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.Stack{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Stack_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.Stack<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.Queue{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Queue_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.Queue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.PriorityQueue{TElement, TPriority}(IConversion{IEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority})"/> method.</para>
  /// </summary>
  [Fact]
  public void PriorityQueue_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.PriorityQueue<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.ImmutableQueue{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableQueue_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.ImmutableQueue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.ArraySegment{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ArraySegment_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.ArraySegment<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.Memory{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Memory_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.Memory<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.ReadOnlyMemory{T}(IConversion{IEnumerable{T}})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyMemory_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.ReadOnlyMemory<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.Range(IConversion{IEnumerable{Range}})"/> method.</para>
  /// </summary>
  [Fact]
  public void Range_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.Range(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="EnumerableConverters.ValueTuple{T}(IConversion{IEnumerable{T}})"/></description></item>
  ///     <item><description><see cref="EnumerableConverters.ValueTuple{TKey, TValue}(IConversion{IEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTuple_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => EnumerableConverters.ValueTuple<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => EnumerableConverters.ValueTuple<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.ValueTuple(key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("key");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.Dictionary{TKey, TValue}(IConversion{IEnumerable{(TKey Key, TValue Value)}}, IEqualityComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void Dictionary_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.Dictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="EnumerableConverters.ReadOnlyDictionary{TKey, TValue}(IConversion{IEnumerable{(TKey Key, TValue Value)}}, IEqualityComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyDictionary_Method()
  {
    AssertionExtensions.Should(() => EnumerableConverters.ReadOnlyDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="EnumerableConverters.MemoryStream(IConversion{IEnumerable{byte}})"/></description></item>
  ///     <item><description><see cref="EnumerableConverters.MemoryStream(IConversion{IEnumerable{byte[]}})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void MemoryStream_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte>>) null).MemoryStream()).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte[]>>) null).MemoryStream()).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="EnumerableConverters.MemoryStreamAsync(IConversion{IEnumerable{byte}}, CancellationToken)"/></description></item>
  ///     <item><description><see cref="EnumerableConverters.MemoryStreamAsync(IConversion{IEnumerable{byte[]}}, CancellationToken)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void MemoryStreamAsync_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte>>) null).MemoryStreamAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte[]>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte[]>>) null).MemoryStreamAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    throw new NotImplementedException();
  }
}