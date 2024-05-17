using NUnit.Framework;

namespace IsometrixApp.Tests;

[TestFixture]
public class StringCalculatorTests
{
  private StringCalculator _calculator;

  [SetUp]
  public void Setup()
  {
    _calculator = new StringCalculator();
  }

  [Test]
  public void Add_GivenEmptyString_ReturnsZero()
  {
    var result = _calculator.Add("");
    Assert.AreEqual(0, result);
  }

  [Test]
  public void Add_GivenSingleNumber_ReturnsNumber()
  {
    var result = _calculator.Add("5");
    Assert.AreEqual(5, result);
  }

  [Test]
  public void Add_GivenTwoNumbers_ReturnsSum()
  {
    var result = _calculator.Add("3,8");
    Assert.AreEqual(11, result);
  }
}

