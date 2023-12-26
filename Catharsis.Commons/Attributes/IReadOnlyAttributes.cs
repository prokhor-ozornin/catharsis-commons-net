namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface IReadOnlyAttributes : IReadOnlyDictionary<string, object>
{
}

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IReadOnlyAttributes<T> : IReadOnlyDictionary<string, T>
{
}