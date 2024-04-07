using FluentAssertions.Execution;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="TempFile"/>.</para>
/// </summary>
public sealed class TempFileTest : ClassTest<TempFile>
{
  /// <summary>
  ///   <para>Performs testing of class constructor(s).</para>
  /// </summary>
  /// <seealso cref="TempFile()"/>
  /// <seealso cref="TempFile(string)"/>
  /// <seealso cref="TempFile(FileInfo)"/>
  [Fact]
  public void Constructors()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="TempFile.File"/> property.</para>
  /// </summary>
  [Fact]
  public void File_Property()
  {
    throw new NotImplementedException();
  }


  /// <summary>
  ///   <para>Performs testing of <see cref="TempFile.Dispose()"/> method.</para>
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