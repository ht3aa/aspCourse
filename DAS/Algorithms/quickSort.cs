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
        swap(arr, i, index);

      }
    }
    index++;
    swap(arr, index, right);
    return index;
  }

  public static void swap(List<Tuple<int, string>> arr, int a, int b)
  {
    Tuple<int, string> temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
  }

}
