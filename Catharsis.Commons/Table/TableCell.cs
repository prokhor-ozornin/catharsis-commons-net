using System.Runtime.Serialization;
using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <inheritdoc cref="ITableCell{T}"/>
[DataContract(Name = nameof(TableCell<T>))]
public class TableCell<T> : ITableCell<T>
{
  /// <inheritdoc cref="IDescriptable.Description"/>
  public virtual string Description { get; set; }

  /// <inheritdoc cref="ITableCell{T}.Value"/>
  public virtual T Value { get; set; }

  /// <inheritdoc cref="ITableCell{T}.Metadata"/>
  public virtual object Metadata { get; set; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  public TableCell()
  {
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="value"></param>
  public TableCell(T value) => Value = value;

  /// <inheritdoc cref="ICloneable.Clone()"/>
  public virtual ITableCell<T> Clone() => new TableCell<T>
  {
    Value = Value,
    Metadata = Metadata
  };

  /// <summary>
  ///   <para>Логическое сравнение текущего объекта и заданного между собой.</para>
  /// </summary>
  /// <param name="other">Объект для сравнения с текущим.</param>
  /// <returns>
  ///   <list type="bullet">
  ///     <item><description>-1 в случае, если текущий объект «меньше» заданного.</description></item>
  ///     <item><description>0 в случае, если текущий объект «равен» заданному.</description></item>
  ///     <item><description>1 в случае, если текущий объект «больше» заданного.</description></item>
  ///   </list>
  /// </returns>
  public virtual int CompareTo(ITableCell<T> other) => /*Nullable.Compare(Value, other?.Value);*/ 0;

  /// <summary>
  ///   <para>Проверка на логическое равенство между текущим объектом и заданным.</para>
  /// </summary>
  /// <param name="other">Объект для сравнения с текущим.</param>
  /// <returns>Возвращает <see langword="true"/> в случае логического равенства текущего объекта и параметра <paramref name="other"/>, и <see langword="false"/> в противном случае.</returns>
  public virtual bool Equals(ITableCell<T> other) => this.Equality(other, nameof(Value));

  /// <summary>
  ///   <para>Проверка на логическое равенство между текущим объектом и заданным.</para>
  /// </summary>
  /// <param name="other">Объект для сравнения с текущим.</param>
  /// <returns>Возвращает <see langword="true"/> в случае логического равенства текущего объекта и параметра <paramref name="other"/>, и <see langword="false"/> в противном случае.</returns>
  public override bool Equals(object other) => Equals(other as ITableCell<T>);

  /// <summary>
  ///   <para>Возврат значения выполнения функции хэширования для текущего объекта.</para>
  /// </summary>
  /// <returns>Хэш-код объекта.</returns>
  public override int GetHashCode() => this.HashCode(nameof(Value));

  /// <summary>
  ///   <para>Возврат текстового представления текущего объекта.</para>
  /// </summary>
  /// <returns>Текстовое представление объекта.</returns>
  public override string ToString() => Value?.ToString() ?? string.Empty;
}