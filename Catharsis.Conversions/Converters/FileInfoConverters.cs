using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="FileInfo"/> type.</para>
/// </summary>
/// <seealso cref="FileInfo"/>
public static class FileInfoConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{FileInfo}, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToBytes(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{FileInfo}, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToBytesAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextAsync(IConversion{FileInfo}, Encoding, string)"/>
  public static string Text(this IConversion<FileInfo> conversion, Encoding encoding = null, string error = null) => conversion.To(file => file.ToText(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="Task{string}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{FileInfo}, Encoding, string)"/>
  public static Task<string> TextAsync(this IConversion<FileInfo> conversion, Encoding encoding = null, string error = null) => conversion.To(file => file.ToTextAsync(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.IO.Stream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static Stream Stream(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToStream(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.IO.Stream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="WriteOnlyStream(IConversion{FileInfo}, string)"/>
  public static Stream ReadOnlyStream(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToReadOnlyStream(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.IO.Stream"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ReadOnlyStream(IConversion{FileInfo}, string)"/>
  public static Stream WriteOnlyStream(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToWriteOnlyStream(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.IO.StreamReader"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static StreamReader StreamReader(this IConversion<FileInfo> conversion, Encoding encoding = null, string error = null) => conversion.To(file => file.ToStreamReader(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.IO.StreamWriter"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static StreamWriter StreamWriter(this IConversion<FileInfo> conversion, Encoding encoding = null, string error = null) => conversion.To(file => file.ToStreamWriter(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static XmlDocument XmlDocument(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToXmlDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="System.Xml.Linq.XDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocumentAsync(IConversion{FileInfo}, CancellationToken, string)"/>
  public static XDocument XDocument(this IConversion<FileInfo> conversion, string error = null) => conversion.To(file => file.ToXDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="FileInfo"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocument(IConversion{FileInfo}, string)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<FileInfo> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(file => file.ToXDocumentAsync(cancellation), error);
}