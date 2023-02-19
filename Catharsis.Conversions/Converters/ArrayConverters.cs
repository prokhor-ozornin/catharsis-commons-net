using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for arrays.</para>
/// </summary>
/// <seealso cref="Array"/>
public static class ArrayConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<char[]> conversion, Encoding encoding = null, string error = null) => conversion.To(chars => chars.ToBytes(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{byte[]}, Encoding, string)"/>
  public static string Text(this IConversion<char[]> conversion, string error = null) => conversion.To(chars => chars.ToText(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{char[]}, string)"/>
  public static string Text(this IConversion<byte[]> conversion, Encoding encoding = null, string error = null) => conversion.To(bytes => bytes.ToText(encoding), error);
}