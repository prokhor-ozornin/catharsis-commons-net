using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="Array"/>
public static class ArrayConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<char[]> conversion, Encoding encoding = null) => conversion.To(chars => chars.ToBytes(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{byte[]}, Encoding)"/>
  public static string Text(this IConversion<char[]> conversion) => conversion.To(chars => chars.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{char[]})"/>
  public static string Text(this IConversion<byte[]> conversion, Encoding encoding = null) => conversion.To(bytes => bytes.ToText(encoding));
}