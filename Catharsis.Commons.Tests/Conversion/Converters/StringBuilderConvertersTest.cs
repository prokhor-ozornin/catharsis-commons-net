using System.Text;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => StringBuilderConverters.StringWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }
    
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringBuilderConverters.XmlWriter(IConversion{StringBuilder}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlWriter_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => StringBuilderConverters.XmlWriter(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}