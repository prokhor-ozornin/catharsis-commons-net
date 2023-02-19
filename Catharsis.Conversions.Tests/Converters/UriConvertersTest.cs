using System.Text;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="UriConverters"/>.</para>
/// </summary>
public sealed class UriConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.Bytes(IConversion{Uri}, TimeSpan?, (string Name, object Value)[], string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => UriConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.BytesAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[], string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => UriConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.Text(IConversion{Uri}, Encoding, TimeSpan?, (string Name, object Value)[], string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => UriConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.XmlDocument(IConversion{Uri}, TimeSpan?, (string Name, object Value)[], string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlDocument_Method()
  {
    AssertionExtensions.Should(() => UriConverters.XmlDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.XmlDocumentAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[], string"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlDocumentAsync_Method()
  {
    AssertionExtensions.Should(() => UriConverters.XmlDocumentAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.XDocument(IConversion{Uri}, TimeSpan?, (string Name, object Value)[], string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocument_Method()
  {
    AssertionExtensions.Should(() => UriConverters.XDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="UriConverters.XDocumentAsync(IConversion{Uri}, TimeSpan?, CancellationToken, (string Name, object Value)[], string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocumentAsync_Method()
  {
    AssertionExtensions.Should(() => UriConverters.XDocumentAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }
}