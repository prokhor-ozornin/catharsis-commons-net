namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Guid"/> type.</para>
/// </summary>
/// <seealso cref="Guid"/>
public static class GuidConverters
{
  /// <summary>
  ///   <para>Converts given <see cref="Guid"/> instance to the <see cref="byte"/> array.</para>
  /// </summary>
  /// <param name="conversion">Conversion to perform.</param>
  /// <param name="error">Error description phrase for a failed <paramref name="conversion"/>.</param>
  /// <returns>Conversion result.</returns>
  /// <exception cref="ArgumentNullException">If <paramref name="conversion"/> is a <see langword="null"/> reference.</exception>
  /// <exception cref="InvalidOperationException">In case of a failed conversion.</exception>
  public static byte[] Bytes(this IConversion<Guid> conversion, string error = null) => conversion.To(guid => guid.ToByteArray(), error);
}