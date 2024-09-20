using System.Runtime.Serialization;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <inheritdoc cref="ITable{T}"/>
[DataContract(Name = nameof(Table<T>))]
public class Table<T> : ITable<T>
{
  /// <inheritdoc cref="ITable{T}.Name"/>
  [DataMember(Name = nameof(Name))]
  public virtual string Name { get; set; }

  /// <inheritdoc cref="ITable{T}.Description"/>
  [DataMember(Name = nameof(Description))]
  public virtual string Description { get; set; }

  /// <inheritdoc cref="ITable{T}.Header"/>
  [DataMember(Name = nameof(Header))]
  public virtual string Header { get; set; }

  /// <inheritdoc cref="ITable{T}.Footer"/>
  [DataMember(Name = nameof(Footer))]
  public virtual string Footer { get; set; }

  /// <inheritdoc cref="ITable{T}.Columns"/>
  [DataMember(Name = nameof(Columns))]
  public virtual IList<string> Columns { get; init; } = [];

  /// <inheritdoc cref="ITable{T}.Rows"/>
  [DataMember(Name = nameof(Rows))]
  public virtual IList<ITableRow<T>> Rows { get; init; } = [];

  /// <summary>
  ///   <para></para>
  /// </summary>
  public Table()
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="rows"></param>
  public Table(IEnumerable<ITableRow<T>> rows) => Rows.With(rows);

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public virtual ITable<T> Clone() => new Table<T>
  {
    Name = Name,
    Description = Description,
    Header = Header,
    Footer = Footer,
    Columns = Columns?.ToList(),
    Rows = Rows?.Select(row => row.Clone()).ToList()
  };

  /// <summary>
  ///   <para>Возврат текстового представления текущего объекта.</para>
  /// </summary>
  /// <returns>Текстовое представление объекта.</returns>
  public override string ToString() => Name ?? string.Empty;
}