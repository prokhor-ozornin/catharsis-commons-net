namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IAttributes<T> : IEnumerable<KeyValuePair<string, T>>, IDisposable
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="key"></param>
  /// <returns></returns>
  T this[string key] { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="key"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  bool Get(string key, out T value);
}

/// <summary>
///   <para></para>
/// </summary>
public interface IAttributes : IAttributes<object>
{
}