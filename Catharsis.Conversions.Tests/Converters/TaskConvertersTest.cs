using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TaskConverters"/>.</para>
/// </summary>
public sealed class TaskConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="TaskConverters.ValueTask(IConversion{Task}, string)"/></description></item>
  ///     <item><description><see cref="TaskConverters.ValueTask{T}(IConversion{Task{T}}, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void ValueTask_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TaskConverters.ValueTask(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => TaskConverters.ValueTask<object>(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");
    }

    throw new NotImplementedException();
  }
}