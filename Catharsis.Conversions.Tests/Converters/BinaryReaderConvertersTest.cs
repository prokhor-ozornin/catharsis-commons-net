using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="BinaryReaderConverters"/>.</para>
/// </summary>
public sealed class BinaryReaderConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="BinaryReaderConverters.Bytes(IConversion{BinaryReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => BinaryReaderConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="BinaryReaderConverters.BytesAsync(IConversion{BinaryReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void BytesAsync_Method()
  {
    AssertionExtensions.Should(() => BinaryReaderConverters.BytesAsync(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="BinaryReaderConverters.Text(IConversion{BinaryReader}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => BinaryReaderConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="BinaryReaderConverters.Enumerable(IConversion{BinaryReader}, string)"/></description></item>
  ///     <item><description><see cref="BinaryReaderConverters.Enumerable(IConversion{BinaryReader}, int, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Enumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => BinaryReaderConverters.Enumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => BinaryReaderConverters.Enumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="BinaryReaderConverters.AsyncEnumerable(IConversion{BinaryReader}, string)"/></description></item>
  ///     <item><description><see cref="BinaryReaderConverters.AsyncEnumerable(IConversion{BinaryReader}, int, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void AsyncEnumerable_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => BinaryReaderConverters.AsyncEnumerable(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => BinaryReaderConverters.AsyncEnumerable(null, 0)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    throw new NotImplementedException();
  }
}