using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para>Набор расширений для «Таблицы».</para>
/// </summary>
/// <seealso cref="ITable{T}"/>
public static class ITableExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="table"></param>
  /// <param name="row"></param>
  /// <param name="column"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If <paramref name="table"/> is a <see langword="null"/> reference.</exception>
  public static ITableCell<T> Cell<T>(this ITable<T> table, int row, int column)
  {
    if (table is null) throw new ArgumentNullException(nameof(table));
    if (row < 0) throw new ArgumentOutOfRangeException(nameof(row));
    if (column < 0 || column > table.Columns.Count - 1) throw new ArgumentOutOfRangeException(nameof(column));

    return table.Rows[row][column];
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="table"></param>
  /// <param name="cells"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException">If either <paramref name="table"/> or <param name="cells"/> is a <see langword="null"/> reference.</exception>
  public static ITable<T> Row<T>(this ITable<T> table, IEnumerable<T> cells)
  {
    if (table is null) throw new ArgumentNullException(nameof(table));
    if (cells is null) throw new ArgumentNullException(nameof(cells));

    table.Rows.With(new TableRow<T>(cells));

    return table;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="table"></param>
  /// <param name="values"></param>
  /// <exception cref="ArgumentNullException">If either <paramref name="table"/> or <param name="values"/> is a <see langword="null"/> reference.</exception>
  public static ITable<T> Row<T>(this ITable<T> table, params T[] values) => table.Row(values as IEnumerable<T>);
}