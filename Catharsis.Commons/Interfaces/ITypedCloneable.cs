namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
/// <typeparam name="T"></typeparam>
public interface ITypedCloneable<out T>
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <returns></returns>
  T Clone();
}