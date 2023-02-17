namespace Catharsis.Conversions;

/// <summary>
///   <para>Set of converters for <see cref="Guid"/> type.</para>
/// </summary>
/// <seealso cref="Guid"/>
public static class GuidConverters
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="conversion"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static byte[] Bytes(this IConversion<Guid> conversion) => conversion.To(guid => guid.ToByteArray());
}