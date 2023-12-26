using Newtonsoft.Json;

namespace Catharsis.Commons;

public abstract class AbstractTest : ITestable, IDisposable
{
  public ITestAttributes Attributes { get; } = new TestAttributes();

  protected AbstractTest() => JsonConvert.DefaultSettings = () => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

  protected CancellationToken Cancellation { get; } = new(true);

  protected Random Randomizer { get; } = new();

  protected Guid Guid { get; } = Guid.NewGuid();

  public virtual void Dispose() => Attributes.Clear();

  private sealed class TestAttributes : Attributes, ITestAttributes
  {
  }
}