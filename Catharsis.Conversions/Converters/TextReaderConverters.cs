using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="TextReader"/> type.</para>
/// </summary>
/// <seealso cref="TextReader"/>
public static class TextReaderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{TextReader}, Encoding, string)"/>
  public static byte[] Bytes(this IConversion<TextReader> conversion, Encoding encoding = null, string error = null) => conversion.To(reader => reader.ToBytes(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{TextReader}, Encoding, string)"/>
  public static Task<byte[]> BytesAsync(this IConversion<TextReader> conversion, Encoding encoding = null, string error = null) => conversion.To(reader => reader.ToBytesAsync(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextAsync(IConversion{TextReader}, string)"/>
  public static string Text(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToText(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{TextReader}, string)"/>
  public static Task<string> TextAsync(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToTextAsync(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static XmlDocument XmlDocument(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToXmlDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocumentAsync(IConversion{TextReader}, CancellationToken, string)"/>
  public static XDocument XDocument(this IConversion<TextReader> conversion, string error = null) => conversion.To(reader => reader.ToXDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocument(IConversion{TextReader}, string)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<TextReader> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(reader => reader.ToXDocumentAsync(cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{TextReader}, int, bool, string)"/>
  public static IEnumerable<char> Enumerable(this IConversion<TextReader> conversion, bool close = false, string error = null) => conversion.To(reader => reader.ToEnumerable(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{TextReader}, bool, string)"/>
  public static IEnumerable<char[]> Enumerable(this IConversion<TextReader> conversion, int count, bool close = false, string error = null) => conversion.To(reader => reader.ToEnumerable(count, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TextReader}, int, bool, string)"/>
  public static IAsyncEnumerable<char> AsyncEnumerable(this IConversion<TextReader> conversion, bool close = false, string error = null) => conversion.To(reader => reader.ToAsyncEnumerable(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TextReader}, bool, string)"/>
  public static IAsyncEnumerable<char[]> AsyncEnumerable(this IConversion<TextReader> conversion, int count, bool close = false, string error = null) => conversion.To(reader => reader.ToAsyncEnumerable(count, close), error);
}