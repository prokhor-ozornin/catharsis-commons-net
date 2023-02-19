using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="ActionConverters"/>.</para>
/// </summary>
public sealed class ActionConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="ActionConverters.Task(IConversion{Action}, TaskCreationOptions, CancellationToken, string)"/></description></item>
  ///     <item><description><see cref="ActionConverters.Task(IConversion{Action{object}}, object, TaskCreationOptions, CancellationToken, string)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Task_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ActionConverters.Task(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => ActionConverters.Task(null, new object())).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    }

    throw new NotImplementedException();
  }
}