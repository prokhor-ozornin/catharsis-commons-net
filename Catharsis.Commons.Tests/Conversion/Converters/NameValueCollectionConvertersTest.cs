using System.Collections.Specialized;
using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="NameValueCollectionConverters"/>.</para>
/// </summary>
public sealed class NameValueCollectionConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="NameValueCollectionConverters.Dictionary(IConversion{NameValueCollection}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Dictionary_Method()
  {
    AssertionExtensions.Should(() => NameValueCollectionConverters.Dictionary(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="NameValueCollectionConverters.ValueTuple(IConversion{NameValueCollection}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void ValueTuple_Method()
  {
    AssertionExtensions.Should(() => NameValueCollectionConverters.ValueTuple(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}