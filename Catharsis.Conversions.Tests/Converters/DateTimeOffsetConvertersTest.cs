using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DateTimeOffsetConverters"/>.</para>
/// </summary>
public sealed class DateTimeOffsetConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeOffsetConverters.DateTime(IConversion{DateTimeOffset}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTime_Method()
  {
    AssertionExtensions.Should(() => DateTimeOffsetConverters.DateTime(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeOffsetConverters.DateOnly(IConversion{DateTimeOffset}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateOnly_Method()
  {
    AssertionExtensions.Should(() => DateTimeOffsetConverters.DateOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeOffsetConverters.TimeOnly(IConversion{DateTimeOffset}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TimeOnly_Method()
  {
    AssertionExtensions.Should(() => DateTimeOffsetConverters.TimeOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}