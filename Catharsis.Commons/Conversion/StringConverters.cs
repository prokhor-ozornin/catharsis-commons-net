using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="string"/> type.</para>
/// </summary>
/// <seealso cref="string"/>
public static class StringConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="encoding">Text encoding to use or <see langword="null"/> for a default value.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToByte(string, IFormatProvider)"/>
  public static byte[] Bytes(this IConversion<string> conversion, Encoding encoding = null, string error = null) => conversion.To(text => text.ToBytes(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="bool"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToBoolean(string)"/>
  public static bool Boolean(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToBoolean(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="sbyte"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToSbyte(string, IFormatProvider)"/>
  public static sbyte Sbyte(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToSbyte(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="byte"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToByte(string, IFormatProvider)"/>
  public static byte Byte(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToByte(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="short"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToShort(string, IFormatProvider)"/>
  public static short Short(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToShort(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="ushort"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToUshort(string, IFormatProvider)"/>
  public static ushort Ushort(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToUshort(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="int"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToInt(string, IFormatProvider)"/>
  public static int Int(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToInt(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="uint"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToUint(string, IFormatProvider)"/>
  public static uint Uint(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToUint(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="long"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToLong(string, IFormatProvider)"/>
  public static long Long(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToLong(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="ulong"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToUlong(string, IFormatProvider)"/>
  public static ulong Ulong(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToUlong(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="float"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToFloat(string, IFormatProvider)"/>
  public static float Float(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToFloat(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="double"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToDouble(string, IFormatProvider)"/>
  public static double Double(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToDouble(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="decimal"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToDecimal(string, IFormatProvider)"/>
  public static decimal Decimal(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToDecimal(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Guid"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToGuid(string)"/>
  public static Guid Guid(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToGuid(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Uri"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToUri(string)"/>
  public static Uri Uri(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUri(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Type"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToType(string)"/>
  public static Type Type(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToType(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.DateTime"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToDateTime(string, IFormatProvider)"/>
  public static DateTime DateTime(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToDateTime(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.DateTimeOffset"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToDateTimeOffset(string, IFormatProvider)"/>
  public static DateTimeOffset DateTimeOffset(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToDateTimeOffset(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.IO.FileInfo"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToFile(string)"/>
  public static FileInfo FileInfo(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToFile(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.IO.DirectoryInfo"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToDirectory(string)"/>
  public static DirectoryInfo DirectoryInfo(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDirectory(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Net.IPAddress"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToIpAddress(string)"/>
  public static IPAddress IPAddress(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToIpAddress(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Net.IPHostEntry"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToIpHost(string)"/>
  public static IPHostEntry IPHostEntry(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToIpHost(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Text.RegularExpressions.Regex"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToRegex(string, RegexOptions)"/>
  public static Regex Regex(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToRegex(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Text.StringBuilder"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToStringBuilder(string)"/>
  public static StringBuilder StringBuilder(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToStringBuilder(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.IO.StringReader"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToStringReader(string)"/>
  public static StringReader StringReader(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToStringReader(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Diagnostics.Process"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToProcess(string, ProcessStartInfo)"/>
  public static Process Process(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToProcess(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToXmlDocument(string)"/>
  public static XmlDocument XmlDocument(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToXmlDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Xml.Linq.XDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocumentAsync(IConversion{string}, CancellationToken, string)"/>
  /// <seealso cref="StringExtensions.ToXDocument(string)"/>
  public static XDocument XDocument(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToXDocument(), error);

  /// <summary>
  ///   <para>Asynchronously converts given <see cref="string"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation">Token to use for asynchronous cancellation of conversion.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocument(IConversion{string}, string)"/>
  /// <seealso cref="StringExtensions.ToXDocumentAsync(string, CancellationToken)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<string> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(text => text.ToXDocumentAsync(cancellation), error);

#if NET7_0_OR_GREATER
  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.DateOnly"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToDateOnly(string, IFormatProvider)"/>
  public static DateOnly DateOnly(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToDateOnly(format), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.TimeOnly"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="StringExtensions.ToTimeOnly(string, IFormatProvider)"/>
  public static TimeOnly TimeOnly(this IConversion<string> conversion, IFormatProvider format = null, string error = null) => conversion.To(text => text.ToTimeOnly(format), error);
  #endif
}