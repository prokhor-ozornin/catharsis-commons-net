namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface IPluginManager
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  IEnumerable<IPlugin> Loaded { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  IEnumerable<IPlugin> Available { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="plugin"></param>
  /// <returns></returns>
  IPluginManager Load(IPlugin plugin);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="plugin"></param>
  /// <returns></returns>
  IPluginManager Unload(IPlugin plugin);
}