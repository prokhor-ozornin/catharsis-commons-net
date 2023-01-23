using System.Security;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="SecureStringConverters"/>.</para>
/// </summary>
public sealed class SecureStringConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="SecureStringConverters.Bytes(IConversion{SecureString}, Encoding)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => SecureStringConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="SecureStringConverters.Text(IConversion{SecureString})"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => SecureStringConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}