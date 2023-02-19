using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Stream"/> type.</para>
/// </summary>
/// <seealso cref="Stream"/>
public static class StreamConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{Stream}, bool, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToBytes(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{Stream}, bool, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToBytesAsync(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{Stream}, Encoding, string)"/>
  public static string Text(this IConversion<Stream> conversion, Encoding encoding = null, string error = null) => conversion.To(stream => stream.ToText(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{Stream}, Encoding, string)"/>
  public static Task<string> TextAsync(this IConversion<Stream> conversion, Encoding encoding = null, string error = null) => conversion.To(stream => stream.ToTextAsync(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlDocument XmlDocument(this IConversion<Stream> conversion, string error = null) => conversion.To(stream => stream.ToXmlDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocumentAsync(IConversion{Stream}, CancellationToken, string)"/>
  public static XDocument XDocument(this IConversion<Stream> conversion, string error = null) => conversion.To(stream => stream.ToXDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{Stream}, string)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<Stream> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(stream => stream.ToXDocumentAsync(cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{Stream}, int, bool, string)"/>
  public static IEnumerable<byte> Enumerable(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToEnumerable(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{Stream}, bool, string)"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<Stream> conversion, int count, bool close = false, string error = null) => conversion.To(stream => stream.ToEnumerable(count, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{Stream}, int, bool, string)"/>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToAsyncEnumerable(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{Stream}, bool, string)"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<Stream> conversion, int count, bool close = false, string error = null) => conversion.To(stream => stream.ToAsyncEnumerable(count, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="bufferSize"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static BufferedStream BufferedStream(this IConversion<Stream> conversion, int? bufferSize = null, string error = null) => conversion.To(stream => stream.ToBufferedStream(bufferSize), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static BinaryReader BinaryReader(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToBinaryReader(encoding, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static BinaryWriter BinaryWriter(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToBinaryWriter(encoding, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StreamReader StreamReader(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToStreamReader(encoding, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StreamWriter StreamWriter(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToStreamWriter(encoding, close), error);
}