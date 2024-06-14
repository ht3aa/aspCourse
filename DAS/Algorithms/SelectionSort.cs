namespace DAS;

class SelectionSort : HelpFullMethods
{
  public static void Run(string[] names)
  {

    int lowIndex = 0;
    int highIndex = names.Length - 1;
    string maxName = "";
    int maxNameIndex = 0;

    while (lowIndex <= highIndex)
    {
      maxName = names[lowIndex];
      for (int i = lowIndex + 1; i <= highIndex; i++)
      {
        if (CompareBetween(maxName, names[lowIndex]) == StrComparisionEnum.Str1SmallerThanStr2)
        {
          maxName = names[lowIndex];
          maxNameIndex = i;
        }
      }
      Swap(ref names[lowIndex], ref names[maxNameIndex]);
      lowIndex++;
    }

    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine(names[i]);
    }
  }


}
