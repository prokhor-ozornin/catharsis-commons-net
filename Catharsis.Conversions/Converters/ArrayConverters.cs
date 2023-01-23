using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class ArrayConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static byte[] Bytes(this IConversion<char[]> conversion, Encoding encoding = null) => conversion.To(chars => chars.ToBytes(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<char[]> conversion) => conversion.To(chars => chars.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static string Text(this IConversion<byte[]> conversion, Encoding encoding = null) => conversion.To(bytes => bytes.ToText(encoding));
}