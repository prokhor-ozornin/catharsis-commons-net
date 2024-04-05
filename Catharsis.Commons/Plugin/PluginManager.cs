using Catharsis.Extensions;

namespace Catharsis.Commons;

public class PluginManager : IPluginManager
{
  private readonly IList<IPlugin> available = new List<IPlugin>();
  private readonly IList<IPlugin> loaded = new List<IPlugin>();

  public PluginManager() => available.With(typeof(IPlugin).Implementors().Where(plugin => plugin.IsClass && plugin.HasConstructor()).Select(plugin => plugin.Instance<IPlugin>()).OrderBy(plugin => plugin.Order));

  public IEnumerable<IPlugin> Loaded => loaded;

  public IEnumerable<IPlugin> Available => available;

  public IPluginManager Load(IPlugin plugin)
  {
    if (plugin is null) throw new ArgumentNullException(nameof(plugin));

    plugin.Load();
    
    loaded.Add(plugin);

    return this;
  }

  public IPluginManager Unload(IPlugin plugin)
  {
    if (plugin is null) throw new ArgumentNullException(nameof(plugin));

    plugin.Unload();

    loaded.Remove(plugin);

    return this;
  }
}