using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="RangeConverters"/>.</para>
/// </summary>
public sealed class RangeConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="RangeConverters.Enumerable(IConversion{Range}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => RangeConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}