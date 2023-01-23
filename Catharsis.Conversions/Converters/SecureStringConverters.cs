using System.Security;
using System.Text;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class SecureStringConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <returns></returns>
  public static byte[] Bytes(this IConversion<SecureString> conversion, Encoding encoding = null) => conversion.To(secure => secure.ToBytes(encoding));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<SecureString> conversion) => conversion.To(secure => secure.ToText());
}