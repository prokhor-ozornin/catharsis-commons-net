using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="HttpContent"/> type.</para>
/// </summary>
/// <seealso cref="HttpContent"/>
public static class HttpContentConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="HttpContent"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{HttpContent}, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToBytes(), error);

  /// <summary>
  ///   <para>Converts given <see cref="HttpContent"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{HttpContent}, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToBytesAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="HttpContent"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextAsync(IConversion{HttpContent}, CancellationToken, string)"/>
  public static string Text(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToText(), error);

  /// <summary>
  ///   <para>Converts given <see cref="HttpContent"/> instance to the instance of <see cref="Task{string}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{HttpContent}, string)"/>
  public static Task<string> TextAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(content => content.ToTextAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="HttpContent"/> instance to the instance of <see cref="System.IO.Stream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamAsync(IConversion{HttpContent}, CancellationToken, string)"/>
  public static Stream Stream(this IConversion<HttpContent> conversion, string error = null) => conversion.To(content => content.ToStream(), error);

  /// <summary>
  ///   <para>Converts given <see cref="HttpContent"/> instance to the instance of <see cref="Task{Stream}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Stream(IConversion{HttpContent}, string)"/>
  public static Task<Stream> StreamAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(content => content.ToStreamAsync(cancellation), error);
}