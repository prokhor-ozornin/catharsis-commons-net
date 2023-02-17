using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IReadOnlyDictionaryConverters"/>.</para>
/// </summary>
public sealed class IReadOnlyDictionaryConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IReadOnlyDictionaryConverters.ValueTuple{TKey, TValue}(IConversion{IReadOnlyDictionary{TKey, TValue}}, IComparer{TKey})"/> method.</para>
  /// </summary>
  [Fact]
  public void ValueTuple_Method()
  {
    AssertionExtensions.Should(() => IReadOnlyDictionaryConverters.ValueTuple<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}