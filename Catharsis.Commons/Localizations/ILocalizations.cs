namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public interface ILocalizations<T> : IDictionary<string, T> where T : ILocalization
{
}