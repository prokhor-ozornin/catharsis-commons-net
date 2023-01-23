using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FileSystemInfoConverters"/>.</para>
/// </summary>
public sealed class FileSystemInfoConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="FileSystemInfoConverters.Uri(IConversion{FileSystemInfo})"/> method.</para>
  /// </summary>
  [Fact]
  public void Uri_Method()
  {
    AssertionExtensions.Should(() => FileSystemInfoConverters.Uri(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}