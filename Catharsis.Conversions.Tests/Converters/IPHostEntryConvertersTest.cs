using System.Net;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPHostEntryConverters"/>.</para>
/// </summary>
public sealed class IPHostEntryConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IPHostEntryConverters.Enumerable(IConversion{IPHostEntry}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    AssertionExtensions.Should(() => IPHostEntryConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}