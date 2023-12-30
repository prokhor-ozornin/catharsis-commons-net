using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class IPluginManagerExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="InvalidOperationException"></exception>
  public static IPlugin Locate(this IPluginManager manager, Type type)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (!type.Implements<IPlugin>()) throw new InvalidOperationException(nameof(type));

    return manager.Loaded.SingleOrDefault(plugin => plugin.GetType() == type);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="manager"></param>
  /// <returns></returns>
  public static IPlugin Locate<T>(this IPluginManager manager) where T : IPlugin
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));

    return manager.Locate(typeof(T));
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IPluginManager Load(this IPluginManager manager, Type type)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (!type.Implements<IPlugin>()) throw new InvalidOperationException(nameof(type));

    if (!manager.IsLoaded(type))
    {
      manager.Load(type.Instance<IPlugin>());
    }

    return manager;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="manager"></param>
  /// <returns></returns>
  public static IPluginManager Load<T>(this IPluginManager manager) where T : IPlugin
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));

    return manager.Load(typeof(T));
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static IPluginManager Unload(this IPluginManager manager, Type type)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (!type.Implements<IPlugin>()) throw new InvalidOperationException(nameof(type));

    var plugin = manager.Locate(type);
    
    if (plugin is not null)
    {
      manager.Unload(plugin);
    }

    return manager;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="manager"></param>
  /// <returns></returns>
  public static IPluginManager Unload<T>(this IPluginManager manager) where T : IPlugin
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));

    return manager.Unload(typeof(T));
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="plugin"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static bool IsLoaded(this IPluginManager manager, IPlugin plugin)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (plugin is null) throw new ArgumentNullException(nameof(plugin));

    return manager.Loaded.Contains(plugin);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static bool IsLoaded(this IPluginManager manager, Type type)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (!type.Implements<IPlugin>()) throw new InvalidOperationException(nameof(type));

    return manager.Locate(type) is not null;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="manager"></param>
  /// <returns></returns>
  public static bool IsLoaded<T>(this IPluginManager manager) where T : IPlugin
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));

    return manager.IsLoaded(typeof(T));
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="plugin"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static bool IsAvailable(this IPluginManager manager, IPlugin plugin)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (plugin is null) throw new ArgumentNullException(nameof(plugin));

    return manager.Available.Contains(plugin);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="manager"></param>
  /// <param name="type"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static bool IsAvailable(this IPluginManager manager, Type type)
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));
    if (type is null) throw new ArgumentNullException(nameof(type));
    if (!type.Implements<IPlugin>()) throw new InvalidOperationException(nameof(type));

    return manager.Available.Any(plugin => plugin.GetType() == type);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="manager"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static bool IsAvailable<T>(this IPluginManager manager) where T : IPlugin
  {
    if (manager is null) throw new ArgumentNullException(nameof(manager));

    return manager.IsAvailable(typeof(T));
  }
}