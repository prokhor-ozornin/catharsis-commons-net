using System.Net;
using System.Net.Sockets;
using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="UdpClientConverters"/>.</para>
/// </summary>
public sealed class UdpClientConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="UdpClientConverters.Bytes(IConversion{UdpClient}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => UdpClientConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UdpClientConverters.BytesAsync(IConversion{UdpClient}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => UdpClientConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UdpClientConverters.Enumerable(IConversion{UdpClient}, IPEndPoint, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Enumerable_Method()
  {
    AssertionExtensions.Should(() => UdpClientConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UdpClientConverters.AsyncEnumerable(IConversion{UdpClient}, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Method()
  {
    AssertionExtensions.Should(() => UdpClientConverters.AsyncEnumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}