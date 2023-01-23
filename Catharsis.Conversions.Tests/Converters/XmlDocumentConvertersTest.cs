﻿using System.Xml;
using FluentAssertions;
using Xunit;

namespace Catharsis.Conversions.Tests;

/// <summary>
///   <para>Tests set for class <see cref="XmlDocumentConverters"/>.</para>
/// </summary>
public sealed class XmlDocumentConvertersTest : UnitTest
{
  /// <summary>
  ///   <para>Performs testing of <see cref="XmlDocumentConverters.Bytes(IConversion{XmlDocument})"/> method.</para>
  /// </summary>
  [Fact]
  public void Bytes_Method()
  {
    AssertionExtensions.Should(() => XmlDocumentConverters.Bytes(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }

  /// <summary>
  ///   <para>Performs testing of <see cref="XmlDocumentConverters.Text(IConversion{XmlDocument})"/> method.</para>
  /// </summary>
  [Fact]
  public void Text_Method()
  {
    AssertionExtensions.Should(() => XmlDocumentConverters.Text(null)).ThrowExactly<ArgumentNullException>().WithParameterName("conversion");

    throw new NotImplementedException();
  }
}