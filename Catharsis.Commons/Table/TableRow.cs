using System.Runtime.Serialization;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <inheritdoc cref="ITableRow{T}"/>
[DataContract(Name = nameof(TableRow<T>))]
public class TableRow<T> : List<ITableCell<T>>, ITableRow<T>
{
  /// <inheritdoc cref="IDescriptable.Description"/>
  public virtual string Description { get; set; }

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public virtual ITableRow<T> Clone() => new TableRow<T>().With(row => row.With(this.Select(cell => cell.Clone())));

  /// <summary>
  ///   <para></para>
  /// </summary>
  public TableRow()
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="cells"></param>
  public TableRow(IEnumerable<ITableCell<T>> cells) => this.With(cells);

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="cells"></param>
  public TableRow(IEnumerable<T> cells) => this.With(cells.Select(cell => new TableCell<T> { Value = cell }));

  /// <summary>
  ///   <para>Возврат текстового представления текущего объекта.</para>
  /// </summary>
  /// <returns>Текстовое представление объекта.</returns>
  public override string ToString() => $"[{this.Join(",")}]";
}