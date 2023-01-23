using Catharsis.Extensions;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="FuncConverters"/>.</para>
/// </summary>
public sealed class FuncConvertersTest : UnitTest
{
  private IConversion<Func<object>> Conversion = ((Func<object>) (() => new object())).Convert();

  /// <summary>
  ///   <para>Performs testing of following methods :</para>
  ///   <list type="bullet">
  ///     <item><description><see cref="FuncConverters.Task{T}(IConversion{Func{T}})"/></description></item>
  ///     <item><description><see cref="FuncConverters.Task{T}(IConversion{Func{object, T}}, object, TaskCreationOptions, CancellationToken)"/></description></item>
  ///   </list>
  /// </summary>
  [Fact]
  public void Task_Methods()
  {
    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => FuncConverters.Task<object>(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
      AssertionExtensions.Should(() => FuncConverters.Task<object>(null, TaskCreationOptions.None, Cancellation)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    }

    using (new AssertionScope())
    {
      AssertionExtensions.Should(() => FuncConverters.Task<object>(null, new object())).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();

    }

    throw new NotImplementedException();
  }
}