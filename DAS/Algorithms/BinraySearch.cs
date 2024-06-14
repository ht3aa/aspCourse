namespace DAS;

public class BinarySearch : HelpFullMethods
{

  public static string Run(string[] names, string wantedName)
  {
    // lowIndex and highIndex is the boundries of searchable items
    int lowIndex = 0;
    int highIndex = names.Length - 1;
    int middleIndex = 0;
    int steps = 0;
    string guess = "";

    while (lowIndex <= highIndex)
    {
      middleIndex = (highIndex + lowIndex) / 2;
      guess = names[middleIndex];

      steps++;

      if (guess == wantedName) return $"The name you search for is {guess} - It takes {steps} steps";
      else if (CompareBetween(guess, wantedName) == StrComparisionEnum.Str1BiggerThanStr2) highIndex = middleIndex - 1;
      else lowIndex = middleIndex + 1;
    }
    return "There is no data with that name";
  }
}
