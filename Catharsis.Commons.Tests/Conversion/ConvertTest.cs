using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="Convert"/>.</para>
/// </summary>
public sealed class ConvertTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="Convert.To"/> property.</para>
  /// </summary>
  [Fact]
  public void To_Property()
  {
    Convert.To.Should().NotBeNull().And.BeSameAs(Convert.To);
  }
}