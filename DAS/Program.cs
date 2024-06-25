namespace DAS;

class Program
{
  public static void Main()
  {
    Package package1 = new Package();
    package1.weight = 5;
    package1.isFragile = false;
    Package package2 = new Package();
    package2.weight = 2;
    package2.isFragile = true;
    Package package3 = new Package();
    package3.weight = 3;
    package3.isFragile = false;
    Package package4 = new Package();
    package4.weight = 10;
    package4.isFragile = false;
    Package package5 = new Package();
    package5.weight = 1;
    package5.isFragile = true;

    Package[] packages = new Package[] { package1, package2, package3, package4, package5 };

    SelectionSortTask selectionSortTask = new SelectionSortTask();

    selectionSortTask.Run(packages);


    // CommitHistory commitHistory = new CommitHistory();
    // string filePath = "./currentProject/test.cs";


    // // insert text into file
    // string createText = "// first commit" + Environment.NewLine;
    // File.WriteAllText(filePath, createText);

    // // commit
    // commitHistory.commit("first commit");

    // string readText = File.ReadAllText(filePath);
    // Console.WriteLine($"text in the file :  {readText}");





    // // insert text into file
    // string createText2 = "// second commit" + Environment.NewLine;
    // File.WriteAllText(filePath, createText2);



    // // commit
    // commitHistory.commit("first commit");

    // string readText2 = File.ReadAllText(filePath);
    // Console.WriteLine($"text in the file :  {readText2}");


    // string firstCommitId = commitHistory.getCommitId(0);
    // commitHistory.checkout(firstCommitId);

    // string readText3 = File.ReadAllText(filePath);
    // Console.WriteLine($"text in the file :  {readText3}");
  }
}
