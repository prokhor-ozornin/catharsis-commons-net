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
  ///   <para>Converts given <see cref="XmlReader"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlReaderExtensions.ToText(XmlReader)"/>
  public static string Text(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToText(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="XmlReader"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlReaderExtensions.ToTextAsync(XmlReader)"/>
  public static Task<string> TextAsync(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToTextAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="XmlReader"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlReaderExtensions.ToXmlDocument(XmlReader)"/>
  public static XmlDocument XmlDocument(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToXmlDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="XmlReader"/> instance to the instance of <see cref="System.Xml.Linq.XDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XDocumentAsync(IConversion{XmlReader}, CancellationToken, string)"/>
  /// <seealso cref="XmlReaderExtensions.ToXDocument(XmlReader)"/>
  public static XDocument XDocument(this IConversion<XmlReader> conversion, string error = null) => conversion.To(reader => reader.ToXDocument(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="XmlReader"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XDocument(IConversion{XmlReader}, string)"/>
  /// <seealso cref="XmlReaderExtensions.ToXDocumentAsync(XmlReader, CancellationToken)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<XmlReader> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(reader => reader.ToXDocumentAsync(cancellation), error);
}