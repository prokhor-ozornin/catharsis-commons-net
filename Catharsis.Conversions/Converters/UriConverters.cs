using System.Text;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Uri"/> type.</para>
/// </summary>
/// <seealso cref="Uri"/>
public static class UriConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static IEnumerable<byte> Bytes(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToBytes(timeout, headers), error);

  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToBytesAsync(timeout, headers), error);

  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static string Text(this IConversion<Uri> conversion, Encoding encoding = null, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToText(encoding, timeout, headers), error);

  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlDocumentAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static XmlDocument XmlDocument(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToXmlDocument(timeout, headers), error);

  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="Task{XmlDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlDocument(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static Task<XmlDocument> XmlDocumentAsync(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params (string Name, object Value)[] headers) => conversion.To(uri => uri.ToXmlDocumentAsync(timeout, headers), error);

  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="System.Xml.Linq.XDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XmlDocumentAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static XDocument XDocument(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToXDocument(timeout, headers), error);

  /// <summary>
  ///   <para>Converts given <see cref="Uri"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="timeout"></param>
  /// <param name="cancellation"></param>
  /// <param name="headers"></param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <seealso cref="XDocument(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<Uri> conversion, TimeSpan? timeout = null, CancellationToken cancellation = default, string error = null, params (string Name, object Value)[] headers) => conversion.To(uri => uri.ToXDocumentAsync(timeout, cancellation, headers), error);
}