namespace IsometrixApp;

public class StringCalculator
{
  public int Add(string numbers)
  {
    if (string.IsNullOrEmpty(numbers))
      return 0;

    var delimiter = ",";
    if (numbers.StartsWith("//"))
    {
      var delimiterEndIndex = numbers.IndexOf("\n");
      delimiter = numbers.Substring(2, delimiterEndIndex - 2);
      numbers = numbers.Substring(delimiterEndIndex + 1);
    }

    var numberArray = numbers.Split(new[] { delimiter, ",", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    var negatives = new List<int>(); // List to store negative numbers. 

    var sum = 0;
    foreach (var numStr in numberArray)
    {
        var num = int.Parse(numStr);
        if (num < 0)
            negatives.Add(num);
        else if (num <= 1000) // Check if number is less than or equal to 1000
            sum += num; 
    }

    if (negatives.Any()) // If any negative numbers were found.
    {
        var negativeNumbersString = string.Join(",", negatives);
        throw new ArgumentException("negatives not allowed: " + negativeNumbersString);
    }

    return sum;
  }

}