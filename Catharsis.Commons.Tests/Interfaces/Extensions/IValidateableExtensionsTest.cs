using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IValidateableExtensions"/>.</para>
/// </summary>
public sealed class IValidateableExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IValidateableExtensions.Validate{T}(T, Exception)"/> method.</para>
  /// </summary>
  [Fact]
  public void Validate_Method()
  {
    AssertionExtensions.Should(() => IValidateableExtensions.Validate<IValidateable>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("validateable");

    throw new NotImplementedException();
  }
}
