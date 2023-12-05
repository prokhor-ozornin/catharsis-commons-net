namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ITimeAware
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  DateTimeOffset CreatedOn { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  DateTimeOffset UpdatedOn { get; set; }
}