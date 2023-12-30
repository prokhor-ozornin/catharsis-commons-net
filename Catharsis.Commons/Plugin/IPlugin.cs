namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface IPlugin
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  int Order { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  void Load();

  /// <summary>
  ///   <para></para>
  /// </summary>
  void Unload();
}