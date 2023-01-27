using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="HttpContent"/>
public static class HttpContentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{HttpContent})"/>
  public static IEnumerable<byte> Bytes(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{HttpContent})"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{HttpContent}, CancellationToken)"/>
  public static string Text(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{HttpContent})"/>
  public static Task<string> TextAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default) => conversion.To(content => content.ToTextAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="StreamAsync(IConversion{HttpContent}, CancellationToken)"/>
  public static Stream Stream(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Stream(IConversion{HttpContent})"/>
  public static Task<Stream> StreamAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default) => conversion.To(content => content.ToStreamAsync(cancellation));
}