using System.Collections;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml;
using static System.Math;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>A set of extension methods for the <see cref="IConverter"/> interface.</para>
/// </summary>
/// <seealso cref="IConverter"/>
public static class IConverterExtensions
{
  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="encoding">Text encoding to use or a <see langword="null"/> reference for a default value.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static string String(this IConverter converter, object instance, Encoding encoding = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      string text => text,
      BinaryReader reader => reader.ToText(),
      SecureString secure => secure.ToText(),
      FileInfo file => file.ToTextAsync(encoding).Await(),
      HttpContent http => http.ToTextAsync().Await(),
      Process process => process.ToTextAsync().Await(),
      Stream stream => stream.ToTextAsync(encoding).Await(),
      TextReader reader => reader.ToTextAsync().Await(),
      Uri uri => uri.ToTextAsync(encoding).Await(),
      XmlDocument xml => xml.ToText(),
      XDocument xml => xml.ToTextAsync().Await(),
      XmlReader xml => xml.ToTextAsync().Await(),
      _ => instance.ToInvariantString()
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="string"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="encoding">Text encoding to use or a <see langword="null"/> reference for a default value.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool String(this IConverter converter, object instance, out string result, Encoding encoding = null) => (result = converter.String(instance, encoding)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the array of <see cref="byte"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="encoding">Text encoding to use or a <see langword="null"/> reference for a default value.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static byte[] Binary(this IConverter converter, object instance, Encoding encoding = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      IEnumerable<byte> bytes => bytes.AsArray(),
      string text => text.ToBytes(encoding),
      SecureString secure => secure.ToText().ToBytes(encoding),
      Guid guid => guid.ToByteArray(),
      FileInfo file => file.ToBytesAsync().ToArray(),
      IPAddress address => address.ToBytes(),
      PhysicalAddress address => address.ToBytes(),
      HttpContent http => http.ToBytesAsync().ToArray(),
      Process process => process.ToBytesAsync().ToArray(),
      Stream stream => stream.ToBytesAsync().ToArray(),
      Uri uri => uri.ToBytesAsync().ToArray(),
      XmlDocument xml => xml.ToBytes(),
      XDocument xml => xml.ToBytesAsync().Await(),
      _ => instance.ToInvariantString().ToBytes(encoding)
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the array of <see cref="byte"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="encoding">Text encoding to use or a <see langword="null"/> reference for a default value.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Binary(this IConverter converter, object instance, out byte[] result, Encoding encoding = null) => (result = converter.Binary(instance, encoding)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the array of <see cref="T"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of array elements.</typeparam>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static T[] Array<T>(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      T[] array => array,
      IEnumerable<T> sequence => sequence.AsArray(),
      IAsyncEnumerable<T> sequence => sequence.ToArray(),
      _ => [(T) instance]
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the array of <see cref="T"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of array elements.</typeparam>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Array<T>(this IConverter converter, object instance, out T[] result) => (result = converter.Array<T>(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="sbyte"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text format controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static sbyte? Sbyte(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => value,
      byte value => (sbyte) value,
      short value => (sbyte) value,
      ushort value => (sbyte) value,
      int value => (sbyte) value,
      uint value => (sbyte) value,
      long value => (sbyte) value,
      ulong value => (sbyte) value,
      float value => (sbyte) Round(value),
      double value => (sbyte) Round(value),
      decimal value => (sbyte) Round(value),
      _ => instance.ToFormattedString(format).ToSbyte(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="sbyte"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Sbyte(this IConverter converter, object instance, out sbyte? result, IFormatProvider format = null) => (result = converter.Sbyte(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="byte"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static byte? Byte(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => (byte) value,
      byte value => value,
      short value => (byte) value,
      ushort value => (byte) value,
      int value => (byte) value,
      uint value => (byte) value,
      long value => (byte) value,
      ulong value => (byte) value,
      float value => (byte) Round(value),
      double value => (byte) Round(value),
      decimal value => (byte) Round(value),
      _ => instance.ToFormattedString(format).ToByte(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="byte"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Byte(this IConverter converter, object instance, out byte? result, IFormatProvider format = null) => (result = converter.Byte(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="short"/> type.</para>
  /// </summary>
  /// <param name="converter">Extended converter instance.</param>
  /// <param name="instance">Target object for conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static short? Short(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => value,
      byte value => value,
      short value => value,
      ushort value => (short) value,
      int value => (short) value,
      uint value => (short) value,
      long value => (short) value,
      ulong value => (short) value,
      float value => (short) Round(value),
      double value => (short) Round(value),
      decimal value => (short) Round(value),
      _ => instance.ToFormattedString(format).ToShort(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="short"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Short(this IConverter converter, object instance, out short? result, IFormatProvider format = null) => (result = converter.Short(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="ushort"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static ushort? Ushort(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => (ushort) value,
      byte value => value,
      short value => (ushort) value,
      ushort value => value,
      int value => (ushort) value,
      uint value => (ushort) value,
      long value => (ushort) value,
      ulong value => (ushort) value,
      float value => (ushort) Round(value),
      double value => (ushort) Round(value),
      decimal value => (ushort) Round(value),
      _ => instance.ToFormattedString(format).ToUshort(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="ushort"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Ushort(this IConverter converter, object instance, out ushort? result, IFormatProvider format = null) => (result = converter.Ushort(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="int"/> type.</para>
  /// </summary>
  /// <param name="converter">Extended converter instance.</param>
  /// <param name="instance">Target object for conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static int? Int(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => value,
      byte value => value,
      short value => value,
      ushort value => value,
      int value => value,
      uint value => (int) value,
      long value => (int) value,
      ulong value => (int) value,
      float value => (int) Round(value),
      double value => (int) Round(value),
      decimal value => (int) Round(value),
      _ => instance.ToFormattedString(format).ToInt(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="int"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Int(this IConverter converter, object instance, out int? result, IFormatProvider format = null) => (result = converter.Int(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="uint"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static uint? Uint(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => (uint) value,
      byte value => value,
      short value => (uint) value,
      ushort value => value,
      int value => (uint) value,
      uint value => value,
      long value => (uint) value,
      ulong value => (uint) value,
      float value => (uint) Round(value),
      double value => (uint) Round(value),
      decimal value => (uint) Round(value),
      _ => instance.ToFormattedString(format).ToUint(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="uint"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Uint(this IConverter converter, object instance, out uint? result, IFormatProvider format = null) => (result = converter.Uint(instance, format)) is not null;

  /// <summary>
  ///   <para>Converts target object to the <see cref="long"/> value. Returns <c>null</c> if object is a <c>null</c> reference or conversion is not possible.</para>
  /// </summary>
  /// <param name="converter">Extended converter instance.</param>
  /// <param name="instance">Target object for conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static long? Long(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => value,
      byte value => value,
      short value => value,
      ushort value => value,
      int value => value,
      uint value => value,
      long value => value,
      ulong value => (long) value,
      float value => (long) Round(value),
      double value => (long) Round(value),
      decimal value => (long) Round(value),
      _ => instance.ToFormattedString(format).ToLong(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="long"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Long(this IConverter converter, object instance, out long? result, IFormatProvider format = null) => (result = converter.Long(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="ulong"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static ulong? Ulong(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => (ulong) value,
      byte value => value,
      short value => (ulong) value,
      ushort value => value,
      int value => (ulong) value,
      uint value => value,
      long value => (ulong) value,
      ulong value => value,
      float value => (ulong) Round(value),
      double value => (ulong) Round(value),
      decimal value => (ulong) Round(value),
      _ => instance.ToFormattedString(format).ToUlong(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="ulong"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Ulong(this IConverter converter, object instance, out ulong? result, IFormatProvider format = null) => (result = converter.Ulong(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="float"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static float? Float(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => (float) value,
      byte value => (float) value,
      short value => (float) value,
      ushort value => (float) value,
      int value => (float) value,
      uint value => (float) value,
      long value => (float) value,
      ulong value => (float) value,
      float value => value,
      double value => (float) value,
      decimal value => (float) value,
      _ => instance.ToFormattedString(format).ToFloat(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="float"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Float(this IConverter converter, object instance, out float? result, IFormatProvider format = null) => (result = converter.Float(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="double"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static double? Double(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => (double) value,
      byte value => (double) value,
      short value => (double) value,
      ushort value => (double) value,
      int value => (double) value,
      uint value => (double) value,
      long value => (double) value,
      ulong value => (double) value,
      float value => (double) value,
      double value => value,
      decimal value => (double) value,
      _ => instance.ToFormattedString(format).ToDouble(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="double"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Double(this IConverter converter, object instance, out double? result, IFormatProvider format = null) => (result = converter.Double(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="decimal"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static decimal? Decimal(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      sbyte value => value,
      byte value => value,
      short value => value,
      ushort value => value,
      int value => value,
      uint value => value,
      long value => value,
      ulong value => value,
      float value => (decimal) value,
      double value => (decimal) value,
      decimal value => value,
      _ => instance.ToFormattedString(format).ToDecimal(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="decimal"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Decimal(this IConverter converter, object instance, out decimal? result, IFormatProvider format = null) => (result = converter.Decimal(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="Enum"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of enumeration.</typeparam>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static T? Enum<T>(this IConverter converter, object instance) where T : struct
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      _ => (T?) (instance is T ? instance : instance.ToInvariantString().ToEnum<T>(out var result) ? result : null)
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="Enum"/> type.</para>
  /// </summary>
  /// <typeparam name="T">Type of enumeration.</typeparam>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Enum<T>(this IConverter converter, object instance, out T? result) where T : struct => (result = converter.Enum<T>(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.DateTime"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static DateTime? DateTime(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      DateTime dateTime => dateTime,
      DateTimeOffset dateTimeOffset => dateTimeOffset.ToDateTime(),
      
      #if NET8_0_OR_GREATER
      DateOnly dateOnly => dateOnly.ToDateTime(),
      #endif
      
      _ => instance.ToFormattedString(format).ToDateTime(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.DateTime"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool DateTime(this IConverter converter, object instance, out DateTime? result, IFormatProvider format = null) => (result = converter.DateTime(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.DateTimeOffset"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static DateTimeOffset? DateTimeOffset(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      DateTime dateTime => dateTime.ToDateTimeOffset(),
      DateTimeOffset dateTimeOffset => dateTimeOffset,

      #if NET8_0_OR_GREATER
      DateOnly dateOnly => dateOnly.ToDateTimeOffset(),
      #endif
      
      _ => instance.ToFormattedString(format).ToDateTimeOffset(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.DateTimeOffset"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool DateTimeOffset(this IConverter converter, object instance, out DateTimeOffset? result, IFormatProvider format = null) => (result = converter.DateTimeOffset(instance, format)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Guid"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static Guid? Guid(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      Guid guid => guid,
      byte[] bytes => bytes.Length == 16 ? new Guid(bytes) : null,
      _ => instance.ToInvariantString().ToGuid(out var result) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Guid"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Guid(this IConverter converter, object instance, out Guid? result) => (result = converter.Guid(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Text.RegularExpressions.Regex"/> type.</para>
  /// </summary>
  /// <param name="converter">Extended converter instance.</param>
  /// <param name="instance">Target object for conversion.</param>
  /// <param name="options">Expression creation options.</param> 
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static Regex Regex(this IConverter converter, object instance, RegexOptions options = RegexOptions.None)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      Regex regex => regex,
      _ => instance.ToInvariantString().ToRegex(options)
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Text.RegularExpressions.Regex"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="options">Expression creation options.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Regex(this IConverter converter, object instance, out Regex result, RegexOptions options = RegexOptions.None) => (result = converter.Regex(instance, options)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Uri"/> type.</para>
  /// </summary>
  /// <param name="converter">Extended converter instance.</param>
  /// <param name="instance">Target object for conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static Uri Uri(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      Uri uri => uri,
      _ => instance.ToInvariantString().ToUri(out var result) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Uri"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Uri(this IConverter converter, object instance, out Uri result) => (result = converter.Uri(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Text.StringBuilder"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static StringBuilder StringBuilder(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      StringBuilder builder => builder,
      _ => instance.ToInvariantString().ToStringBuilder()
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Text.StringBuilder"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool StringBuilder(this IConverter converter, object instance, out StringBuilder result) => (result = converter.StringBuilder(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="IPAddress"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static IPAddress IpAddress(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      IPAddress ipAddress => ipAddress,
      long address => new IPAddress(address),
      uint address => new IPAddress(address),
      _ => instance.ToInvariantString().ToIpAddress(out var result) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="IPAddress"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool IpAddress(this IConverter converter, object instance, out IPAddress result) => (result = converter.IpAddress(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="DirectoryInfo"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static DirectoryInfo Directory(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      DirectoryInfo directory => directory,
      _ => instance.ToInvariantString().ToDirectory(out var result) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="DirectoryInfo"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Directory(this IConverter converter, object instance, out DirectoryInfo result) => (result = converter.Directory(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="FileInfo"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static FileInfo File(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      FileInfo file => file,
      _ => instance.ToInvariantString().ToFile(out var result) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="FileInfo"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool File(this IConverter converter, object instance, out FileInfo result) => (result = converter.File(instance)) is not null;

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Type"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static Type Type(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      Type type => type,
      _ => instance.ToInvariantString().ToType(out var result) ? result : null
    };
  }

  /// <summary>
  ///   <para>Performs conversion of the given <see cref="object"/> to the instance of <see cref="System.Type"/> type.</para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Type(this IConverter converter, object instance, out Type result) => (result = converter.Type(instance)) is not null;

  /// <summary>
  ///   <para>Converts target object to the <see cref="bool"/> value, using non-strict approach.</para>
  ///   <para>The following algorithm is used to determine how to perform such conversion:
  ///     <list type="bullet">
  ///       <item><description>If <paramref name="instance"/> is a <c>null</c> reference, the result is <c>false</c>.</description></item>
  ///       <item><description>If <paramref name="instance"/> is a <see cref="bool"/> value, it's returned as it is.</description></item>
  ///       <item><description>If <paramref name="instance"/> is a positive numeric value, the result is <c>true</c>, if it's negative or zero - the result is <c>false</c>.</description></item>
  ///       <item><description>If <paramref name="instance"/> is a <see cref="string"/>, <c>true</c> is returned if it contains at least one character, <c>false</c> otherwise.</description></item>
  ///       <item><description>If <paramref name="instance"/> implements <see cref="IEnumerable"/>, <c>true</c> is returned if it contains at least one element, <c>false</c> otherwise.</description></item>
  ///       <item><description>If <paramref name="instance"/> is a <see cref="Stream"/> value, <c>true</c> is returned if it's not empty, <c>false</c> otherwise.</description></item>
  ///       <item><description>If <paramref name="instance"/> is a <see cref="Match"/> value, <c>true</c> is returned if it's successful, <c>false</c> otherwise.</description></item>
  ///     </list>
  ///   </para>
  /// </summary>
  /// <param name="converter">Extended converter instance.</param>
  /// <param name="instance">Target object for conversion.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool Boolean(this IConverter converter, object instance)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => false,
      bool value => value,
      char value => value != char.MinValue,
      sbyte value => value > 0,
      byte value => value > 0,
      short value => value > 0,
      ushort value => value > 0,
      int value => value > 0,
      uint value => value > 0,
      long value => value > 0,
      ulong value => value > 0,
      float value => value > 0,
      double value => value > 0,
      decimal value => value > 0,
      string value => value.Trim().Length > 0,
      IEnumerable value => value.Cast<object>().Any(),
      FileInfo value => value.Exists,
      DirectoryInfo value => value.Exists,
      Stream value => value is { CanSeek: true, Length: > 0 },
      BinaryReader value => value.PeekChar() >= 0,
      TextReader value => value.Peek() >= 0,
      Match value => value.Success,
      StringBuilder value => value.Length > 0,
      SecureString value => value.Length > 0,
      _ => true
    };
  }

#if NET8_0_OR_GREATER
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static DateOnly? DateOnly(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      DateTime dateTime => dateTime.ToDateOnly(),
      DateTimeOffset dateTimeOffset => dateTimeOffset.ToDateOnly(),
      DateOnly dateOnly => dateOnly,
      _ => instance.ToFormattedString(format).ToDateOnly(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool DateOnly(this IConverter converter, object instance, out DateOnly? result, IFormatProvider format = null) => (result = converter.DateOnly(instance, format)) is not null;

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static TimeOnly? TimeOnly(this IConverter converter, object instance, IFormatProvider format = null)
  {
    if (converter is null) throw new ArgumentNullException(nameof(converter));

    return instance switch
    {
      null => null,
      DateTime dateTime => dateTime.ToTimeOnly(),
      DateTimeOffset dateTimeOffset => dateTimeOffset.ToTimeOnly(),
      TimeOnly timeOnly => timeOnly,
      _ => instance.ToFormattedString(format).ToTimeOnly(out var result, format) ? result : null
    };
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="converter">Converter to use.</param>
  /// <param name="instance">Source object to convert from.</param>
  /// <returns>Conversion result object or a <c>null</c> reference in case of a failed conversion.</returns>
  /// <param name="result">Conversion result object or a <c>null</c> reference in case of a failed conversion.</param>
  /// <param name="format">Text formatting controller.</param>
  /// <returns><see langword="true"/> if conversion was performed successfully, <see langword="false"/> otherwise.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="converter"/> is a <see langword="null"/> reference.</exception>
  public static bool TimeOnly(this IConverter converter, object instance, out TimeOnly? result, IFormatProvider format = null) => (result = converter.TimeOnly(instance, format)) is not null;
#endif
}