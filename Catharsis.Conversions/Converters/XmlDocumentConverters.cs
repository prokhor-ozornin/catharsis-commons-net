using System.Xml;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="XmlDocument"/> type.</para>
/// </summary>
/// <seealso cref="XmlDocument"/>
public static class XmlDocumentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<XmlDocument> conversion, string error = null) => conversion.To(document => document.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<XmlDocument> conversion, string error = null) => conversion.To(document => document.ToText(), error);
}