using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TimeOnlyConverters"/>.</para>
/// </summary>
public sealed class TimeOnlyConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TimeOnlyConverters.DateTime(IConversion{TimeOnly}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTime_Method()
  {
    AssertionExtensions.Should(() => TimeOnlyConverters.DateTime(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TimeOnlyConverters.DateTimeOffset(IConversion{TimeOnly}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTimeOffset_Method()
  {
    AssertionExtensions.Should(() => TimeOnlyConverters.DateTimeOffset(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}