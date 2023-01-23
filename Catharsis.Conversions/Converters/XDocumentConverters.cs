using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class XDocumentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static byte[] Bytes(this IConversion<XDocument> conversion) => conversion.To(document => document.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<byte[]> BytesAsync(this IConversion<XDocument> conversion, CancellationToken cancellation = default) => conversion.To(document => document.ToBytesAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<XDocument> conversion) => conversion.To(document => document.ToText());
}