using System.Diagnostics;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class ProcessConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<byte> Bytes(this IConversion<Process> conversion) => conversion.To(process => process.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Process> conversion) => conversion.To(process => process.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<Process> conversion) => conversion.To(process => process.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Task<string> TextAsync(this IConversion<Process> conversion) => conversion.To(process => process.ToTextAsync());
}