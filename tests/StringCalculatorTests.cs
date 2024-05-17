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

  [Test]
  public void Add_GivenFourNumbers_ReturnsSum()
  {
    var result = _calculator.Add("1,2,3,4");
    Assert.AreEqual(10, result);
  }

  [Test]
  public void Add_GivenTenNumbers_ReturnsSum()
  {
    var result = _calculator.Add("1,2,3,4,5,6,7,8,9,10");
    Assert.AreEqual(55, result);
  }

  [Test]
  public void Add_GivenNumbersWithNewlines_ReturnsSum()
  {
    var result = _calculator.Add("1\n2,3");
    Assert.AreEqual(6, result);
  }

  [Test]
  public void Add_GivenNumbersWithCustomDelimiter_ReturnsSum()
  {
    var result = _calculator.Add("//;\n1;2");
    Assert.AreEqual(3, result);
  }

  [Test]
  public void Add_GivenNumbersWithCustomDelimiterAndNewlines_ReturnsSum()
  {
    var result = _calculator.Add("//$\n1$2\n3");
    Assert.AreEqual(6, result);
  }

  [Test]
  public void Add_GivenNegativeNumbers_ThrowsExceptionWithMessage()
  {
    var ex = Assert.Throws<ArgumentException>(() => _calculator.Add("-1,2,-3"));
    Assert.AreEqual("negatives not allowed: -1,-3", ex.Message);
  }

  [Test]
  public void Add_GivenNumberGreaterThan1000_IgnoresNumber()
  {
    var result = _calculator.Add("2,1001");
    Assert.AreEqual(2, result);
  }
}
