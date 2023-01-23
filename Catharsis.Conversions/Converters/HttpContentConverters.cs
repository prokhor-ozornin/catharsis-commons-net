﻿using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
public static class HttpContentConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IEnumerable<byte> Bytes(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToBytes());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static IAsyncEnumerable<byte> BytesAsync(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToBytesAsync());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static string Text(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToText());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<string> TextAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default) => conversion.To(content => content.ToTextAsync(cancellation));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  public static Stream Stream(this IConversion<HttpContent> conversion) => conversion.To(content => content.ToStream());

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <param name="cancellation"></param>
  /// <returns></returns>
  public static Task<Stream> StreamAsync(this IConversion<HttpContent> conversion, CancellationToken cancellation = default) => conversion.To(content => content.ToStreamAsync(cancellation));
}