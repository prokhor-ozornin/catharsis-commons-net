using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class StreamConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<byte> Bytes(this IConversion<Stream> conversion, bool close = false) => conversion.To(stream => stream.ToBytes(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Stream> conversion, bool close = false) => conversion.To(stream => stream.ToBytesAsync(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static string Text(this IConversion<Stream> conversion, Encoding encoding = null) => conversion.To(stream => stream.ToText(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static Task<string> TextAsync(this IConversion<Stream> conversion, Encoding encoding = null) => conversion.To(stream => stream.ToTextAsync(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static XmlDocument XmlDocument(this IConversion<Stream> conversion) => conversion.To(stream => stream.ToXmlDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static XDocument XDocument(this IConversion<Stream> conversion) => conversion.To(stream => stream.ToXDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<XDocument> XDocumentAsync(this IConversion<Stream> conversion, CancellationToken cancellation = default) => conversion.To(stream => stream.ToXDocumentAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<byte> Enumerable(this IConversion<Stream> conversion, bool close = false) => conversion.To(stream => stream.ToEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IEnumerable<byte[]> Enumerable(this IConversion<Stream> conversion, int count, bool close = false) => conversion.To(stream => stream.ToEnumerable(count, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<Stream> conversion, bool close = false) => conversion.To(stream => stream.ToAsyncEnumerable(close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<Stream> conversion, int count, bool close = false) => conversion.To(stream => stream.ToAsyncEnumerable(count, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="bufferSize"></param>
  /// <returns></returns>
  public static BufferedStream BufferedStream(this IConversion<Stream> conversion, int? bufferSize = null) => conversion.To(stream => stream.ToBufferedStream(bufferSize));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static BinaryReader BinaryReader(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true) => conversion.To(stream => stream.ToBinaryReader(encoding, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static BinaryWriter BinaryWriter(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true) => conversion.To(stream => stream.ToBinaryWriter(encoding, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static StreamReader StreamReader(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true) => conversion.To(stream => stream.ToStreamReader(encoding, close));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <returns></returns>
  public static StreamWriter StreamWriter(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true) => conversion.To(stream => stream.ToStreamWriter(encoding, close));
}