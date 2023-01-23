using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IConversionExtensions"/>.</para>
/// </summary>
public sealed class IConversionExtensionsTest : UnitTest
{
  private IConversion<object> Conversion { get; } = new object().Convert();

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="IConversionExtensions.To{TSource}(IConversion{TSource})"/></description></item>
  ///     <item><description><see cref="IConversionExtensions.To{TSource, TResult}(IConversion{TSource}, Func{TSource, TResult})"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void To_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IConversionExtensions.To<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IConversionExtensions.To<object, object>(null, instance => instance)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
      AssertionExtensions.Should(() => Conversion.To<object, object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("converter");

    }

    throw new NotImplementedException();
  }
}