namespace Catharsis.Commons;

/// <summary>
///   <para>Nameable object.</para>
/// </summary>
public interface INameable : INamed
{
  /// <summary>
  ///   <para>Name.</para>
  /// </summary>
  new string Name { get; set; }
}