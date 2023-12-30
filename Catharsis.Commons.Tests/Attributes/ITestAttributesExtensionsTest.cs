using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITestAttributesExtensions"/>.</para>
/// </summary>
public sealed class ITestAttributesExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="Guid"/> method.</para>
  /// </summary>
  [Fact]
  public void Guid_Method()
  {
    AssertionExtensions.Should(() => ITestAttributesExtensions.Guid(null)).ThrowExactly<ArgumentNullException>().WithParameterName("attributes");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="CancellationToken"/> method.</para>
  /// </summary>
  [Fact]
  public void CancellationToken_Method()
  {
    AssertionExtensions.Should(() => ITestAttributesExtensions.CancellationToken(null)).ThrowExactly<ArgumentNullException>().WithParameterName("attributes");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="Random"/> method.</para>
  /// </summary>
  [Fact]
  public void Random_Method()
  {
    AssertionExtensions.Should(() => ITestAttributesExtensions.Random(null)).ThrowExactly<ArgumentNullException>().WithParameterName("attributes");

    throw new NotImplementedException();
  }
}