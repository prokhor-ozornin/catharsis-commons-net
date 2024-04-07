using System.Xml;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="XmlDocumentConverters"/>.</para>
/// </summary>
public sealed class XmlDocumentConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="XmlDocumentConverters.Bytes(IConversion{XmlDocument}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => XmlDocumentConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="XmlDocumentConverters.Text(IConversion{XmlDocument}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => XmlDocumentConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}