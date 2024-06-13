namespace DAS;

public enum StrComparisionEnum
{
  Str1EqualThanStr2,
  Str1BiggerThanStr2,
  Str1SmallerThanStr2,
}

public class BinarySearch
{

  public static StrComparisionEnum CompareBetween(string str1, string str2)
  {

    int lengthOfSmallestName = str1.Length;
    if (lengthOfSmallestName > str2.Length)
    {
      lengthOfSmallestName = str2.Length;
    }
    for (int i = 0; i < lengthOfSmallestName; i++)
    {
      if (str1[i] == str2[i]) continue;
      else if (str1[i] > str2[i]) return StrComparisionEnum.Str1BiggerThanStr2;
      else return StrComparisionEnum.Str1SmallerThanStr2;
    }

    return StrComparisionEnum.Str1EqualThanStr2;
  }
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
