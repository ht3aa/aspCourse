namespace TasksSolutions.Solutions;


class Tasks
{
  // Task 1
  public static int SumOf2(int a, int b)
  {

    if (a == b)
    {
      return 3 * (a + b);
    }

    return a + b;
  }


  // Task 2
  public static int AbsoluteDiffFor51(int a)
  {
    if (a > 51)
    {
      return 3 * (a - 51);
    }

    return 51 - a;
  }

  // Task 3
  public static bool CheckIfNIs30OrSumIsGreater(int a, int b)
  {
    return a == 30 || b == 30 || a + b == 30;
  }

  // Task 4
  public static bool CheckIfNDiffIs10(int n)
  {
    return (n >= 90 && n <= 110) || (n >= 190 && n <= 210);

  }

  // Task 5
  public static string AddIfIFNotExists(string str)
  {
    if (str[0] == 'i' && str[1] == 'f') return str;
    else return "if" + str;
  }


  // Task 6
  public static string RemoveChar(string str, int index)
  {
    string temp = "";

    for (int i = 0; i < str.Length; i++)
    {
      if (i == index) continue;

      temp += str[i];
    }

    return temp;
  }


  // Task 7
  public static string SwapChar(string str)
  {
    if (str.Length == 1) return str;

    char[] strArray = str.ToCharArray();
    char temp = strArray[0];
    strArray[0] = strArray[strArray.Length - 1];
    strArray[strArray.Length - 1] = temp;


    return new string(strArray);
  }


  // Task 8
  public static string MakeCopyOf4(string str)
  {
    if (str.Length < 2) return str;

    string temp = "";
    for (int i = 0; i < 4; i++)
    {
      temp = str[0] + str[1] + " ";
    }

    return temp;
  }


  // Task 9
  public static string FrontBackChar(string str)
  {
    return str[str.Length - 1] + str + str[str.Length - 1];
  }

  // Task 10
  public static bool IsMultiply(int n)
  {
    return n % 3 == 0 || n % 7 == 0;
  }

  // Task 11
  public static string FrontBack4Char(string str)
  {
    string first3Char = str.Substring(0, 4);
    return first3Char + str + first3Char;
  }


  // Task 12
  public static bool IsStartWithCS(string str)
  {
    return str[0] == 'C' && str[1] == '#';
  }

  // Task 13
  public static bool TempIsLess0AnotherIsGreaterThan100(int temp1, int temp2)
  {
    return (temp1 < 0 && temp2 > 100) || (temp1 > 100 || temp2 < 0);
  }

  // Task 14
  public static bool IsOneInRange100To200(int num1, int num2)
  {
    return (num1 > 100 && num1 < 200) || (num2 > 100 && num2 < 200);
  }

  // Task 15
  public static bool IsOneInRange20To50(int num1, int num2, int num3)
  {
    return (num1 > 20 && num1 < 50) || (num2 > 20 && num2 < 50) || (num3 > 20 && num3 < 50);
  }

  // Task 16
  public static bool IsOneInRange20To50(int num1, int num2)
  {
    return (num1 > 20 && num1 < 50) || (num2 > 20 && num2 < 50);
  }

  // Task 17
  public static string IsYTCharPresent(string str)
  {
    if (str[0] != 'y' && str[1] != 't') return str;
    else return str.Substring(2, str.Length - 2);
  }

  // Task 18
  public static int FindMax(int num1, int num2, int num3)
  {
    int[] numbers = { num1, num2, num3 };
    return numbers.Max();
  }

  // Task 19
  public static int ClosestTo100(int num1, int num2)
  {
    if (num1 == num2) return 0;

    int closest = num1;

    if (num2 > closest && num2 < 100)
    {
      closest = num2;
    }

    return num2;

  }

  // Task 20
  public static bool IsInRange40To60(int num1, int num2)
  {
    return (num1 > 40 && num1 < 60) && (num2 > 40 && num2 < 60);
  }


  // Task 21
  public static int FindMaxInRange20To30(int num1, int num2)
  {
    if (!((num1 > 20 && num1 < 30) && (num2 > 20 && num2 < 30))) return 0;

    return num1 > num2 ? num1 : num2;
  }


  // Task 22
  public static bool ContainsZIn2To4Indexes(string str)
  {
    bool thereZChars = true;
    for (int i = 2; i < 5; i++)
    {
      if (str[i] != 'z')
      {
        thereZChars = false;
      }
    }

    return thereZChars;
  }

  // Task 23
  public static bool SameLastDigit(int num1, int num2)
  {
    return num1 % 10 == num2 % 10;
  }

