using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="BinaryReader"/>
public static class BinaryReaderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{BinaryReader})"/>
  public static IEnumerable<byte> Bytes(this IConversion<BinaryReader> conversion) => conversion.To(reader => reader.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{BinaryReader})"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<BinaryReader> conversion) => conversion.To(reader => reader.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<BinaryReader> conversion) => conversion.To(reader => reader.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{BinaryReader}, int)"/>
  public static IEnumerable<byte> Enumerable(this IConversion<BinaryReader> conversion) => conversion.To(reader => reader.ToEnumerable());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{BinaryReader})"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<BinaryReader> conversion, int count) => conversion.To(reader => reader.ToEnumerable(count));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{BinaryReader}, int)"/>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<BinaryReader> conversion) => conversion.To(reader => reader.ToAsyncEnumerable());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{BinaryReader})"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<BinaryReader> conversion, int count) => conversion.To(reader => reader.ToAsyncEnumerable(count));
}