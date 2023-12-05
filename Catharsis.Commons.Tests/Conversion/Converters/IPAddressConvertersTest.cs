using System.Net;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IPAddressConverters"/>.</para>
/// </summary>
public sealed class IPAddressConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IPAddressConverters.Bytes(IConversion{IPAddress}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => IPAddressConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IPAddressConverters.IpAddress(IConversion{long}, string)"/></description></item>
  ///     <item><description><see cref="IPAddressConverters.IpAddress(IConversion{uint}, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void IpAddress_Methods()
  {
    using (new AssertionScope())
    {
    }

    using (new AssertionScope())
    {

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="IPAddressConverters.IpHost(IConversion{IPAddress}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void IpHost_Method()
  {
    AssertionExtensions.Should(() => IPAddressConverters.IpHost(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}