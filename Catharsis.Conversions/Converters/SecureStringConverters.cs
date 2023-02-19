using System.Security;
using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="SecureString"/> type.</para>
/// </summary>
/// <seealso cref="SecureString"/>
public static class SecureStringConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<SecureString> conversion, Encoding encoding = null, string error = null) => conversion.To(secure => secure.ToBytes(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string Text(this IConversion<SecureString> conversion, string error = null) => conversion.To(secure => secure.ToText(), error);
}