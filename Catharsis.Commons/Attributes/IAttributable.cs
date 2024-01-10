namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="TAttributes"></typeparam>
public interface IAttributable<out TAttributes> where TAttributes : IAttributes
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  TAttributes Attributes { get; }
}