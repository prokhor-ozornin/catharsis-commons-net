using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DictionaryConverters"/>.</para>
/// </summary>
public sealed class DictionaryConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="DictionaryConverters.SortedList{TKey, TValue}(IConversion{IDictionary{TKey, TValue}}, IComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedList_Method()
  {
    AssertionExtensions.Should(() => DictionaryConverters.SortedList<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DictionaryConverters.SortedDictionary{TKey, TValue}(IConversion{IDictionary{TKey, TValue}}, IComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedDictionary_Method()
  {
    AssertionExtensions.Should(() => DictionaryConverters.SortedDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DictionaryConverters.ValueTuple{TKey, TValue}(IConversion{IReadOnlyDictionary{TKey, TValue}}, IComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void ValueTuple_Method()
  {
    AssertionExtensions.Should(() => DictionaryConverters.ValueTuple<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}