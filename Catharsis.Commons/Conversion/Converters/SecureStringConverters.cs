using System.Security;
using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="SecureString"/> type.</para>
/// </summary>
/// <seealso cref="SecureString"/>
public static class SecureStringConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="SecureString"/> instance to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding">Text encoding to use or <see langword="null"/> for a default value.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="SecureStringExtensions.ToBytes(SecureString, Encoding)"/>
  public static byte[] Bytes(this IConversion<SecureString> conversion, Encoding encoding = null, string error = null) => conversion.To(secure => secure.ToBytes(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="SecureString"/> instance to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="SecureStringExtensions.ToText(SecureString)"/>
  public static string Text(this IConversion<SecureString> conversion, string error = null) => conversion.To(secure => secure.ToText(), error);
}