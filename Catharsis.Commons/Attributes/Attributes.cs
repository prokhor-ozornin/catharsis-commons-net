using Catharsis.Extensions;

namespace Catharsis.Commons;

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

  public Attributes(params (string Name, T Value)[] attributes) : this(attributes as IEnumerable<(string, T)>)
  {
  }
}

public class Attributes : Attributes<object>
{
  public Attributes()
  {
  }

  public Attributes(object attributes) : base(attributes)
  {
  }

  public Attributes(IEnumerable<(string Name, object Value)> attributes) : base(attributes)
  {
  }

  public Attributes(IEnumerable<KeyValuePair<string, object>> attributes) : base(attributes)
  {
  }

  public Attributes(params (string Name, object Value)[] attributes) : base(attributes)
  {
  }
}