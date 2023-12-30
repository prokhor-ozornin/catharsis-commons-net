using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IEnumerableConverters"/>.</para>
/// </summary>
public sealed class IEnumerableConvertersTest : UnitTest
{
  private IConversion<IEnumerable<object>> Conversion { get; } = Enumerable.Empty<object>().Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.Array{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Array_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.Array<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.AsyncEnumerable{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.AsyncEnumerable<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.LinkedList{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void LinkedList_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.LinkedList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.ReadOnlyList{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyList_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.ReadOnlyList<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.SortedSet{T}(IConversion{IEnumerable{T}}, IComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedSet_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.SortedSet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.ReadOnlySet{T}(IConversion{IEnumerable{T}}, IEqualityComparer{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlySet_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.ReadOnlySet<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.Stack{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stack_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.Stack<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.Queue{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Queue_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.Queue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.PriorityQueue{TElement, TPriority}(IConversion{IEnumerable{(TElement Element, TPriority Priority)}}, IComparer{TPriority}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void PriorityQueue_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.PriorityQueue<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.ImmutableQueue{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ImmutableQueue_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.ImmutableQueue<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.ArraySegment{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ArraySegment_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.ArraySegment<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.Memory{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Memory_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.Memory<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.ReadOnlyMemory{T}(IConversion{IEnumerable{T}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyMemory_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.ReadOnlyMemory<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.Range(IConversion{IEnumerable{Range}}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Range_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.Range(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IEnumerableConverters.ValueTuple{T}(IConversion{IEnumerable{T}})"/></description></item>
  ///     <item><description><see cref="IEnumerableConverters.ValueTuple{TKey, TValue}(IConversion{IEnumerable{TValue}}, Func{TValue, TKey}, IComparer{TKey}, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTuple_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IEnumerableConverters.ValueTuple<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IEnumerableConverters.ValueTuple<object, object>(null, key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.ValueTuple(key => key)).ThrowExactly<ArgumentNullException>().WithParameterName("key");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.Dictionary{TKey, TValue}(IConversion{IEnumerable{(TKey Key, TValue Value)}}, IEqualityComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Dictionary_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.Dictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IEnumerableConverters.ReadOnlyDictionary{TKey, TValue}(IConversion{IEnumerable{(TKey Key, TValue Value)}}, IEqualityComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyDictionary_Method()
  {
    AssertionExtensions.Should(() => IEnumerableConverters.ReadOnlyDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IEnumerableConverters.MemoryStream(IConversion{IEnumerable{byte}}, string)"/></description></item>
  ///     <item><description><see cref="IEnumerableConverters.MemoryStream(IConversion{IEnumerable{byte[]}}, string)"/></description></item>
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
  ///     <item><description><see cref="IEnumerableConverters.MemoryStreamAsync(IConversion{IEnumerable{byte}}, CancellationToken, string)"/></description></item>
  ///     <item><description><see cref="IEnumerableConverters.MemoryStreamAsync(IConversion{IEnumerable{byte[]}}, CancellationToken, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void MemoryStreamAsync_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte>>) null).MemoryStreamAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte[]>>) null).MemoryStreamAsync()).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => ((IConversion<IEnumerable<byte[]>>) null).MemoryStreamAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    }

    throw new NotImplementedException();
  }
}