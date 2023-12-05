using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITimeAwareExtensions"/>.</para>
/// </summary>
public sealed class ITimeAwareExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITimeAwareExtensions.CreatedIn{T}(IEnumerable{T}, DateTimeOffset?, DateTimeOffset?)"/> method.</para>
  /// </summary>
  [Fact]
  public void CreatedIn_Method()
  {
    AssertionExtensions.Should(() => ITimeAwareExtensions.CreatedIn<ITimeAware>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("sequence");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITimeAwareExtensions.UpdatedIn{T}(IEnumerable{T}, DateTimeOffset?, DateTimeOffset?)"/> method.</para>
  /// </summary>
  [Fact]
  public void UpdatedIn_Method()
  {
    AssertionExtensions.Should(() => ITimeAwareExtensions.UpdatedIn<ITimeAware>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("sequence");

    throw new NotImplementedException();
  }
}