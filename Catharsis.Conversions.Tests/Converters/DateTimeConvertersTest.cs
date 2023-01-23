using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DateTimeConverters"/>.</para>
/// </summary>
public sealed class DateTimeConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeConverters.DateTimeOffset(IConversion{DateTime})"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTimeOffset_Method()
  {
    AssertionExtensions.Should(() => DateTimeConverters.DateTimeOffset(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeConverters.DateOnly(IConversion{DateTime})"/> method.</para>
  /// </summary>
  [Fact]
  public void DateOnly_Method()
  {
    AssertionExtensions.Should(() => DateTimeConverters.DateOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeConverters.TimeOnly(IConversion{DateTime})"/> method.</para>
  /// </summary>
  [Fact]
  public void TimeOnly_Method()
  {
    AssertionExtensions.Should(() => DateTimeConverters.TimeOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}