  // Task 24
  public static string ToUpperLast3Chars(string str)
  {
    if (str.Length < 3) return str.ToUpper();

    string last3Chars = str.Substring(str.Length - 4, str.Length - 2).ToUpper();
    string restStr = str.Substring(0, str.Length - 4);
    return restStr + last3Chars;
  }

  // Task 25
  public static string CopyStr(string str, int howMany)
  {
    string temp = "";
    for (int i = 0; i < howMany; i++)
    {
      temp += str;
    }

    return temp;
  }

  // Task 26
  public static string CheckIfEqual(int num1, int num2)
  {
    return num1 == num2 ? $"{num1} and {num2} are equal" : $"{num1} and {num2} are not equal";
  }


  // Task 27
  public static string CheckIfOddOrEven(int n)
  {
    return n % 2 == 0 ? $"{n} is an even number" : $"{n} is an odd number";
  }

  // Task 28
  public static string CheckIfPostivieOrNegative(int n)
  {
    return n > 0 ? $"{n} is a positive number" : $"{n} is a negative number";
  }


  // Task 29
  public static string CheckIfLeapYear(int n)
  {
    return n % 4 == 0 ? $"{n} is a leap year" : $"{n} is not a leap year";
  }

  // Task 30
  public static string CheckIfLigiableForVote(int n)
  {
    return n >= 18 ? $"Congratulation! You are eligible for casting your vote." : $"Too Small bro";
  }

  // Task 31
  public static string DisplayN(int n)
  {
    return n > 0 ? $"The value of n = 1" : n == 0 ? $"The value of n = 0" : $"The value of n = -1";
  }

  // Task 32
  public static string PersonHeight(int n)
  {
    return n <= 150 ? $"The person is Dwarf" : n > 150 && n <= 170 ? $"The person is Avarage" : n > 170 && n < 180 ? $"The person is tall" : $"The person is very tall";
  }


  // Task 33
  public static string FindMaxString(int num1, int num2, int num3)
  {
    int[] numbers = { num1, num2, num3 };
    int maxNumber = numbers.Max();

    int maxIndex = Array.FindIndex(numbers, (n) => n == maxNumber);

    return $"The {maxIndex + 1}nd number is the greatest among three";
  }

  // Task 34
  public static string WhereIsThePoint(int x, int y)
  {
    if (x > 0 && y > 0)
    {
      return $"The coordinate point ({x},{y}) lies in the First quadrant.";
    }
    else if (x > 0 && y < 0)
    {
      return $"The coordinate point ({x},{y}) lies in the Fourth quadrant.";
    }
    else if (x < 0 && y > 0)
    {
      return $"The coordinate point ({x},{y}) lies in the Second quadrant.";
    }
    return $"The coordinate point ({x},{y}) lies in the Third quadrant.";
  }

  // Task 35 need explinations
  public static string CheckIfPass(int math, int phy, int chem)
  {
    return "";
  }


  // Task 36
  public static string GetRootOfQuadraticEq(double a, double b, double c)
  {
    double root1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
    double root2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

    return $"root 1 : {root1} , root 2 : {root2}";
  }

  // Task 37
  public static string PrintStudentInfo(int roll, string name, int[] marks)
  {
    int sum = marks[0] + marks[1] + marks[2];
    return $"Roll No: {roll}\nName of Student : {name}\nMarks in Physics : {marks[0]}\nMarks in Chemistry : {marks[1]}\nMarks in Computer Application : {marks[2]}\nTotal Marks : {sum}\nPercentage : {sum / 3}";
  }

  // Task 38
  public static string TempratureMesurment(int temp)
  {
    return temp < 0 ? "Freezing weather" : temp >= 40 ? "Its Very Hot" : temp > 30 ? "Its Hot" : temp > 20 ? "Normal in Temp" : temp > 10 ? "Cold weather" : "Very Cold weather";
  }

  // Task 39
  public static string CheckTriangle(int side1, int side2, int side3)
  {
    if (side1 == side2 && side2 == side3) return "Equilateral Triangle";
    else if (side1 == side2 || side2 == side3 || side1 == side3) return "Isosceles Triangle";
    else return "Scalene Triangle";
  }

  // Task 40
  public static string CheckTriangleCanBeFormed(int theta1, int theta2, int theta3)
  {
    if ((theta1 + theta2 + theta3) == 180) return "Triangle can be formed";
    else return "Triangle cannot be formed";
  }

  // Task 41
  public static string isVowel(char c)
  {
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ? "The alphabet is a vowel" : "The alphabet is a consonant";
  }

