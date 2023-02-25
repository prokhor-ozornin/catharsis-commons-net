using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="XDocument"/> type.</para>
/// </summary>
/// <seealso cref="XDocument"/>
public static class XDocumentConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="XDocument"/> instance to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="BytesAsync(IConversion{XDocument}, CancellationToken, string)"/>
  /// <seealso cref="XDocumentExtensions.ToBytes(XDocument)"/>
  public static byte[] Bytes(this IConversion<XDocument> conversion, string error = null) => conversion.To(document => document.ToBytes(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="XDocument"/> instance to the instance of <see cref="Task{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="Bytes(IConversion{XDocument}, string)"/>
  /// <seealso cref="XDocumentExtensions.ToBytesAsync(XDocument, CancellationToken)"/>
  public static Task<byte[]> BytesAsync(this IConversion<XDocument> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(document => document.ToBytesAsync(cancellation), error);

  /// <summary>
  ///   <para>Converts given <see cref="XDocument"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="TextAsync(IConversion{XDocument}, CancellationToken, string)"/>
  /// <seealso cref="XDocumentExtensions.ToText(XDocument)"/>
  public static string Text(this IConversion<XDocument> conversion, string error = null) => conversion.To(document => document.ToText(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="XDocument"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="Text(IConversion{XDocument}, string)"/>
  /// <seealso cref="XDocumentExtensions.ToTextAsync(XDocument, CancellationToken)"/>
  public static Task<string> TextAsync(this IConversion<XDocument> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(document => document.ToTextAsync(cancellation), error);
}