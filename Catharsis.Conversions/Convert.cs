namespace Catharsis.Conversions;

/// <summary>
///   <para>Converter between various source and destination types of objects.</para>
/// </summary>
public static class Convert
{
  /// <summary>
  ///   <para>Current converter instance.</para>
  /// </summary>
  public static IConverter To { get; } = new Converter();
}