  // Task 42
  public static string profitAndLoose(int cost, int sell)
  {
    int diff = sell - cost;
    return diff > 0 ? $"You can book your profit amount : {diff}" : diff < 0 ? $"You can loose your amount : {diff}" : "Neither";
  }

  // Task 43 need more explinations
  public static string NetChargeAmount()
  {
    return "";
  }


  // Task 44 
  public static string GradeDescription(int grade)
  {
    return grade == 'e' ? "Excellent" : grade == 'v' ? "Very Good" : grade == 'g' ? "Good" : grade == 'a' ? "Average" : "Fail";
  }


  // Task 45
  public static string NumberToDayName(int n)
  {
    return n == 1 ? "Monday" : n == 2 ? "Tuesday" : n == 3 ? "Wednesday" : n == 4 ? "Thursday" : n == 5 ? "Friday" : n == 6 ? "Saturday" : "Sunday";
  }

  // Task 46
  public static string NumberToNumberName(int n)
  {
    return n == 1 ? "One" : n == 2 ? "Two" : n == 3 ? "Three" : n == 4 ? "Four" : n == 5 ? "Five" : n == 6 ? "Six" : n == 7 ? "Seven" : n == 8 ? "Eight" : n == 9 ? "Nine" : "Invalid number";
  }

  // Task 47
  public static string NumberToMonthName(int n)
  {
    return n == 1 ? "January" :
           n == 2 ? "February" :
           n == 3 ? "March" :
           n == 4 ? "April" :
           n == 5 ? "May" :
           n == 6 ? "June" :
           n == 7 ? "July" :
           n == 8 ? "August" :
           n == 9 ? "September" :
           n == 10 ? "October" :
           n == 11 ? "November" :
           n == 12 ? "December" :
           "Invalid month";
  }

  // Task 48
  public static string DaysNumberOfMonth(int n)
  {
    return n == 1 ? "Month Have 31 days" :
           n == 2 ? "Month Have 28 days" :
           n == 3 ? "Month Have 31 days" :
           n == 4 ? "Month Have 30 days" :
           n == 5 ? "Month Have 31 days" :
           n == 6 ? "Month Have 30 days" :
           n == 7 ? "Month Have 31 days" :
           n == 8 ? "Month Have 31 days" :
           n == 9 ? "Month Have 30 days" :
           n == 10 ? "Month Have 31 days" :
           n == 11 ? "Month Have 30 days" :
           n == 12 ? "Month Have 31 days" :
           "Invalid month";
  }

  // Task 49
  public static string MenuDriven()
  {
    Console.WriteLine("Choose a geometrical shape to calculate the area:");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("3. Triangle");
    Console.WriteLine("4. Exit");
    Console.Write("Input your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
      case 1:
        CalculateCircleArea();
        break;
      case 2:
        CalculateRectangleArea();
        break;
      case 3:
        CalculateTriangleArea();
        break;
      case 4:
        return ""; // Exit the program
      default:
        Console.WriteLine("Invalid choice. Please select a valid option.");
        break;
    }

    return "";
  }

