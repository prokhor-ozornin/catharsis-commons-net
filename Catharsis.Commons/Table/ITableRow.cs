namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ITableRow<T> : IList<ITableCell<T>>, IDescriptable, ITypedCloneable<ITableRow<T>>
{
}