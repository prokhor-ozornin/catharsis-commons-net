namespace Catharsis.Conversions;

/// <summary>
///   <para></para>
/// </summary>
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