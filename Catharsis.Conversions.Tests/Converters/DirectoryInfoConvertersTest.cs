using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="DirectoryInfoConverters"/>.</para>
/// </summary>
public sealed class DirectoryInfoConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="DirectoryInfoConverters.Enumerable(IConversion{DirectoryInfo}, string, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    AssertionExtensions.Should(() => DirectoryInfoConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}