using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DateTimeConverters"/>.</para>
/// </summary>
public sealed class DateTimeConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeConverters.DateTimeOffset(IConversion{DateTime}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTimeOffset_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => DateTimeConverters.DateTimeOffset(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

      foreach (var date in new[] { DateTime.MinValue, DateTime.MaxValue, DateTime.Now, DateTime.UtcNow })
      {
        date.ToDateTimeOffset().Should().BeSameDateAs(date.ToDateTimeOffset()).And.BeSameDateAs(new DateTimeOffset(date.ToUniversalTime())).And.BeWithin(TimeSpan.Zero);
      }
    }
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeConverters.DateOnly(IConversion{DateTime}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateOnly_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => DateTimeConverters.DateOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="DateTimeConverters.TimeOnly(IConversion{DateTime}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TimeOnly_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => DateTimeConverters.TimeOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}