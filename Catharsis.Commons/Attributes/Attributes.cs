using Catharsis.Extensions;

namespace Catharsis.Commons;

public class Attributes : Dictionary<string, object>, IAttributes, IReadOnlyAttributes
{
  public Attributes()
  {
  }

  public Attributes(object attributes) : this(attributes.GetState())
  {
  }

  public Attributes(IEnumerable<(string Name, object Value)> attributes)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    foreach (var (Name, Value) in attributes)
    {
      Add(Name, Value);
    }
  }

  public Attributes(IEnumerable<KeyValuePair<string, object>> attributes)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    this.AddRange(attributes);
  }
}

public class Attributes<T> : Dictionary<string, T>, IAttributes<T>, IReadOnlyAttributes<T>
{
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
      Add(Name, Value);
    }
  }

  public Attributes(IEnumerable<KeyValuePair<string, T>> attributes)
  {
    if (attributes is null) throw new ArgumentNullException(nameof(attributes));

    this.AddRange(attributes);
  }
}