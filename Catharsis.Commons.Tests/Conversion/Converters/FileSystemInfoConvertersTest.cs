using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FileSystemInfoConverters"/>.</para>
/// </summary>
public sealed class FileSystemInfoConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="FileSystemInfoConverters.Uri(IConversion{FileSystemInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Uri_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => FileSystemInfoConverters.Uri(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}