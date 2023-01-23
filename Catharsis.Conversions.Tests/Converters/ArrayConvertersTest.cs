using System.Text;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ArrayConverters"/>.</para>
/// </summary>
public sealed class ArrayConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ArrayConverters.Bytes(IConversion{char[]}, Encoding)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => ArrayConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("converter");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ArrayConverters.Text(IConversion{char[]})"/></description></item>
  ///     <item><description><see cref="ArrayConverters.Text(IConversion{byte[]}, Encoding)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Text_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ArrayConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("converter");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ((IConversion<byte[]>) null).Text()).ThrowExactly<ArgumentNullException>().WithParameterName("converter");

    }

    throw new NotImplementedException();
  }
}