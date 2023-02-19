using System.Text;
using System.Xml;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="StringBuilder"/> type.</para>
/// </summary>
/// <seealso cref="StringBuilder"/>
public static class StringBuilderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="format"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StringWriter StringWriter(this IConversion<StringBuilder> conversion, IFormatProvider format = null, string error = null) => conversion.To(builder => builder.ToStringWriter(format), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlWriter XmlWriter(this IConversion<StringBuilder> conversion, string error = null) => conversion.To(builder => builder.ToXmlWriter(), error);
}