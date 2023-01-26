using Catharsis.Conversions;
using Catharsis.Extensions;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="TSource"></typeparam>
public class Conversion<TSource> : IConversion<TSource>
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  protected readonly Dictionary<string, object> parameters = new();

  /// <summary>
  ///   <para></para>
  /// </summary>
  public TSource Source { get; }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="source"></param>
  public Conversion(TSource source) => Source = source ?? throw new ArgumentNullException(nameof(source));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  /// <exception cref="ArgumentException"></exception>
  public IConversion<TSource> Parameter(string name, object value)
  {
    if (name is null) throw new ArgumentNullException(nameof(name));
    if (name.IsEmpty()) throw new ArgumentException(nameof(name));

    parameters[name] = value;
    
    return this;
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  public IReadOnlyDictionary<string, object> Parameters => parameters;

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="converter"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public TResult To<TResult>(Func<TSource, TResult> converter) => converter is not null ? converter(Source) : throw new ArgumentNullException(nameof(converter));
}