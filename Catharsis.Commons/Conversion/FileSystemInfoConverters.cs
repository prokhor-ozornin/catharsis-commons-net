﻿using Catharsis.Extensions;

namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="FileSystemInfo"/> type.</para>
/// </summary>
/// <seealso cref="FileSystemInfo"/>
public static class FileSystemInfoConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="FileSystemInfo"/> instance to the instance of <see cref="System.Uri"/> type.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  /// <seealso cref="FileSystemInfoExtensions.ToUri(FileSystemInfo)"/>
  public static Uri Uri(this IConversion<FileSystemInfo> conversion, string error = null) => conversion.To(info => info.ToUri(), error);
}