﻿namespace Catharsis.Commons;

/// <summary>
///   <para>A set of extensions methods for the <see cref="object"/> type.</para>
/// </summary>
public static partial class ObjectExtensions
{
  /// <summary>
  ///   <para>Creates a new conversion for a given source object.</para>
  /// </summary>
  /// <param name="source">Source object to be converted.</param>
  /// <typeparam name="T">Type of source object.</typeparam>
  /// <returns>Initialized conversion instance.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="source"/> is a <see langword="null"/> reference.</exception>
  public static IConversion<T> Convert<T>(this T source) => source is not null ? new Conversion<T>(source) : throw new ArgumentNullException(nameof(source));
}