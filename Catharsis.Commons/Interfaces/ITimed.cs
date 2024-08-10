namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ITimed
{
  /// <summary>
  ///   <para>Дата/время создания.</para>
  /// </summary>
  DateTimeOffset CreatedOn { get; }

  /// <summary>
  ///   <para>Дата/время последнего изменения.</para>
  /// </summary>
  DateTimeOffset UpdatedOn { get; }
}