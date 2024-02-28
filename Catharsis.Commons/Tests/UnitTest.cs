using Catharsis.Extensions;
using Newtonsoft.Json;

namespace Catharsis.Commons;

public class UnitTest : ITestable, IDisposable
{
  public UnitTest() => JsonConvert.DefaultSettings = () => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

  public ITestAttributes Attributes { get; } = new TestAttributes();

  public virtual void Dispose()
  {
    Attributes.ForEach(attribute =>
    {
      if (attribute.Value is IDisposable)
      {
        attribute.Value.To<IDisposable>().Dispose();
      }
    });

    Attributes.Dispose();
  }

  private sealed class TestAttributes : Attributes, ITestAttributes
  {
  }
}