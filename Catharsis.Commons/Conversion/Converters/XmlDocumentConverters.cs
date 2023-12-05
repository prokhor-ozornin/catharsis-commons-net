using System.Xml;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="XmlDocument"/> type.</para>
/// </summary>
/// <seealso cref="XmlDocument"/>
public static class XmlDocumentConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="XmlDocument"/> instance to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlDocumentExtensions.ToBytes(XmlDocument)"/>
  public static byte[] Bytes(this IConversion<XmlDocument> conversion, string error = null) => conversion.To(document => document.ToBytes(), error);

  /// <summary>
  ///   <para>Converts given <see cref="XmlDocument"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlDocumentExtensions.ToText(XmlDocument)"/>
  public static string Text(this IConversion<XmlDocument> conversion, string error = null) => conversion.To(document => document.ToText(), error);
}