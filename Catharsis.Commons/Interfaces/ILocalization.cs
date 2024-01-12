namespace Catharsis.Commons;

/// <summary>
///   <para>Localization.</para>
/// </summary>
public interface ILocalization : IValidateable
{
  /// <summary>
  ///   <para>Language code.</para>
  /// </summary>
  string Language { get; set; }
}