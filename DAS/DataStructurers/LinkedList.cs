namespace DAS;

class SinglyLinkedListNode
{
  public string data = "";
  public SinglyLinkedListNode? nextNode = null;
}

class SinglyLinkedList
{
  public SinglyLinkedListNode HEAD = new SinglyLinkedListNode();
  public SinglyLinkedListNode TAIL = new SinglyLinkedListNode();


  public bool InsertNodeAtTheStart(string data)
  {
    SinglyLinkedListNode newNode = new SinglyLinkedListNode();
    newNode.data = data;

    SinglyLinkedListNode currentNode = HEAD;

    newNode.nextNode = HEAD.nextNode;
    HEAD.nextNode = newNode;

    return true;
  }


  public bool ReverseLinkedList()
  {

    SinglyLinkedListNode currentNode = HEAD;
    SinglyLinkedListNode? prevNode = null;
    SinglyLinkedListNode? futureNode = null;


    if (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
    }

    while (currentNode.nextNode != null)
    {
      futureNode = currentNode.nextNode;


      currentNode.nextNode = prevNode;
      prevNode = currentNode;
      currentNode = futureNode;

    }

    currentNode.nextNode = prevNode;
    HEAD.nextNode = currentNode;

    return true;
  }

  public bool RemoveFirstNode()
  {

    SinglyLinkedListNode currentNode = HEAD;

    HEAD.nextNode = currentNode.nextNode?.nextNode;

    return true;
  }

  public bool RemoveLastNode()
  {

    SinglyLinkedListNode currentNode = TAIL;

    TAIL.nextNode = currentNode.nextNode?.nextNode;

    return true;
  }

  public string[] ConvertToArray()
  {
    string[] arr = new string[CountNodes()];

    SinglyLinkedListNode currentNode = HEAD;
    int index = -1;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      arr[index] = currentNode.data;
    }

    return arr;
  }

  public string ConvertToString()
  {
    string str = "";

    SinglyLinkedListNode currentNode = HEAD;

    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      str = $"{str} {currentNode.data}";
    }

    return str;
  }

  public bool InsertNodeAtTheEnd(string data)
  {
    SinglyLinkedListNode newNode = new SinglyLinkedListNode();
    newNode.data = data;

    SinglyLinkedListNode currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
    }

    currentNode.nextNode = newNode;
    TAIL.nextNode = newNode;

    return true;
  }

  public bool InsertNodeAtIndex(string data, int wantedIndex)
  {
    if (CountNodes() - 1 == wantedIndex)
    {
      return InsertNodeAtTheEnd(data);
    }

    SinglyLinkedListNode newNode = new SinglyLinkedListNode();
    newNode.data = data;
    int currentIndex = -1;

    SinglyLinkedListNode currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentIndex == wantedIndex - 1) break;

      currentNode = currentNode.nextNode;
      currentIndex++;
    }

    newNode.nextNode = currentNode.nextNode;
    currentNode.nextNode = newNode;

    return true;
  }


  public bool RemoveNodeAtIndex(int wantedIndex)
  {
    int currentIndex = -1;

    SinglyLinkedListNode currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentIndex == wantedIndex - 1) break;

      currentNode = currentNode.nextNode;
      currentIndex++;
    }


    currentNode.nextNode = currentNode.nextNode?.nextNode;

    return true;
  }

  public SinglyLinkedListNode GetNode(int wantedIndex)
  {

    int currentIndex = -1;

    SinglyLinkedListNode currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentIndex == wantedIndex) break;

      currentNode = currentNode.nextNode;
      currentIndex++;
    }


    return currentNode;
  }

  public int GetFirstNodeIndexIfExist(string wantedNodeData)
  {

    int currentIndex = -1;

    SinglyLinkedListNode currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentNode.data == wantedNodeData) return currentIndex;

      currentNode = currentNode.nextNode;
      currentIndex++;
    }

    return -1;
  }

  public bool IsEmpty()
  {
    return HEAD.nextNode == null;
  }

  public string Drop()
  {
    HEAD.nextNode = null;

    return "Linked list is empty now";
  }

  public void PrintAllNodes()
  {
    SinglyLinkedListNode? currentNode = HEAD;
    while (currentNode != null)
    {
      currentNode = currentNode.nextNode;

      if (currentNode == null) break;
      Console.WriteLine(currentNode.data);
    }
  }

  public int CountNodes()
  {
    SinglyLinkedListNode currentNode = HEAD;
    int count = 0;

    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      count++;
    }

    return count;
  }
}

