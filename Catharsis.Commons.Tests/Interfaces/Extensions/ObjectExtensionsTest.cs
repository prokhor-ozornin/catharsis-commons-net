using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ObjectExtensions"/>.</para>
/// </summary>
public sealed class ObjectExtensionsTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ObjectExtensions.SerializeAsJson(object)"/> method.</para>
  /// </summary>
  [Fact]
  public void SerializeAsJson_Method()
  {
    AssertionExtensions.Should(() => ObjectExtensions.SerializeAsJson(null)).ThrowExactly<ArgumentNullException>().WithParameterName("subject");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ObjectExtensions.DeserializeAsJson{T}(string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DeserializeAsJson_Method()
  {
    AssertionExtensions.Should(() => ObjectExtensions.DeserializeAsJson<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("value");

    throw new NotImplementedException();
  }
}