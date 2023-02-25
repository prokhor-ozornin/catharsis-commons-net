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
  ///   <para>Converts given <see cref="char"/> array to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding">Text encoding to use or <see langword="null"/> for a default value.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="ArrayExtensions.ToBytes(char[], Encoding)"/>
  public static byte[] Bytes(this IConversion<char[]> conversion, Encoding encoding = null, string error = null) => conversion.To(chars => chars.ToBytes(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="char"/> array to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{byte[]}, Encoding, string)"/>
  /// <seealso cref="ArrayExtensions.ToText(char[])"/>
  public static string Text(this IConversion<char[]> conversion, string error = null) => conversion.To(chars => chars.ToText(), error);

  /// <summary>
  ///   <para>Converts given <see cref="byte"/> array to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding">Text encoding to use or <see langword="null"/> for a default value.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="Text(IConversion{char[]}, string)"/>
  /// <seealso cref="ArrayExtensions.ToText(byte[], Encoding)"/>
  public static string Text(this IConversion<byte[]> conversion, Encoding encoding = null, string error = null) => conversion.To(bytes => bytes.ToText(encoding), error);
}