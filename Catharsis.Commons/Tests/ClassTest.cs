using Catharsis.Extensions;
using FluentAssertions;

namespace Catharsis.Commons;

public class ClassTest<T> : UnitTest
{
  protected void TestCompareTo<TProperty>(string property, TProperty lower, TProperty greater, Func<T> constructor = null)
  {
    constructor ??= () => typeof(T).Instance<T>();

    var first = constructor().To<IComparable<T>>();
    var second = constructor().To<T>();

    first.SetPropertyValue(property, lower);
    second.SetPropertyValue(property, lower);

    first.CompareTo(second).Should().Be(0);
    second.SetPropertyValue(property, greater);
    first.CompareTo(second).Should().BeLessThan(0);
  }

  protected void TestEquality<TProperty>(string property, TProperty oldValue, TProperty newValue, Func<T> constructor = null)
  {
    constructor ??= () => typeof(T).Instance<T>();
    var entity = constructor();

    entity.Equals(new object()).Should().BeFalse();
    entity.Equals(null).Should().BeFalse();
    entity.Equals(entity).Should().BeTrue();
    //entity.Equals(constructor()).Should().BeTrue();

    constructor().SetPropertyValue(property, oldValue).Equals(constructor().SetPropertyValue(property, oldValue)).Should().BeTrue();
    constructor().SetPropertyValue(property, oldValue).Equals(constructor().SetPropertyValue(property, newValue)).Should().BeFalse();
  }

  protected void TestHashCode<TProperty>(string property, TProperty oldValue, TProperty newValue, Func<T> constructor = null)
  {
    constructor ??= () => typeof(T).Instance<T>();
    var entity = constructor();

    entity.GetHashCode().Should().Be(entity.GetHashCode());
    //entity.GetHashCode().Should().Be(constructor().GetHashCode());

    constructor().SetPropertyValue(property, oldValue).GetHashCode().Should().Be(constructor().SetPropertyValue(property, oldValue).GetHashCode());
    constructor().SetPropertyValue(property, oldValue).GetHashCode().Should().NotBe(constructor().SetPropertyValue(property, newValue).GetHashCode());
  }
}