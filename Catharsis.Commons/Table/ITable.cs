namespace Catharsis.Commons;

/// <summary>
///   <para>Таблица.</para>
/// </summary>
public interface ITable<T> : INameable, IDescriptable, ITypedCloneable<ITable<T>>
{
  /// <summary>
  ///   <para>Верхний колонтитул.</para>
  /// </summary>
  string Header { get; set; }

  /// <summary>
  ///   <para>Нижний колонтитул.</para>
  /// </summary>
  string Footer { get; set; }

  /// <summary>
  ///   <para>Столбцы.</para>
  /// </summary>
  IList<string> Columns { get; }

  /// <summary>
  ///   <para>Ряды</para>
  /// </summary>
  IList<ITableRow<T>> Rows { get; }
}