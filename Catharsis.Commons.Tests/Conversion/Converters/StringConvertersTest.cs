﻿using System.Text;
using Catharsis.Extensions;
using FluentAssertions;
using Xunit;

namespace Catharsis.Commons.Tests;

/// <summary>
///   <para>Tests set for class <see cref="StringConverters"/>.</para>
/// </summary>
public sealed class StringConvertersTest : UnitTest
{
  private IConversion<string> Conversion { get; } = string.Empty.Convert();

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Bytes(IConversion{string}, Encoding, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Boolean(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Boolean_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Boolean(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Sbyte(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Sbyte_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Sbyte(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Byte(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Byte_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Byte(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Short(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Short_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Short(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Ushort(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Ushort_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Ushort(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Int(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Int_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Int(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Uint(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Uint_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Uint(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Long(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Long_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Long(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Ulong(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Ulong_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Ulong(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Float(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Float_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Float(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Double(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Double_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Double(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Decimal(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Decimal_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Decimal(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Guid(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Guid_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Guid(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Uri(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Uri_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Uri(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Type(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Type_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Type(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.DateTime(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTime_Method()
  {
    AssertionExtensions.Should(() => StringConverters.DateTime(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.DateTimeOffset(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateTimeOffset_Method()
  {
    AssertionExtensions.Should(() => StringConverters.DateTimeOffset(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.DateOnly(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DateOnly_Method()
  {
    AssertionExtensions.Should(() => StringConverters.DateOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.TimeOnly(IConversion{string}, IFormatProvider, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void TimeOnly_Method()
  {
    AssertionExtensions.Should(() => StringConverters.TimeOnly(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.FileInfo(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void FileInfo_Method()
  {
    AssertionExtensions.Should(() => StringConverters.FileInfo(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.DirectoryInfo(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void DirectoryInfo_Method()
  {
    AssertionExtensions.Should(() => StringConverters.DirectoryInfo(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.IPAddress(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void IPAddress_Method()
  {
    AssertionExtensions.Should(() => StringConverters.IPAddress(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.IPHostEntry(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void IPHostEntry_Method()
  {
    AssertionExtensions.Should(() => StringConverters.IPHostEntry(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Regex(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Regex_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Regex(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.StringBuilder(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StringBuilder_Method()
  {
    AssertionExtensions.Should(() => StringConverters.StringBuilder(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.StringReader(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void StringReader_Method()
  {
    AssertionExtensions.Should(() => StringConverters.StringReader(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.Process(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void Process_Method()
  {
    AssertionExtensions.Should(() => StringConverters.Process(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.XmlDocument(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XmlDocument_Method()
  {
    AssertionExtensions.Should(() => StringConverters.XmlDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.XDocument(IConversion{string}, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocument_Method()
  {
    AssertionExtensions.Should(() => StringConverters.XDocument(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="StringConverters.XDocumentAsync(IConversion{string}, CancellationToken, string)"/> method.</para>
  /// </summary>
  [Fact]
  public void XDocumentAsync_Method()
  {
    AssertionExtensions.Should(() => StringConverters.XDocumentAsync(null)).ThrowExactlyAsync<ArgumentNullException>().WithParameterName("conversion").Await();
    AssertionExtensions.Should(() => Conversion.XDocumentAsync(Attributes.CancellationToken())).ThrowExactlyAsync<OperationCanceledException>().Await();

    throw new NotImplementedException();
  }
}