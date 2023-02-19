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
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="encoding"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<string> conversion, Encoding encoding = null, string error = null) => conversion.To(text => text.ToBytes(encoding), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static bool Boolean(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToBoolean(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static sbyte Sbyte(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToSbyte(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte Byte(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToByte(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static short Short(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToShort(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ushort Ushort(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUshort(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static int Int(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToInt(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static uint Uint(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUint(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static long Long(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToLong(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static ulong Ulong(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUlong(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static float Float(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToFloat(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static double Double(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDouble(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static decimal Decimal(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDecimal(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Guid Guid(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToGuid(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Uri Uri(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToUri(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Type Type(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToType(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTime DateTime(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDateTime(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateTimeOffset DateTimeOffset(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDateTimeOffset(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static FileInfo FileInfo(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToFile(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DirectoryInfo DirectoryInfo(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDirectory(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IPAddress IPAddress(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToIpAddress(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IPHostEntry IPHostEntry(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToIpHost(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Regex Regex(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToRegex(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StringBuilder StringBuilder(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToStringBuilder(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static StringReader StringReader(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToStringReader(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Process Process(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToProcess(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static XmlDocument XmlDocument(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToXmlDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocumentAsync(IConversion{string}, CancellationToken, string)"/>
  public static XDocument XDocument(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToXDocument(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="XDocument(IConversion{string}, string)"/>
  public static Task<XDocument> XDocumentAsync(this IConversion<string> conversion, CancellationToken cancellation = default, string error = null) => conversion.To(text => text.ToXDocumentAsync(cancellation), error);

  #if NET7_0_OR_GREATER
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static DateOnly DateOnly(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToDateOnly(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static TimeOnly TimeOnly(this IConversion<string> conversion, string error = null) => conversion.To(text => text.ToTimeOnly(), error);
  #endif
}