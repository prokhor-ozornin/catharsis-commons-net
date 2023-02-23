namespace Catharsis.Conversions;

/// <summary>
///   <para>Converter factory.</para>
/// </summary>
public static class Convert
{
  /// <summary>
  ///   <para>Converter instance.</para>
  /// </summary>
  public static IConverter To { get; } = new Converter();
}