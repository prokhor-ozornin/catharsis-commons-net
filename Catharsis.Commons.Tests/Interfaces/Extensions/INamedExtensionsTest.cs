using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="INamedExtensions"/>.</para>
/// </summary>
public sealed class INamedExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="INamedExtensions.WithName{T}(IEnumerable{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void WithName_Method()
  {
    AssertionExtensions.Should(() => INamedExtensions.WithName<INameable>(null, string.Empty)).ThrowExactly<ArgumentNullException>().WithParameterName("sequence");
    AssertionExtensions.Should(() => Enumerable.Empty<INameable>().WithName(null)).ThrowExactly<ArgumentNullException>().WithParameterName("name");

    throw new NotImplementedException();
  }
}