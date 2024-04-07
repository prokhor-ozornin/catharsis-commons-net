using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IDictionaryConverters"/>.</para>
/// </summary>
public sealed class IDictionaryConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IDictionaryConverters.SortedList{TKey, TValue}(IConversion{IDictionary{TKey, TValue}}, IComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedList_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IDictionaryConverters.SortedList<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IDictionaryConverters.SortedDictionary{TKey, TValue}(IConversion{IDictionary{TKey, TValue}}, IComparer{TKey}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void SortedDictionary_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IDictionaryConverters.SortedDictionary<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}