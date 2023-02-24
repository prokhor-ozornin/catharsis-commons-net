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
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{Stream}, bool, string)"/>
  /// <seealso cref="StreamExtensions.ToBytes(Stream, bool)"/>
  public static IEnumerable<byte> Bytes(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToBytes(close), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="Stream"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{Stream}, bool, string)"/>
  /// <seealso cref="StreamExtensions.ToBytesAsync(Stream, bool)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToBytesAsync(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextAsync(IConversion{Stream}, Encoding, string)"/>
  /// <seealso cref="StreamExtensions.ToText(Stream, Encoding)"/>
  public static string Text(this IConversion<Stream> conversion, Encoding encoding = null, string error = null) => conversion.To(stream => stream.ToText(encoding), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="Stream"/> instance to the instance of <see cref="Task{string}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{Stream}, Encoding, string)"/>
  /// <seealso cref="StreamExtensions.ToTextAsync(Stream, Encoding)"/>
  public static Task<string> TextAsync(this IConversion<Stream> conversion, Encoding encoding = null, string error = null) => conversion.To(stream => stream.ToTextAsync(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamExtensions.ToXmlDocument(Stream)"/>
  public static XmlDocument XmlDocument(this IConversion<Stream> conversion, string error = null) => conversion.To(stream => stream.ToXmlDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.Xml.Linq.XDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocumentAsync(IConversion{Stream}, CancellationToken, string)"/>
  /// <seealso cref="StreamExtensions.ToXDocument(Stream)"/>
  public static XDocument XDocument(this IConversion<Stream> conversion, string error = null) => conversion.To(stream => stream.ToXDocument(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="Stream"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocument(IConversion{Stream}, string)"/>
  /// <seealso cref="StreamExtensions.ToXDocumentAsync(Stream, CancellationToken)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<Stream> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(stream => stream.ToXDocumentAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{Stream}, int, bool, string)"/>
  /// <seealso cref="StreamExtensions.ToEnumerable(Stream, bool)"/>
  public static IEnumerable<byte> Enumerable(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToEnumerable(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="IEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{Stream}, bool, string)"/>
  /// <seealso cref="StreamExtensions.ToEnumerable(Stream, int, bool)"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<Stream> conversion, int count, bool close = false, string error = null) => conversion.To(stream => stream.ToEnumerable(count, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{Stream}, int, bool, string)"/>
  /// <seealso cref="StreamExtensions.ToAsyncEnumerable(Stream, bool)"/>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<Stream> conversion, bool close = false, string error = null) => conversion.To(stream => stream.ToAsyncEnumerable(close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="IAsyncEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{Stream}, bool, string)"/>
  /// <seealso cref="StreamExtensions.ToAsyncEnumerable(Stream, int, bool)"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<Stream> conversion, int count, bool close = false, string error = null) => conversion.To(stream => stream.ToAsyncEnumerable(count, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.IO.BufferedStream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="bufferSize"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamExtensions.ToBufferedStream(Stream, int?)"/>
  public static BufferedStream BufferedStream(this IConversion<Stream> conversion, int? bufferSize = null, string error = null) => conversion.To(stream => stream.ToBufferedStream(bufferSize), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.IO.BinaryReader"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamExtensions.ToBinaryReader(Stream, Encoding, bool)"/>
  public static BinaryReader BinaryReader(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToBinaryReader(encoding, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.IO.BinaryWriter"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamExtensions.ToBinaryWriter(Stream, Encoding, bool)"/>
  public static BinaryWriter BinaryWriter(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToBinaryWriter(encoding, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.IO.StreamReader"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamExtensions.ToStreamReader(Stream, Encoding, bool)"/>
  public static StreamReader StreamReader(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToStreamReader(encoding, close), error);

  /// <summary>
  ///   <para>Converts given <see cref="Stream"/> instance to the instance of <see cref="System.IO.StreamWriter"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="close"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StreamExtensions.ToStreamWriter(Stream, Encoding, bool)"/>
  public static StreamWriter StreamWriter(this IConversion<Stream> conversion, Encoding encoding = null, bool close = true, string error = null) => conversion.To(stream => stream.ToStreamWriter(encoding, close), error);
}