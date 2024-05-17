namespace IsometrixApp;

public class StringCalculator
{
  public int Add(string numbers)
  {
    if (string.IsNullOrEmpty(numbers))
      return 0;

    var numberArray = numbers.Split(',');

    if (numberArray.Length == 1)
      return int.Parse(numberArray[0]);

    return int.Parse(numberArray[0]) + int.Parse(numberArray[1]);
  }
}