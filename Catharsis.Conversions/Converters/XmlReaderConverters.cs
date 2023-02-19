using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="XmlReader"/> type.</para>
/// </summary>
/// <seealso cref="XmlReader"/>
public static class XmlReaderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToText(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlDocument XmlDocument(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToXmlDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocumentAsync(IConversion{XmlReader}, CancellationToken, string)"/>
  public static XDocument XDocument(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToXDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{XmlReader}, string)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<XmlReader> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(reader => reader.ToXDocumentAsync(cancellation), error);
}