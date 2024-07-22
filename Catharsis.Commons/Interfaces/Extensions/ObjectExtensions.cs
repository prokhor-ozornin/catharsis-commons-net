using Newtonsoft.Json;

namespace Catharsis.Commons;

/// <summary>
///   <para>A set of extension methods for the <see cref="object"/> type.</para>
/// </summary>
public static partial class ObjectExtensions
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <param name="subject"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static string SerializeAsJson(this object subject)
  {
    if (subject is null) throw new ArgumentNullException(nameof(subject));

    return JsonConvert.SerializeObject(subject, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore });
  }

  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  /// <exception cref="ArgumentNullException"></exception>
  public static T DeserializeAsJson<T>(this string value)
  {
    if (value is null) throw new ArgumentNullException(nameof(value));

    return JsonConvert.DeserializeObject<T>(value);
  }
}