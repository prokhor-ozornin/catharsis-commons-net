namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ITimed
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  DateTimeOffset CreatedOn { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  DateTimeOffset UpdatedOn { get; }
}