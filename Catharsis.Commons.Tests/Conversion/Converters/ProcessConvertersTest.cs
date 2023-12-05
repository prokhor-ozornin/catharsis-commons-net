using System.Diagnostics;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ProcessConverters"/>.</para>
/// </summary>
public sealed class ProcessConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="ProcessConverters.Bytes(IConversion{Process}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => ProcessConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ProcessConverters.BytesAsync(IConversion{Process}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => ProcessConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ProcessConverters.Text(IConversion{Process}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => ProcessConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="ProcessConverters.TextAsync(IConversion{Process}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    AssertionExtensions.Should(() => ProcessConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    throw new NotImplementedException();
  }
}