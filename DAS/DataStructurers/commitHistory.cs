
using Microsoft.VisualBasic.FileIO;

namespace DAS;

class CommitNode
{
  public string commitId = "";
  public string commitMsg = "";

  public CommitNode? nextNode { get; set; }
  public CommitNode? prevNode { get; set; }

  public CommitNode()
  {
    this.prevNode = null;
    this.nextNode = null;
  }

  public void saveData()
  {
    Directory.CreateDirectory($"./commitHistory/{commitId}/");
    FileSystem.CopyDirectory("./currentProject/", $"./commitHistory/{commitId}/");
  }


  public void activteNode()
  {
    FileSystem.CopyDirectory($"./commitHistory/{commitId}", "./currentProject/");
  }
}

class CommitHistory
{

  public CommitNode FIRSTNODE = new CommitNode();
  public CommitNode HEAD = new CommitNode();
  public int nodesNumber = -1;


  private string generateRandomStr()
  {
    string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
    string randomStr = "";
    var random = new Random();

    for (short i = 0; i < 8; i++)
    {
      randomStr += chars[random.Next(chars.Length)];
    }

    return randomStr;

  }

  public string getCommitId(int index)
  {
    CommitNode currentNode = FIRSTNODE;
    int currentIndex = 0;

    while (currentIndex != index)
    {
      currentNode = currentNode.nextNode;
      currentIndex++;
    }

    return currentNode.commitId;
  }

  private void deleteAllfilesAndFolders(string folderPath)
  {

    System.IO.DirectoryInfo di = new DirectoryInfo(folderPath);

    foreach (FileInfo file in di.GetFiles())
    {
      file.Delete();
    }
    foreach (DirectoryInfo dir in di.GetDirectories())
    {
      dir.Delete(true);
    }
  }

  public void commit(string msg)
  {
    CommitNode newNode = new CommitNode();
    newNode.commitMsg = msg;
    newNode.commitId = generateRandomStr();


    newNode.saveData();

    CommitNode currentNode = FIRSTNODE;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
    }

    if (nodesNumber == -1)
    {
      FIRSTNODE = newNode;
    }
    else
    {
      currentNode.nextNode = newNode;
      newNode.prevNode = currentNode;
    }


    HEAD = newNode;

    nodesNumber++;
  }


  public void checkout(string commitId)
  {
    deleteAllfilesAndFolders("./currentProject");
    CommitNode currentNode = HEAD;

    while (currentNode.commitId != commitId)
    {
      currentNode = currentNode.prevNode;
    }

    currentNode.activteNode();
  }



  public void PrintAllNodes()
  {
    CommitNode currentNode = FIRSTNODE;
    while (currentNode.nextNode != null)
    {
      Console.WriteLine(currentNode.commitId);
      currentNode = currentNode.nextNode;
    }
    Console.WriteLine(currentNode.commitId);

    while (currentNode.prevNode != null)
    {

      Console.WriteLine(currentNode.commitId);
      currentNode = currentNode.prevNode;
    }
    Console.WriteLine(currentNode.commitId);
  }
}
