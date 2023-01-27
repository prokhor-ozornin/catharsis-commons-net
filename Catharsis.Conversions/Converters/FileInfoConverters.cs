using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="FileInfo"/>
public static class FileInfoConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{FileInfo})"/>
  public static IEnumerable<byte> Bytes(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{FileInfo})"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{FileInfo}, Encoding)"/>
  public static string Text(this IConversion<FileInfo> conversion, Encoding encoding = null) => conversion.To(file => file.ToText(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{FileInfo}, Encoding)"/>
  public static Task<string> TextAsync(this IConversion<FileInfo> conversion, Encoding encoding = null) => conversion.To(file => file.ToTextAsync(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Stream Stream(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="WriteOnlyStream(IConversion{FileInfo})"/>
  public static Stream ReadOnlyStream(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToReadOnlyStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="ReadOnlyStream(IConversion{FileInfo})"/>
  public static Stream WriteOnlyStream(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToWriteOnlyStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StreamReader StreamReader(this IConversion<FileInfo> conversion, Encoding encoding = null) => conversion.To(file => file.ToStreamReader(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StreamWriter StreamWriter(this IConversion<FileInfo> conversion, Encoding encoding = null) => conversion.To(file => file.ToStreamWriter(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlDocument XmlDocument(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToXmlDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocumentAsync(IConversion{FileInfo}, CancellationToken)"/>
  public static XDocument XDocument(this IConversion<FileInfo> conversion) => conversion.To(file => file.ToXDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{FileInfo})"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<FileInfo> conversion, CancellationToken cancellation = default) => conversion.To(file => file.ToXDocumentAsync(cancellation));
}