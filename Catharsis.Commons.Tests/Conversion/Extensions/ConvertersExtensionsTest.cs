using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ObjectExtensions"/>.</para>
/// </summary>
public sealed class ConvertersExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ObjectExtensions.Convert{T}(T)"/> method.</para>
  /// </summary>
  [Fact]
  public void Convert_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ObjectExtensions.Convert<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("source");
    }

    throw new NotImplementedException();
  }
}