namespace Catharsis.Commons;

/// <summary>
///   <para>Descriptable object.</para>
/// </summary>
public interface IDescriptable : IDescripted
{
  /// <summary>
  ///   <para>Description.</para>
  /// </summary>
  new string Description {  get; set; }
}