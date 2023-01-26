using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class XmlReaderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<XmlReader> conversion) => conversion.To(reader => reader.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlDocument XmlDocument(this IConversion<XmlReader> conversion) => conversion.To(reader => reader.ToXmlDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocumentAsync(IConversion{XmlReader}, CancellationToken)"/>
  public static XDocument XDocument(this IConversion<XmlReader> conversion) => conversion.To(reader => reader.ToXDocument());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{XmlReader})"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<XmlReader> conversion, CancellationToken cancellation = default) => conversion.To(reader => reader.ToXDocumentAsync(cancellation));
}