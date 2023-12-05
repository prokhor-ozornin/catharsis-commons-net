using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="HttpContentConverters"/>.</para>
/// </summary>
public sealed class HttpContentConvertersTest : UnitTest
{
  private IConversion<HttpContent> Conversion { get; } = new StringContent(string.Empty).Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.Bytes(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => HttpContentConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.BytesAsync(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => HttpContentConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.Text(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => HttpContentConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.TextAsync(IConversion{HttpContent}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    AssertionExtensions.Should(() => HttpContentConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.TextAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.Stream(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stream_Method()
  {
    AssertionExtensions.Should(() => HttpContentConverters.Stream(null)).Throw<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.StreamAsync(IConversion{HttpContent}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StreamAsync_Method()
  {
    AssertionExtensions.Should(() => HttpContentConverters.StreamAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.StreamAsync(Cancellation)).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }
}