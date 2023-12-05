using System.Text;
using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TextReaderConverters"/>.</para>
/// </summary>
public sealed class TextReaderConvertersTest : UnitTest
{
  private IConversion<TextReader> Conversion { get; } = Stream.Null.ToStreamReader().Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.Bytes(TextReader, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.BytesAsync(TextReader, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.BytesAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.Text(IConversion{TextReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.TextAsync(IConversion{TextReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.XmlDocument(IConversion{TextReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlDocument_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.XmlDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.XDocument(IConversion{TextReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocument_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.XDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TextReaderConverters.XDocumentAsync(IConversion{TextReader}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocumentAsync_Method()
  {
    AssertionExtensions.Should(() => TextReaderConverters.XDocumentAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.XDocumentAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="TextReaderConverters.Enumerable(IConversion{TextReader}, bool, string)"/></description></item>
  ///     <item><description><see cref="TextReaderConverters.Enumerable(IConversion{TextReader}, int, bool, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Enumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TextReaderConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TextReaderConverters.Enumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="TextReaderConverters.AsyncEnumerable(IConversion{TextReader}, bool, string)"/></description></item>
  ///     <item><description><see cref="TextReaderConverters.AsyncEnumerable(IConversion{TextReader}, int, bool, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TextReaderConverters.AsyncEnumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TextReaderConverters.AsyncEnumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }
}