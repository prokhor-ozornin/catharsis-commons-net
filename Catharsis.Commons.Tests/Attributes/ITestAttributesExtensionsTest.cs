using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ITestAttributesExtensions"/>.</para>
/// </summary>
public sealed class ITestAttributesExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ITestAttributesExtensions.Guid(ITestAttributes)"/> method.</para>
  /// </summary>
  [Fact]
  public void Guid_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITestAttributesExtensions.Guid(null)).ThrowExactly<ArgumentNullException>().WithParameterName("attributes");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITestAttributesExtensions.CancellationToken(ITestAttributes)"/> method.</para>
  /// </summary>
  [Fact]
  public void CancellationToken_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITestAttributesExtensions.CancellationToken(null)).ThrowExactly<ArgumentNullException>().WithParameterName("attributes");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ITestAttributesExtensions.Random(ITestAttributes)"/> method.</para>
  /// </summary>
  [Fact]
  public void Random_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ITestAttributesExtensions.Random(null)).ThrowExactly<ArgumentNullException>().WithParameterName("attributes");
    }

    throw new NotImplementedException();
  }
}