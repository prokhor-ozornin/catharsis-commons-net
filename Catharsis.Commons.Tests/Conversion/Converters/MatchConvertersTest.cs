using System.Text.RegularExpressions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="MatchConverters"/>.</para>
/// </summary>
public sealed class MatchConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="MatchConverters.Enumerable(IConversion{Match}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => MatchConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}