  static void CalculateCircleArea()
  {
    Console.Write("Input radius of the circle: ");
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"The area is: {area:F6}");
  }

  static void CalculateRectangleArea()
  {
    Console.Write("Input length of the rectangle: ");
    double length = double.Parse(Console.ReadLine());
    Console.Write("Input width of the rectangle: ");
    double width = double.Parse(Console.ReadLine());
    double area = length * width;
    Console.WriteLine($"The area is: {area:F6}");
  }

  static void CalculateTriangleArea()
  {
    Console.Write("Input base of the triangle: ");
    double baseLength = double.Parse(Console.ReadLine());
    Console.Write("Input height of the triangle: ");
    double height = double.Parse(Console.ReadLine());
    double area = 0.5 * baseLength * height;
    Console.WriteLine($"The area is: {area:F6}");
  }



  public static void PrintString(string str)
  {
    Console.WriteLine(str);

    return;
  }

  // Task 50
  public static int StrLength(string str)
  {
    int length = 0;
    try
    {
      for (int i = 0; str[i] != '\0'; i++)
      {
        length += 1;
      }

    }
    catch { }

    return length;
  }


  // Task 51
  public static char[] SeprateStr(string str)
  {
    char[] chars = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
      chars[i] = str[i];
    }

    return chars;
  }


  // Task 52
  public static void PrintReverseOrderStr(string str)
  {

    char[] chars = SeprateStr(str);

    for (int i = chars.Length - 1; i >= 0; i--)
    {
      Console.Write(chars[i]);
    }

    return;
  }


  // Task 53
  public static string TotalWordsInStr(string str)
  {
    string[] words = str.Split(' ');

    return $"Total number of words in the string is : {words.Length}";
  }


  // Task 54
  public static string CompareStrs(string str1, string str2)
  {

    if (str1 == str2)
    {
      return "The length of both strings are equal and also, both strings are equal.";
    }
    else
    {
      return "The two strings are not equal";
    }
  }


  // Task 55
  public static string CountAlphabetsDigitsSpecialChars(string str)
  {
    int alphabets = 0;
    int digits = 0;
    int specialChars = 0;

    for (int i = 0; i < str.Length - 1; i++)
    {
      if (str[i] >= 'A' && str[i] < 'Z' || str[i] >= 'a' && str[i] <= 'z')
      {
        alphabets += 1;
      }
      else if (str[i] >= '0' && str[i] <= '9')
      {
        digits += 1;
      }
      else
      {
        specialChars += 1;
      }
    }

    return $"Number of Alphabets in the string is : {alphabets}\nNumber of Digits in the string is : {digits}\nNumber of Special characters in the string is : {specialChars}";
  }

  // Task 56
  public static string VowelsAndConsonantInStr(string str)
  {
    int vowels = 0;
    int consonants = 0;

    for (int i = 0; i < str.Length - 1; i++)
    {
      if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
      {
        vowels += 1;
      }
      else
      {
        consonants += 1;
      }
    }

    return $"The total number of vowel in the string is : {vowels} \nThe total number of consonant in the string is : {consonants}";
  }


  // Task 57
  public static string CharFreqauncy(string str, char charToLookFor)
  {
    int freq = 0;

    for (int i = 0; i < str.Length - 1; i++)
    {
      if (str[i] == charToLookFor)
      {
        freq += 1;
      }
    }

    return $"The Highest frequency of character '{charToLookFor}' appears number of times : {freq}";
  }

  // Task 58
  public static string SortStr(string str)
  {
    char[] chars = str.ToArray();
    Array.Sort(chars);
    return new string(chars);
  }


  // Task 59
  public static string[] BubbleSortStr(string[] strs)
  {
    string temp = "";

    for (int k = -1; k < strs.Length; k++)
    {

      for (int i = 0; i < strs.Length - 1; i++)
      {
        for (int j = 0; j < strs[i].Length; j++)
        {
          if (strs[i][j] > strs[i + 1][j])
          {
            temp = strs[i];
            strs[i] = strs[i + 1];
            strs[i + 1] = temp;
            break;
          }
          else if (strs[i][j] < strs[i + 1][j])
          {
            break;
          }
        }

      }
    }
    return strs;
  }

  // Task 60
  public static string SubStr(string str, int start, int length)
  {
    char[] subStr = new char[length];

    for (int i = start; i < length; i++)
    {
      subStr[i] = str[i];
    }

    return new string(subStr);

  }

  // Task 61
  public static bool IsSubStrPresent(string str, string searchStr)
  {
    return str.Contains(searchStr);
  }


  // Task 62
  public static string ReverseCharCase(string str)
  {
    char[] strArr = str.ToArray();

    for (int i = 0; i < strArr.Length; i++)
    {
      if (strArr[i] >= 'a' && strArr[i] <= 'z')
      {
        strArr[i] = Char.ToUpper(strArr[i]);
      }
      else
      {
        strArr[i] = Char.ToLower(strArr[i]);
      }
    }

    return new string(strArr);
  }

  // Task 62
  public static void nothing()
  { }


  // Task 63
  public static string FindIndexOfSubStr(string str, string searchStr)
  {
    return $"The index of the first occurrence of the substring '{searchStr}' in the string '{str}' is : {str.IndexOf(searchStr)}";
  }

  // Task 64
  public static string IsAlphabet(char c)
  {
    if ((c >= 'a' && c <= 'z'))
    {
      return "The character is uppercase";
    }
    else if ((c >= 'A' && c <= 'Z'))
    {
      return "The character is lowercase";
    }
    else
    {
      return "The character is not an alphabet";
    }
  }


  // Task 65
  public static string FrequencyOfSubStr(string str, string searchStr)
  {
    return $"The number of occurrences of the substring '{searchStr}' in the string '{str}' is : {str.Split(searchStr).Length - 1}";
  }

  // Task 66
  public static string InsertSubStrInStr(string str, string searchStr, string insertStr)
  {
    return $"{str.Insert(str.IndexOf(searchStr), insertStr)}";
  }

  // Task 67
  // nothing
  

  // Task 68
}
