namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface IValidateable
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  Func<bool> Validator { get; }
}