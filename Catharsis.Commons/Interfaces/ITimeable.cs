namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ITimeable : ITimed
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  new DateTimeOffset CreatedOn { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  new DateTimeOffset UpdatedOn { get; set; }
}