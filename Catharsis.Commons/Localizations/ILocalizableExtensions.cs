using System.Globalization;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class ILocalizableExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TLocalization"></typeparam>
  /// <typeparam name="TLocalizations"></typeparam>
  /// <param name="localizable"></param>
  /// <param name="culture"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static TLocalization Localization<TLocalization, TLocalizations>(this ILocalizable<TLocalization, TLocalizations> localizable, CultureInfo culture = null) where TLocalization : ILocalization where TLocalizations : ILocalizations<TLocalization> => localizable is not null ? localizable.Localizations.TryGetValue((culture ?? CultureInfo.CurrentCulture).TwoLetterISOLanguageName, out var localization) ? localization : default : throw new ArgumentNullException(nameof(localizable));
}