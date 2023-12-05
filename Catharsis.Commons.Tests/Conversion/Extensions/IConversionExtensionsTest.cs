using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IConversionExtensions"/>.</para>
/// </summary>
public sealed class IConversionExtensionsTest : UnitTest
{
  private IConversion<object> Conversion { get; } = new object().Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="IConversionExtensions.To{TSource}(IConversion{TSource})"/> method.</para>
  /// </summary>
  [Fact]
  public void To_Method()
  {
    AssertionExtensions.Should(() => IConversionExtensions.To<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}