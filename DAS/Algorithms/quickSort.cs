namespace DAS;
class QuickSort
{
  public static void Quick_Sort(List<Tuple<int, string>> arr, int left, int right)
  {
    if (left < right)
    {
      int index = Partition(arr, left, right);

      Quick_Sort(arr, left, index - 1);
      Quick_Sort(arr, index + 1, right);
    }
  }

  public static int Partition(List<Tuple<int, string>> arr, int left, int right)
  {
    Tuple<int, string> pivot = arr[right];
    int index = left - 1;
    for (int i = left; i < right; i++)
    {
      if (arr[i].Item1 <= pivot.Item1)
      {
        index++;
        swap(arr[i], arr[index]);
      }
    }
    index++;
    swap(arr[index], arr[right]);
    return index;
  }

  public static void swap(Tuple<int, string> item1, Tuple<int, string> item2)
  {
    Tuple<int, string> temp = item1;
    item1 = item2;
    item2 = item1;
  }

}
