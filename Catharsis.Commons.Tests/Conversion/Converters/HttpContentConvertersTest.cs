using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
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
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => HttpContentConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.BytesAsync(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => HttpContentConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.Text(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => HttpContentConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.TextAsync(IConversion{HttpContent}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TextAsync_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => HttpContentConverters.TextAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => Conversion.TextAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.Stream(IConversion{HttpContent}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Stream_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => HttpContentConverters.Stream(null)).Throw<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="HttpContentConverters.StreamAsync(IConversion{HttpContent}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StreamAsync_Method()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => HttpContentConverters.StreamAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => Conversion.StreamAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();
    }

    throw new NotImplementedException();
  }
}