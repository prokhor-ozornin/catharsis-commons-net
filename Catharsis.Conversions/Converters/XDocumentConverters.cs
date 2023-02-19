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
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{XDocument}, CancellationToken, string)"/>
  public static byte[] Bytes(this IConversion<XDocument> conversion, string error = null) => conversion.To(document => document.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{XDocument}, string)"/>
  public static Task<byte[]> BytesAsync(this IConversion<XDocument> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(document => document.ToBytesAsync(cancellation), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<XDocument> conversion, string error = null) => conversion.To(document => document.ToText(), error);
}