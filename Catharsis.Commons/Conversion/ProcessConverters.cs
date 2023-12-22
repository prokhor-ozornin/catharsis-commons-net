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
  ///   <para>Converts given <see cref="Process"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{Process}, string)"/>
  /// <seealso cref="ProcessExtensions.ToBytes(Process)"/>
  public static IEnumerable<byte> Bytes(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToBytes(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="Process"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{Process}, string)"/>
  /// <seealso cref="ProcessExtensions.ToBytesAsync(Process)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToBytesAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="Process"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="TextAsync(IConversion{Process}, string)"/>
  /// <seealso cref="ProcessExtensions.ToText(Process)"/>
  public static string Text(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToText(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="Process"/> instance to the instance of <see cref="Task{string}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{Process}, string)"/>
  /// <seealso cref="ProcessExtensions.ToTextAsync(Process)"/>
  public static Task<string> TextAsync(this IConversion<Process> conversion, string error = null) => conversion.To(process => process.ToTextAsync(), error);
}