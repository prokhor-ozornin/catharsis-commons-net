using System.Xml;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class XmlDocumentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static byte[] Bytes(this IConversion<XmlDocument> conversion) => conversion.To(document => document.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<XmlDocument> conversion) => conversion.To(document => document.ToText());
}