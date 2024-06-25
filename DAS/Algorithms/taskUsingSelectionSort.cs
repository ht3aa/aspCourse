namespace DAS;

class Package
{
  public bool isFragile = false;
  public int weight = 0;
}


class SelectionSortTask : HelpFullMethods
{

  // implementation of selection sort algorithm
  public void Run(Package[] packages)
  {

    Package minPackage = new Package();
    int rightIndex = packages.Length - 1;
    int leftIndex = 0;
    int minPackageIndex = leftIndex;

    while (leftIndex <= rightIndex)
    {
      minPackage = packages[leftIndex];
      minPackageIndex = leftIndex;

      for (int i = leftIndex + 1; i <= rightIndex; i++)
      {
        if (minPackage.weight > packages[i].weight)
        {
          minPackage = packages[i];
          minPackageIndex = i;
        }
      }

      if (minPackageIndex != leftIndex)
        Swap<Package>(ref packages[leftIndex], ref packages[minPackageIndex]);

      leftIndex++;
    }


    // here is the sortedPackages to sort according to isFragile or not
    Package[] sortedPackages = new Package[packages.Length];
    int sortedPackagesIndex = 0;

    // add all is not fragile first
    for (int i = 0; i <= rightIndex; i++)
    {
      if (!packages[i].isFragile)
      {
        sortedPackages[sortedPackagesIndex] = packages[i];
        sortedPackagesIndex++;

      }
    }

    // add all is fragile second
    for (int i = 0; i <= rightIndex; i++)
    {
      if (packages[i].isFragile)
      {
        sortedPackages[sortedPackagesIndex] = packages[i];
        sortedPackagesIndex++;

      }
    }

    // just printing the sorted packages
    for (int i = 0; i < sortedPackages.Length; i++)
    {
      Console.WriteLine($"package {i} : weight: {sortedPackages[i].weight} , isFragile: {sortedPackages[i].isFragile}");
    }
  }


}
