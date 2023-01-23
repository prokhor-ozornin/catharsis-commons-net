using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RangeConverters"/>.</para>
/// </summary>
public sealed class RangeConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="RangeConverters.Enumerable(IConversion{Range})"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    AssertionExtensions.Should(() => RangeConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}