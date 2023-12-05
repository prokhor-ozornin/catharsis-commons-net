using System.Text;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="StreamConverters"/>.</para>
/// </summary>
public sealed class StreamConvertersTest : UnitTest
{
  private IConversion<Stream> Conversion { get; } = Stream.Null.Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.Bytes(IConversion{Stream}, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.BytesAsync(IConversion{Stream}, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.Text(IConversion{Stream}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.TextAsync(IConversion{Stream}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.XmlDocument(IConversion{Stream}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlDocument_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.XmlDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.XDocument(IConversion{Stream}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocument_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.XDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.XDocumentAsync(IConversion{Stream}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocumentAsync_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.XDocumentAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.XDocumentAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="StreamConverters.Enumerable(IConversion{Stream}, bool, string)"/></description></item>
  ///     <item><description><see cref="StreamConverters.Enumerable(IConversion{Stream}, int, bool, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Enumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => StreamConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => StreamConverters.Enumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="StreamConverters.AsyncEnumerable(IConversion{Stream}, bool, string)"/></description></item>
  ///     <item><description><see cref="StreamConverters.AsyncEnumerable(IConversion{Stream}, int, bool, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => StreamConverters.AsyncEnumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => StreamConverters.AsyncEnumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.BufferedStream(IConversion{Stream}, int?, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BufferedStream_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.BufferedStream(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.BinaryReader(IConversion{Stream}, Encoding, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BinaryReader_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.BinaryReader(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.BinaryWriter(IConversion{Stream}, Encoding, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BinaryWriter_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.BinaryWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.StreamReader(IConversion{Stream}, Encoding, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StreamReader_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.StreamReader(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StreamConverters.StreamWriter(IConversion{Stream}, Encoding, bool, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StreamWriter_Method()
  {
    AssertionExtensions.Should(() => StreamConverters.StreamWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}