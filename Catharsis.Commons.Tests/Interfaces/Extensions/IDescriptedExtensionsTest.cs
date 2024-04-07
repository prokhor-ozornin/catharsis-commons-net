using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="IDescriptedExtensions"/>.</para>
/// </summary>
public sealed class IDescriptedExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="IDescriptedExtensions.WithDescription{T}(IEnumerable{T}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void WithDescription_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => IDescriptedExtensions.WithDescription<IDescripted>(null, string.Empty)).ThrowExactly<ArgumentNullException>().WithParameterName("sequence");
      AssertionExtensions.Should(() => Enumerable.Empty<IDescripted>().WithDescription(null)).ThrowExactly<ArgumentNullException>().WithParameterName("description");
    }

    throw new NotImplementedException();
  }
}