using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DateOnlyConverters"/>.</para>
/// </summary>
public sealed class DateOnlyConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="DateOnlyConverters.DateTime(IConversion{DateOnly})"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTime_Method()
  {
    AssertionExtensions.Should(() => DateOnlyConverters.DateTime(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateOnlyConverters.DateTimeOffset(IConversion{DateOnly})"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTimeOffset_Method()
  {
    AssertionExtensions.Should(() => DateOnlyConverters.DateTimeOffset(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}