namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ITableCell<T> : IDescriptable, ITypedCloneable<ITableCell<T>>, IComparable<ITableCell<T>>, IEquatable<ITableCell<T>>
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  T Value { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  object Metadata { get; set; }
}