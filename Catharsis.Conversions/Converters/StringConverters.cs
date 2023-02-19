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
  /// <param name="encoding"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static byte[] Bytes(this IConversion<string> conversion, Encoding encoding = null, string error = null) => conversion.To(text => text.ToBytes(encoding), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="bool"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static bool Boolean(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToBoolean(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="sbyte"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static sbyte Sbyte(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToSbyte(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="byte"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static byte Byte(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToByte(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="short"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static short Short(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToShort(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="ushort"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static ushort Ushort(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUshort(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="int"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static int Int(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToInt(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="uint"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static uint Uint(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUint(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="long"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static long Long(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToLong(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="ulong"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static ulong Ulong(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUlong(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="float"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static float Float(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToFloat(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="double"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static double Double(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDouble(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the <see cref="decimal"/> value.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static decimal Decimal(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDecimal(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Guid"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static Guid Guid(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToGuid(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Uri"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static Uri Uri(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUri(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Type"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static Type Type(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToType(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.DateTime"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static DateTime DateTime(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDateTime(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.DateTimeOffset"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static DateTimeOffset DateTimeOffset(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDateTimeOffset(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.IO.FileInfo"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static FileInfo FileInfo(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToFile(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.IO.DirectoryInfo"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static DirectoryInfo DirectoryInfo(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDirectory(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Net.IPAddress"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static IPAddress IPAddress(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToIpAddress(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Net.IPHostEntry"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static IPHostEntry IPHostEntry(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToIpHost(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Text.RegularExpressions.Regex"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static Regex Regex(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToRegex(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Text.StringBuilder"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static StringBuilder StringBuilder(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToStringBuilder(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.IO.StringReader"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static StringReader StringReader(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToStringReader(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Diagnostics.Process"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static Process Process(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToProcess(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.Xml.XmlDocument"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
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
  public static XDocument XDocument(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToXDocument(), error);

  /// <summary>
  ///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="Task{XDocument}"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="cancellation"></param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="XDocument(IConversion{string}, string)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<string> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(text => text.ToXDocumentAsync(cancellation), error);

#if NET7_0_OR_GREATER
/// <summary>
///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.DateOnly"/> type.</para>
/// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static DateOnly DateOnly(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDateOnly(), error);

/// <summary>
///   <para>Converts given <see cref="string"/> instance to the instance of <see cref="System.TimeOnly"/> type.</para>
/// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static TimeOnly TimeOnly(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToTimeOnly(), error);
  #endif
}