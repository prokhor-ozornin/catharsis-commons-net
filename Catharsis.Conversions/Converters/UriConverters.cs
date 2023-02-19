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
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static IEnumerable<byte> Bytes(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToBytes(timeout, headers), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToBytesAsync(timeout, headers), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<Uri> conversion, Encoding encoding = null, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToText(encoding, timeout, headers), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XmlDocumentAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static XmlDocument XmlDocument(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToXmlDocument(timeout, headers), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XmlDocument(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static Task<XmlDocument> XmlDocumentAsync(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params (string Name, object Value)[] headers) => conversion.To(uri => uri.ToXmlDocumentAsync(timeout, headers), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="timeout"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XmlDocumentAsync(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static XDocument XDocument(this IConversion<Uri> conversion, TimeSpan? timeout = null, string error = null, params(string Name, object Value)[] headers) => conversion.To(uri => uri.ToXDocument(timeout, headers), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="timeout"></param>
  /// <param name="cancellation"></param>
  /// <param name="headers"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{Uri}, TimeSpan?, (string Name, object Value)[])"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<Uri> conversion, TimeSpan? timeout = null, CancellationToken cancellation = default, string error = null, params (string Name, object Value)[] headers) => conversion.To(uri => uri.ToXDocumentAsync(timeout, cancellation, headers), error);
}