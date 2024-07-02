namespace Recursion;

class Tasks
{

  public static void PrintNaturalNumbersTo50(int n)
  {
    if (n > 50) return;

    Console.WriteLine(n);

    PrintNaturalNumbersTo50(++n);
  }

  public static int SumNumbersToN(int n)
  {
    if (n == 1) return n;

    return n + SumNumbersToN(--n);
  }


  public static void FibonacciSeries(int number1 = 0, int number2 = 1, int sum = 0, int i = 0)
  {
    if (i == 9) return;

    sum = number1 + number2;
    number1 = number2;
    number2 = sum;

    Console.WriteLine(sum);

    if (number2 == 1)
      Console.WriteLine(sum);

    FibonacciSeries(number1, number2, sum, ++i);
  }

  public static void PrintArrayElements(int[] arr, int i)
  {
    if (i == arr.Length) return;

    Console.WriteLine(arr[i]);

    PrintArrayElements(arr, ++i);
  }

  public static int getTheDigitCountOfANumber(int n, int digitNumber)
  {
    if (n == 0) return digitNumber;

    n = n / 10;
    digitNumber++;

    return getTheDigitCountOfANumber(n, digitNumber);
  }

  public static int getDigitSumOfANumber(int n, int sum)
  {
    if (n == 0) return sum;

    int reminder = n % 10;
    sum += reminder;

    n = n / 10;

    return getDigitSumOfANumber(n, sum);
  }

  public static int FindGCD(int numerator, int denumerator)
  {
    if (numerator % denumerator == 0) return denumerator;


    int divideResult = numerator / denumerator;
    int multiplyResult = denumerator * divideResult;
    int result = numerator - multiplyResult;

    numerator = denumerator;
    denumerator = result;

    return FindGCD(numerator, denumerator);
  }
}
