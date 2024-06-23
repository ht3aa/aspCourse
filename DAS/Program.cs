namespace DAS;

class Program
{
  public static void Main()
  {
    CommitHistory commitHistory = new CommitHistory();
    string filePath = "./currentProject/test.cs";


    // insert text into file
    string createText = "// first commit" + Environment.NewLine;
    File.WriteAllText(filePath, createText);

    // commit
    commitHistory.commit("first commit");

    string readText = File.ReadAllText(filePath);
    Console.WriteLine($"text in the file :  {readText}");





    // insert text into file
    string createText2 = "// second commit" + Environment.NewLine;
    File.WriteAllText(filePath, createText2);



    // commit
    commitHistory.commit("first commit");

    string readText2 = File.ReadAllText(filePath);
    Console.WriteLine($"text in the file :  {readText2}");


    string firstCommitId = commitHistory.getCommitId(0);
    commitHistory.checkout(firstCommitId);

    string readText3 = File.ReadAllText(filePath);
    Console.WriteLine($"text in the file :  {readText3}");
  }
}
