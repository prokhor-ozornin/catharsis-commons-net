using System.Text;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FileInfoConverters"/>.</para>
/// </summary>
public sealed class FileInfoConvertersTest : UnitTest
{
  private IConversion<FileInfo> Conversion { get; } = RandomFakeFile.Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.Bytes(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.BytesAsync(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.Text(IConversion{FileInfo}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.TextAsync(IConversion{FileInfo}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.Stream(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stream_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.Stream(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.ReadOnlyStream(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ReadOnlyStream_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.ReadOnlyStream(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.WriteOnlyStream(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void WriteOnlyStream_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.WriteOnlyStream(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.StreamReader(IConversion{FileInfo}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StreamReader_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.StreamReader(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.StreamWriter(IConversion{FileInfo}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StreamWriter_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.StreamWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.XmlDocument(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlDocument_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.XmlDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.XDocument(IConversion{FileInfo}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocument_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.XDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="FileInfoConverters.XDocumentAsync(IConversion{FileInfo}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocumentAsync_Method()
  {
    AssertionExtensions.Should(() => FileInfoConverters.XDocumentAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.XDocumentAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }
}