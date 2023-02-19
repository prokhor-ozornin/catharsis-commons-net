using System.Text;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="StringBuilderConverters"/>.</para>
/// </summary>
public sealed class StringBuilderConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="StringBuilderConverters.StringWriter(IConversion{StringBuilder}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StringWriter_Method()
  {
    AssertionExtensions.Should(() => StringBuilderConverters.StringWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringBuilderConverters.XmlWriter(IConversion{StringBuilder}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlWriter_Method()
  {
    AssertionExtensions.Should(() => StringBuilderConverters.XmlWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}