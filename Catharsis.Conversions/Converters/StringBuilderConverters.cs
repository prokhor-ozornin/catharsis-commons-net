using System.Text;
using System.Xml;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
/// <seealso cref="StringBuilder"/>
public static class StringBuilderConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="format"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StringWriter StringWriter(this IConversion<StringBuilder> conversion, IFormatProvider format = null) => conversion.To(builder => builder.ToStringWriter(format));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlWriter XmlWriter(this IConversion<StringBuilder> conversion) => conversion.To(builder => builder.ToXmlWriter());
}