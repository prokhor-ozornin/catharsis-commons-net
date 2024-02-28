using System.Collections;
using Catharsis.Extensions;

namespace Catharsis.Commons;

public class Attributes<T> : IAttributes<T>
{
  protected IDictionary<string, T> Items { get; } = new Dictionary<string, T>();

  public Attributes()
  {
  }

  public Attributes(object attributes) : this(attributes.GetState().Select(it => (it.Name, (T) it.Value)))
  {
  }

  public Attributes(IEnumerable<(string Name, T Value)> attributes)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    foreach (var (Name, Value) in attributes)
    {
      Items.Add(Name, Value);
    }
  }

  public Attributes(IEnumerable<KeyValuePair<string, T>> attributes)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    Items.AddRange(attributes);
  }

  public bool Get(string key, out T value) => Items.TryGetValue(key, out value);

  public T this[string key]
  {
    get => Items[key];
    set => Items[key] = value;
  }

  public void Dispose() => Items.Clear();

  public IEnumerator<KeyValuePair<string, T>> GetEnumerator() => Items.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Attributes : Attributes<object>
{
  private readonly IDictionary<string, object> items = new Dictionary<string, object>();

  public Attributes()
  {
  }

  public Attributes(object attributes) : base(attributes.GetState())
  {
  }

  public Attributes(IEnumerable<(string Name, object Value)> attributes) : base(attributes)
  {
  }

  public Attributes(IEnumerable<KeyValuePair<string, object>> attributes) : base(attributes)
  {
  }
}