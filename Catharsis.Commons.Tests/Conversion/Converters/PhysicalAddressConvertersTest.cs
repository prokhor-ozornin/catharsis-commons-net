using System.Net.NetworkInformation;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => PhysicalAddressConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}