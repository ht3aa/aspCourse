namespace DAS;

public enum StrComparisionEnum
{
  Str1EqualThanStr2,
  Str1BiggerThanStr2,
  Str1SmallerThanStr2,
}

public class HelpFullMethods
{

  public static void Swap(ref string str1, ref string str2)
  {
    string temp = str1;
    str1 = str2;
    str2 = temp;
  }

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
}
