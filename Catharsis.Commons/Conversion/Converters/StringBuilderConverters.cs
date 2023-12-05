using System.Text;
using System.Xml;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Set of converters for <see cref="StringBuilder"/> type.</para>
/// </summary>
/// <seealso cref="StringBuilder"/>
public static class StringBuilderConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="StringBuilder"/> instance to the instance of <see cref="System.IO.StringWriter"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringBuilderExtensions.ToStringWriter(StringBuilder, IFormatProvider)"/>
  public static StringWriter StringWriter(this IConversion<StringBuilder> conversion, IFormatProvider format = null, string error = null) => conversion.To(builder => builder.ToStringWriter(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="StringBuilder"/> instance to the instance of <see cref="System.Xml.XmlWriter"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringBuilderExtensions.ToXmlWriter(StringBuilder)"/>
  public static XmlWriter XmlWriter(this IConversion<StringBuilder> conversion, string error = null) => conversion.To(builder => builder.ToXmlWriter(), error);
}