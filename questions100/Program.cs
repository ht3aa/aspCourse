using TasksSolutions.Solutions;

namespace TasksSolutions;

class Program
{
  static void Main()
  {
    Console.WriteLine(Tasks.SumOf2(2, 3));
    Console.WriteLine(Tasks.AbsoluteDiffFor51(50));
    Console.WriteLine(Tasks.CheckIfNIs30OrSumIsGreater(4, 7));
    Console.WriteLine(Tasks.CheckIfNDiffIs10(100));
    Console.WriteLine(Tasks.AddIfIFNotExists("Hello"));
    Console.WriteLine(Tasks.RemoveChar("Hello", 1));
    Console.WriteLine(Tasks.SwapChar("Hello"));
    Console.WriteLine(Tasks.MakeCopyOf4("Hello"));
    Console.WriteLine(Tasks.FrontBackChar("Hello"));
    Console.WriteLine(Tasks.IsMultiply(12));
    Console.WriteLine(Tasks.FrontBack4Char("Hello"));
    Console.WriteLine(Tasks.IsStartWithCS("C#"));
    Console.WriteLine(Tasks.TempIsLess0AnotherIsGreaterThan100(5, 10));
    Console.WriteLine(Tasks.IsOneInRange100To200(100, 200));
    Console.WriteLine(Tasks.IsOneInRange20To50(20, 50, 60));
    Console.WriteLine(Tasks.IsOneInRange20To50(20, 50));
    Console.WriteLine(Tasks.IsYTCharPresent("ytHello"));
    Console.WriteLine(Tasks.FindMax(10, 20, 30));
    Console.WriteLine(Tasks.ClosestTo100(90, 110));
    Console.WriteLine(Tasks.IsInRange40To60(45, 55));
    Console.WriteLine(Tasks.FindMaxInRange20To30(25, 27));
    Console.WriteLine(Tasks.ContainsZIn2To4Indexes("abczdef"));
    Console.WriteLine(Tasks.SameLastDigit(123, 153));
    Console.WriteLine(Tasks.ToUpperLast3Chars("abcdef"));
    Console.WriteLine(Tasks.CopyStr("Hello", 3));
    Console.WriteLine(Tasks.CheckIfEqual(5, 5));
    Console.WriteLine(Tasks.CheckIfOddOrEven(6));
    Console.WriteLine(Tasks.CheckIfPostivieOrNegative(-5));
    Console.WriteLine(Tasks.CheckIfLeapYear(2020));
    Console.WriteLine(Tasks.CheckIfLigiableForVote(20));
    Console.WriteLine(Tasks.DisplayN(0));
    Console.WriteLine(Tasks.PersonHeight(165));
    Console.WriteLine(Tasks.FindMaxString(10, 20, 30));
    Console.WriteLine(Tasks.WhereIsThePoint(10, -5));
    Console.WriteLine(Tasks.GetRootOfQuadraticEq(1, -3, 2));
    int[] marks = { 85, 90, 88 };
    Console.WriteLine(Tasks.PrintStudentInfo(1, "John", marks));
    Console.WriteLine(Tasks.TempratureMesurment(15));
    Console.WriteLine(Tasks.CheckTriangle(5, 5, 5));
    Console.WriteLine(Tasks.CheckTriangleCanBeFormed(60, 60, 60));
    Console.WriteLine(Tasks.isVowel('a'));
    Console.WriteLine(Tasks.profitAndLoose(100, 150));
    Console.WriteLine(Tasks.GradeDescription('e'));
    Console.WriteLine(Tasks.NumberToDayName(3));
    Console.WriteLine(Tasks.NumberToNumberName(7));
    Console.WriteLine(Tasks.NumberToMonthName(5));
    Console.WriteLine(Tasks.DaysNumberOfMonth(2));

    // Tasks.MenuDriven();

    Console.WriteLine(Tasks.GetRootOfQuadraticEq(3, 5, 1));
    Console.WriteLine(Tasks.StrLength("Hello"));
    Console.WriteLine(Tasks.SeprateStr("Hello"));
    Tasks.PrintReverseOrderStr("Hello");
    Console.WriteLine(Tasks.TotalWordsInStr("Hello mother and father"));
    Console.WriteLine(Tasks.CompareStrs("hello", "hello"));
    Console.WriteLine(Tasks.VowelsAndConsonantInStr("hello"));
    Console.WriteLine(Tasks.SortStr("this is a string"));
    string[] strs = Tasks.BubbleSortStr(["mnop", "zzbb", "ttbb","eree", "ggls", "xbdb", "abcd"]);

    for(int i = 0; i < strs.Length; i++)
    {
      Console.WriteLine(strs[i]);
    }

    Console.WriteLine(Tasks.SubStr("hello", 1, 3));
    Console.WriteLine(Tasks.ReverseCharCase("hello Mother"));
    Console.WriteLine(Tasks.FindIndexOfSubStr("hello", "ll"));
    Console.WriteLine(Tasks.IsAlphabet('c'));
    Console.WriteLine(Tasks.FrequencyOfSubStr("hello", "ll"));

  }
}
