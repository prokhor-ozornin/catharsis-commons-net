using Newtonsoft.Json;

namespace Catharsis.Commons;

public abstract class AbstractTest : IDisposable
{
  protected AbstractTest() => JsonConvert.DefaultSettings = () => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

  protected CancellationToken Cancellation { get; } = new(true);

  protected Random Randomizer { get; } = new();

  protected Guid Guid { get; } = Guid.NewGuid();

  public virtual void Dispose()
  {
  }
}