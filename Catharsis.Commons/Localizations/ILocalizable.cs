namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="TLocalization"></typeparam>
/// <typeparam name="TLocalizations"></typeparam>
public interface ILocalizable<TLocalization, out TLocalizations> where TLocalization : ILocalization where TLocalizations : ILocalizations<TLocalization>
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  TLocalizations Localizations { get; }
}