namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ILogicalCollection<T> : ILogical, IList<(LogicalOperation Operation, T Item)>
{
}