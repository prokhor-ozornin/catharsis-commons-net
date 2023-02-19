﻿using System.Net.Sockets;
using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="TcpClient"/> type.</para>
/// </summary>
/// <seealso cref="TcpClient"/>
public static class TcpClientConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="BytesAsync(IConversion{TcpClient}, string)"/>
  public static IEnumerable<byte> Bytes(this IConversion<TcpClient> conversion, string error = null) => conversion.To(tcp => tcp.ToBytes(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Bytes(IConversion{TcpClient}, string)"/>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<TcpClient> conversion, string error = null) => conversion.To(tcp => tcp.ToBytesAsync(), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{TcpClient}, int, bool, string)"/>
  public static IEnumerable<byte> Enumerable(this IConversion<TcpClient> conversion, bool close = false, string error = null) => conversion.To(tcp => tcp.ToEnumerable(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="Enumerable(IConversion{TcpClient}, bool, string)"/>
  public static IEnumerable<byte[]> Enumerable(this IConversion<TcpClient> conversion, int count, bool close = false, string error = null) => conversion.To(tcp => tcp.ToEnumerable(count, close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TcpClient}, int, bool, string)"/>
  public static IAsyncEnumerable<byte> AsyncEnumerable(this IConversion<TcpClient> conversion, bool close = false, string error = null) => conversion.To(tcp => tcp.ToAsyncEnumerable(close), error);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="count"></param>
  /// <param name="close"></param>
  /// <param name="error"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <seealso cref="AsyncEnumerable(IConversion{TcpClient}, bool, string)"/>
  public static IAsyncEnumerable<byte[]> AsyncEnumerable(this IConversion<TcpClient> conversion, int count, bool close = false, string error = null) => conversion.To(tcp => tcp.ToAsyncEnumerable(count, close), error);
}