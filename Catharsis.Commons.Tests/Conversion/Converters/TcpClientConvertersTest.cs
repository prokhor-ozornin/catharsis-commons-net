using System.Net.Sockets;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TcpClientConverters"/>.</para>
/// </summary>
public sealed class TcpClientConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="TcpClientConverters.Bytes(IConversion{TcpClient}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TcpClientConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TcpClientConverters.BytesAsync(IConversion{TcpClient}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TcpClientConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="TcpClientConverters.Enumerable(IConversion{TcpClient}, bool, string)"/></description></item>
  ///     <item><description><see cref="TcpClientConverters.Enumerable(IConversion{TcpClient}, int, bool, string)"/></description></item>
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
  ///     <item><description><see cref="TcpClientConverters.AsyncEnumerable(IConversion{TcpClient}, bool, string)"/></description></item>
  ///     <item><description><see cref="TcpClientConverters.AsyncEnumerable(IConversion{TcpClient}, int, bool, string)"/></description></item>
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