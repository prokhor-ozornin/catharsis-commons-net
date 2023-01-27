using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="TextReader"/>
public static class TextReaderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="reader"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(TextReader, Encoding)"/>
  public static byte[] Bytes(this TextReader reader, Encoding encoding = null) => reader.ToText().ToBytes(encoding);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="reader"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(TextReader, Encoding)"/>
  public static async Task<byte[]> BytesAsync(this TextReader reader, Encoding encoding = null) => (await reader.ToTextAsync().ConfigureAwait(false)).ToBytes(encoding);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{TextReader})"/>
  public static string Text(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{TextReader})"/>
  public static Task<string> TextAsync(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToTextAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlDocument XmlDocument(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToXmlDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocumentAsync(IConversion{TextReader}, CancellationToken)"/>
  public static XDocument XDocument(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToXDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{TextReader})"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<TextReader> conversion, CancellationToken cancellation = default) => conversion.To(reader => reader.ToXDocumentAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{TextReader}, int, bool)"/>
  public static IEnumerable<char> Enumerable(this IConversion<TextReader> conversion, bool close = false) => conversion.To(reader => reader.ToEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{TextReader}, bool)"/>
  public static IEnumerable<char[]> Enumerable(this IConversion<TextReader> conversion, int count, bool close = false) => conversion.To(reader => reader.ToEnumerable(count, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TextReader}, int, bool)"/>
  public static IAsyncEnumerable<char> AsyncEnumerable(this IConversion<TextReader> conversion, bool close = false) => conversion.To(reader => reader.ToAsyncEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TextReader}, bool)"/>
  public static IAsyncEnumerable<char[]> AsyncEnumerable(this IConversion<TextReader> conversion, int count, bool close = false) => conversion.To(reader => reader.ToAsyncEnumerable(count, close));
}