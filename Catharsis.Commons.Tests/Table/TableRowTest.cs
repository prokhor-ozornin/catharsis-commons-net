using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TableRow{T}"/>.</para>
/// </summary>
public sealed class TableRowTest : ClassTest<TableRow<object>>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TableRow{T}()"/>
  /// <seealso cref="TableRow{T}(IEnumerable{ITableCell{T}})"/>
  /// <seealso cref="TableRow{T}(IEnumerable{T})"/>
  [Fact]
  public void Constructors()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TableRow{T}.ToString()"/> method.</para>
  /// </summary>
  [Fact]
  public void ToString_Method()
  {
    using (new AssertionScope())
    {
    }

    throw new NotImplementedException();
  }
}