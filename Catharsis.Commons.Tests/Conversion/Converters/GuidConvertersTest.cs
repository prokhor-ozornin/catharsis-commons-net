using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="GuidConverters"/>.</para>
/// </summary>
public sealed class GuidConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="GuidConverters.Bytes(IConversion{Guid}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => GuidConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}