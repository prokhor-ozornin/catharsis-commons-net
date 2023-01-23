using System.Net.Sockets;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TcpClientConverters"/>.</para>
/// </summary>
public sealed class TcpClientConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TcpClientConverters.Bytes(IConversion{TcpClient})"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => TcpClientConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TcpClientConverters.BytesAsync(IConversion{TcpClient})"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => TcpClientConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="TcpClientConverters.Enumerable(IConversion{TcpClient}, bool)"/></description></item>
  ///     <item><description><see cref="TcpClientConverters.Enumerable(IConversion{TcpClient}, int, bool)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Enumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TcpClientConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TcpClientConverters.Enumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="TcpClientConverters.AsyncEnumerable(IConversion{TcpClient}, bool)"/></description></item>
  ///     <item><description><see cref="TcpClientConverters.AsyncEnumerable(IConversion{TcpClient}, int, bool)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TcpClientConverters.AsyncEnumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TcpClientConverters.AsyncEnumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }
}