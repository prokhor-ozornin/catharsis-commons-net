using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => DirectoryInfoConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}