using System.Diagnostics;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="Process"/>
public static class ProcessConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{Process})"/>
  public static IEnumerable<byte> Bytes(this IConversion<Process> conversion) => conversion.To(process => process.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{Process})"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Process> conversion) => conversion.To(process => process.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="TextAsync(IConversion{Process})"/>
  public static string Text(this IConversion<Process> conversion) => conversion.To(process => process.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Text(IConversion{Process})"/>
  public static Task<string> TextAsync(this IConversion<Process> conversion) => conversion.To(process => process.ToTextAsync());
}