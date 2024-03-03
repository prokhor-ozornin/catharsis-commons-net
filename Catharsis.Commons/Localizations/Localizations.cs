using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public class Localizations<T> : Dictionary<string, T>, ILocalizations<T> where T : ILocalization
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  public Localizations()
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <exception cref="ArgumentNullException"></exception>
  public Localizations(IEnumerable<(string Language, T Localization)> attributes)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    foreach (var (Language, Localization) in attributes)
    {
      Add(Language, Localization);
    }
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="localizations"></param>
  /// <exception cref="ArgumentNullException"></exception>
  public Localizations(IEnumerable<KeyValuePair<string, T>> localizations)
  {
    if (localizations is null) throw new ArgumentNullException(nameof(localizations));

    this.AddRange(localizations);
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  public Localizations(params (string Language, T Localization)[] attributes) : this(attributes as IEnumerable<(string, T)>)
  {
  }
}