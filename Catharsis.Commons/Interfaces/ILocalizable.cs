namespace Catharsis.Commons;

/// <summary>
///   <para>Localized object.</para>
/// </summary>
/// <typeparam name="T">Type of localization.</typeparam>
public interface ILocalizable<T> where T : ILocalization
{
  /// <summary>
  ///   <para>Localizations.</para>
  /// </summary>
  IDictionary<string, T> Localizations { get; }
}