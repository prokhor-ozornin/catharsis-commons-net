using Catharsis.Extensions;
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
  /// <typeparam name="T"></typeparam>
  /// <param name="localizable"></param>
  /// <param name="culture"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static T Localization<T>(this ILocalizable<T> localizable, CultureInfo culture = null) where T : ILocalization => localizable is not null ? localizable.Localizations[(culture ?? CultureInfo.CurrentCulture).TwoLetterISOLanguageName] : throw new ArgumentNullException(nameof(localizable));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="TLocalization"></typeparam>
  /// <typeparam name="TProperty"></typeparam>
  /// <param name="localizable"></param>
  /// <param name="property"></param>
  /// <param name="culture"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static TProperty LocalizedProperty<TLocalization, TProperty>(this ILocalizable<TLocalization> localizable, string property, CultureInfo culture = null) where TLocalization : ILocalization
  {
    if (localizable is null) throw new ArgumentNullException(nameof(localizable));

    var localization = localizable.Localization(culture);

    return localization is not null ? localization.GetPropertyValue<TProperty>(property) : localizable.GetPropertyValue<TProperty>(property);
  }
}