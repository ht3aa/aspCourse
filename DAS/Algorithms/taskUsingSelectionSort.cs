namespace DAS;

class Package
{
  public bool isFragile = false;
  public int weight = 0;
}


class SelectionSortTask : HelpFullMethods
{
  public void Run(Package[] packages)
  {

    Package minPackage = new Package();
    int highIndex = packages.Length - 1;
    int lowIndex = 0;
    int minPackageIndex = lowIndex;

    while (lowIndex <= highIndex)
    {
      minPackage = packages[lowIndex];
      minPackageIndex = lowIndex;

      for (int i = lowIndex + 1; i <= highIndex; i++)
      {
        if (minPackage.weight > packages[i].weight)
        {
          minPackage = packages[i];
          minPackageIndex = i;
        }
      }

      if (minPackageIndex != lowIndex)
        Swap<Package>(ref packages[lowIndex], ref packages[minPackageIndex]);

      lowIndex++;
    }


    // here is the sortedPackages to sort according to isFragile or not
    Package[] sortedPackages = new Package[packages.Length];
    int sortedPackagesIndex = 0;

    // add all is not fragile first
    for (int i = 0; i <= highIndex; i++)
    {
      if (!packages[i].isFragile)
      {
        sortedPackages[sortedPackagesIndex] = packages[i];
        sortedPackagesIndex++;

      }
    }

    // add all is fragile second
    for (int i = 0; i <= highIndex; i++)
    {
      if (packages[i].isFragile)
      {
        sortedPackages[sortedPackagesIndex] = packages[i];
        sortedPackagesIndex++;

      }
    }

    for (int i = 0; i < sortedPackages.Length; i++)
    {
      Console.WriteLine($"package {i} : weight: {sortedPackages[i].weight} , isFragile: {sortedPackages[i].isFragile}");
    }
  }


}
