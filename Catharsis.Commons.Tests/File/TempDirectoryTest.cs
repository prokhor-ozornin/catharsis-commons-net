using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TempDirectory"/>.</para>
/// </summary>
public sealed class TempDirectoryTest : ClassTest<TempDirectory>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TempDirectory()"/>
  /// <seealso cref="TempDirectory(string)"/>
  /// <seealso cref="TempDirectory(DirectoryInfo)"/>
  [Fact]
  public void Constructors()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TempDirectory.Directory"/> property.</para>
  /// </summary>
  [Fact]
  public void Directory_Property()
  {
    throw new NotImplementedException();
  }


  /// <summary>
  ///   <para>Performs testing of <see cref="TempDirectory.Dispose()"/> method.</para>
  /// </summary>
  [Fact]
  public void Dispose_Method()
  {
    using (new AssertionScope())
    {
    }

    throw new NotImplementedException();
  }
}