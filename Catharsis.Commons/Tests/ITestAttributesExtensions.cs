namespace Catharsis.Commons;

/// <summary>
///   <para></para>
/// </summary>
public static class ITestAttributesExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Guid Guid(this ITestAttributes attributes) => attributes?.Retrieve(nameof(Guid), System.Guid.NewGuid()) ?? throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static CancellationToken CancellationToken(this ITestAttributes attributes) => attributes?.Retrieve(nameof(CancellationToken), new CancellationToken(true)) ?? throw new ArgumentNullException(nameof(attributes));

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="attributes"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static Random Random(this ITestAttributes attributes) => attributes is not null ? attributes.Retrieve(nameof(Random), new Random()) : throw new ArgumentNullException(nameof(attributes));
}