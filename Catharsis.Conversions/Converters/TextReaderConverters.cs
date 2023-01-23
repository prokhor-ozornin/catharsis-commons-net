using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class TextReaderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="reader"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static byte[] Bytes(this TextReader reader, Encoding encoding = null) => reader.ToText().ToBytes(encoding);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="reader"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static async Task<byte[]> BytesAsync(this TextReader reader, Encoding encoding = null) => (await reader.ToTextAsync().ConfigureAwait(false)).ToBytes(encoding);
  
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Task<string> TextAsync(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToTextAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static XmlDocument XmlDocument(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToXmlDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static XDocument XDocument(this IConversion<TextReader> conversion) => conversion.To(reader => reader.ToXDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<XDocument> XDocumentAsync(this IConversion<TextReader> conversion, CancellationToken cancellation = default) => conversion.To(reader => reader.ToXDocumentAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<char> Enumerable(this IConversion<TextReader> conversion, bool close = false) => conversion.To(reader => reader.ToEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<char[]> Enumerable(this IConversion<TextReader> conversion, int count, bool close = false) => conversion.To(reader => reader.ToEnumerable(count, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<char> AsyncEnumerable(this IConversion<TextReader> conversion, bool close = false) => conversion.To(reader => reader.ToAsyncEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<char[]> AsyncEnumerable(this IConversion<TextReader> conversion, int count, bool close = false) => conversion.To(reader => reader.ToAsyncEnumerable(count, close));
}