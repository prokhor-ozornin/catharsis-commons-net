using System.Diagnostics;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Process"/> type.</para>
/// </summary>
/// <seealso cref="Process"/>
public static class ProcessConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{Process}, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{Process}, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToBytesAsync(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{Process}, string)"/>
  public static string Text(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToText(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{Process}, string)"/>
  public static Task<string> TextAsync(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToTextAsync(), error);
}