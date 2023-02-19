using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="HttpContent"/> type.</para>
/// </summary>
/// <seealso cref="HttpContent"/>
public static class HttpContentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{HttpContent}, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{HttpContent}, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToBytesAsync(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{HttpContent}, CancellationToken, string)"/>
  public static string Text(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToText(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{HttpContent}, string)"/>
  public static Task<string> TextAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(content => content.ToTextAsync(cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="StreamAsync(IConversion{HttpContent}, CancellationToken, string)"/>
  public static Stream Stream(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToStream(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Stream(IConversion{HttpContent}, string)"/>
  public static Task<Stream> StreamAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(content => content.ToStreamAsync(cancellation), error);
}