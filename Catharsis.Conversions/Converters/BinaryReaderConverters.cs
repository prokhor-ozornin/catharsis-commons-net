using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="BinaryReader"/> type.</para>
/// </summary>
/// <seealso cref="BinaryReader"/>
public static class BinaryReaderConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="BinaryReader"/> instance to the instance of <see cref="IEnumerable{T}"/> type.</para>
  ///   <para>Conversion is performed by returning all available bytes from the underlying reader's stream.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BytesAsync(IConversion{BinaryReader}, string)"/>
  /// <seealso cref="BinaryReaderExtensions.ToBytes(BinaryReader)"/>
  public static IEnumerable<byte> Bytes(this IConversion<BinaryReader> conversion, string error = null) => conversion.To(reader => reader.ToBytes(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="BinaryReader"/> instance to the instance of <see cref="IAsyncEnumerable{T}"/> type.</para>
  ///   <para>Conversion is performed by returning all available bytes from the underlying reader's stream.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Bytes(IConversion{BinaryReader}, string)"/>
  /// <seealso cref="BinaryReaderExtensions.ToBytesAsync(BinaryReader)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<BinaryReader> conversion, string error = null) => conversion.To(reader => reader.ToBytesAsync(), error);

  /// <summary>
  ///   <para>Converts given <see cref="BinaryReader"/> instance to the instance of <see cref="string"/> type.</para>
  ///   <para>Conversion is performed by reading a string from the underlying reader's stream.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="BinaryReaderExtensions.ToText(BinaryReader)"/>
  public static string Text(this IConversion<BinaryReader> conversion, string error = null) => conversion.To(reader => reader.ToText(), error);

  /// <summary>
  ///   <para>Converts given <see cref="BinaryReader"/> instance to the instance of <see cref="IEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{BinaryReader}, int, string)"/>
  /// <seealso cref="BinaryReaderExtensions.ToEnumerable(BinaryReader)"/>
  public static IEnumerable<byte> Enumerable(this IConversion<BinaryReader> conversion, string error = null) => conversion.To(reader => reader.ToEnumerable(), error);

  /// <summary>
  ///   <para>Converts given <see cref="BinaryReader"/> instance to the instance of <see cref="IEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count">Size of bytes block to read.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Enumerable(IConversion{BinaryReader}, string)"/>
  /// <seealso cref="BinaryReaderExtensions.ToEnumerable(BinaryReader, int)"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<BinaryReader> conversion, int count, string error = null) => conversion.To(reader => reader.ToEnumerable(count), error);

  /// <summary>
  ///   <para>Converts given <see cref="BinaryReader"/> instance to the instance of <see cref="IAsyncEnumerable{byte}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{BinaryReader}, int, string)"/>
  /// <seealso cref="BinaryReaderExtensions.ToAsyncEnumerable(BinaryReader)"/>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<BinaryReader> conversion, string error = null) => conversion.To(reader => reader.ToAsyncEnumerable(), error);

  /// <summary>
  ///   <para>Converts given <see cref="BinaryReader"/> instance to the instance of <see cref="IAsyncEnumerable{byte[]}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="count">Size of bytes block to read.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="AsyncEnumerable(IConversion{BinaryReader}, string)"/>
  /// <seealso cref="BinaryReaderExtensions.ToAsyncEnumerable(BinaryReader, int)"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<BinaryReader> conversion, int count, string error = null) => conversion.To(reader => reader.ToAsyncEnumerable(count), error);
}