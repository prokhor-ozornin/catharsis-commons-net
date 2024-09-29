using Catharsis.Extensions;

namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public class LogicalCollection<T> : List<(LogicalOperation Operation, T Item)>, ILogicalCollection<T>
{
  /// <inheritdoc cref="ILogical.ToBoolean()"/>
  public virtual bool ToBoolean()
  {
    var result = true;

    foreach (var element in this)
    {
      var boolean = element.Item switch
      {
        null => false,
        ILogical logical => logical.ToBoolean(),
        _ => true
      };

      switch (element.Operation)
      {
        case LogicalOperation.And:
          result = result && boolean;
          break;

        case LogicalOperation.Or:
          result = result || boolean;
          break;

        case LogicalOperation.Not:
          result = result && !boolean;
          break;
      }
    }

    return result;
  }

  /// <inheritdoc cref="object.ToString()"/>
  public override string ToString() => this.Select(element => $"{element.Operation.ToString().ToUpperInvariant()} \"${element.Item}\"").Join(" ").Trim();
}