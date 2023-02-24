using System.Xml.Linq;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="XDocumentConverters"/>.</para>
/// </summary>
public sealed class XDocumentConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="XDocumentConverters.Bytes(IConversion{XDocument}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => XDocumentConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="XDocumentConverters.BytesAsync(IConversion{XDocument}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => XDocumentConverters.BytesAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="XDocumentConverters.Text(IConversion{XDocument}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => XDocumentConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="XDocumentConverters.TextAsync(IConversion{XDocument}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    AssertionExtensions.Should(() => XDocumentConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }
}