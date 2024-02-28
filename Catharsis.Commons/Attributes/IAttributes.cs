namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IAttributes<T> : IDictionary<string, T>
{
}

/// <summary>
///   <para></para>
/// </summary>
public interface IAttributes : IAttributes<object>
{
}