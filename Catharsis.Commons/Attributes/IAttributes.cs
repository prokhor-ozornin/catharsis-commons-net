namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface IAttributes : IDictionary<string, object>
{
}

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IAttributes<T> : IDictionary<string, T>
{
}