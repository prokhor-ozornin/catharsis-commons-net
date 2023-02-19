using System.Net.NetworkInformation;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="PhysicalAddressConverters"/>.</para>
/// </summary>
public sealed class PhysicalAddressConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="PhysicalAddressConverters.Bytes(IConversion{PhysicalAddress}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => PhysicalAddressConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}