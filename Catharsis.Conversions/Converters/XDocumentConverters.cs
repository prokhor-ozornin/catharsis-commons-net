using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="XDocument"/>
public static class XDocumentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{XDocument}, CancellationToken)"/>
  public static byte[] Bytes(this IConversion<XDocument> conversion) => conversion.To(document => document.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{XDocument})"/>
  public static Task<byte[]> BytesAsync(this IConversion<XDocument> conversion, CancellationToken cancellation = default) => conversion.To(document => document.ToBytesAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<XDocument> conversion) => conversion.To(document => document.ToText());
}