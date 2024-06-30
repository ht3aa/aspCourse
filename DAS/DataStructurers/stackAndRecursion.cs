namespace DAS;

class Recursion
{
  public static void shipAndUnship(int[] ids, int index)
  {


    Console.WriteLine(ids[index]);

    if (index == ids.Length - 1) return;

    shipAndUnship(ids, ++index);

    Console.WriteLine(ids[index]);

    if (index == 1)
      Console.WriteLine(ids[0]);

  }
}
