using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITimedExtensions"/>.</para>
/// </summary>
public sealed class ITimedExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITimedExtensions.CreatedIn{T}(IEnumerable{T}, DateTimeOffset?, DateTimeOffset?)"/> method.</para>
  /// </summary>
  [Fact]
  public void CreatedIn_Method()
  {
    AssertionExtensions.Should(() => ITimedExtensions.CreatedIn<ITimed>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("sequence");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITimedExtensions.UpdatedIn{T}(IEnumerable{T}, DateTimeOffset?, DateTimeOffset?)"/> method.</para>
  /// </summary>
  [Fact]
  public void UpdatedIn_Method()
  {
    AssertionExtensions.Should(() => ITimedExtensions.UpdatedIn<ITimed>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("sequence");

    throw new NotImplementedException();
  }
}