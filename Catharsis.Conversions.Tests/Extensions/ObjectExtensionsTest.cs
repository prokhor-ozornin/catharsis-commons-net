using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ObjectExtensions"/>.</para>
/// </summary>
public sealed class ObjectExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ObjectExtensions.Convert{T}(T)"/> method.</para>
  /// </summary>
  [Fact]
  public void Convert_Method()
  {
    AssertionExtensions.Should(() => ObjectExtensions.Convert<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("source");

    throw new NotImplementedException();
  }
}