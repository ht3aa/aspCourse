namespace DAS;

class SinglyNode<T>
{
  public T? data;
  public SinglyNode<T>? nextNode;

}

class SinglyLinkedList<T>
{
  public SinglyNode<T> HEAD = new SinglyNode<T>();
  public SinglyNode<T> TAIL = new SinglyNode<T>();
  public int nodesNumber = -1;


  public bool InsertNodeAtTheStart(T data)
  {
    SinglyNode<T> newNode = new SinglyNode<T>();

    newNode.nextNode = HEAD;
    HEAD = newNode;

    nodesNumber++;

    return true;
  }


  public bool ReverseLinkedList()
  {

    SinglyNode<T> currentNode = HEAD;
    SinglyNode<T>? prevNode = null;
    SinglyNode<T>? currentNextNode = null;


    while (currentNode.nextNode != null)
    {
      currentNextNode = currentNode.nextNode;
      currentNode.nextNode = prevNode;
      prevNode = currentNode;
      currentNode = currentNextNode;
    }

    currentNode.nextNode = prevNode;
    TAIL = HEAD;
    HEAD = currentNode;

    return true;
  }

  public bool RemoveFirstNode()
  {
    SinglyNode<T> currentNode = HEAD;

    if (currentNode.nextNode == null) throw new Exception("in SinglyLinkedList.RemoveFirstNode method the currentNode.nextNode is null");

    HEAD = currentNode.nextNode;

    nodesNumber--;
    return true;
  }

  public bool RemoveLastNode()
  {

    SinglyNode<T> currentNode = HEAD;

    while (currentNode.nextNode?.nextNode != null)
    {
      currentNode = currentNode.nextNode;
    }

    TAIL = currentNode;
    currentNode.nextNode = null;

    nodesNumber--;
    return true;
  }

  public T[] ConvertToArray()
  {
    T[] arr = new T[nodesNumber];

    SinglyNode<T> currentNode = HEAD;
    int index = -1;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;

      if (currentNode.data == null) throw new Exception("in SinglyLinkedList.ConvertToArray method the currentNode.data is null");
      arr[index] = currentNode.data;
    }

    return arr;
  }

  public string ConvertToString()
  {
    string str = "";

    SinglyNode<T> currentNode = HEAD;

    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      str = $"{str} {currentNode.data}";
    }

    return str;
  }

  public bool InsertNodeAtTheEnd(T data)
  {
    SinglyNode<T> newNode = new SinglyNode<T>();
    newNode.data = data;

    SinglyNode<T> currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
    }

    if (nodesNumber == 0)
    {
      HEAD = newNode;
      TAIL = newNode;
    }
    else
    {
      currentNode.nextNode = newNode;
      TAIL = newNode;
    }

    nodesNumber++;
    return true;
  }

  public bool InsertNodeAtIndex(T data, int wantedIndex)
  {
    if (wantedIndex >= nodesNumber)
    {
      return InsertNodeAtTheEnd(data);
    }
    else if (wantedIndex == 0)
    {
      return InsertNodeAtTheStart(data);
    }

    SinglyNode<T> newNode = new SinglyNode<T>();
    newNode.data = data;

    int currentIndex = -1;

    // nodeBeforeWantedIndex is the node before the wanted index node
    SinglyNode<T> nodeBeforeWantedIndex = HEAD;
    while (nodeBeforeWantedIndex.nextNode != null)
    {
      if (currentIndex == wantedIndex - 1) break;

      nodeBeforeWantedIndex = nodeBeforeWantedIndex.nextNode;
      currentIndex++;
    }

    newNode.nextNode = nodeBeforeWantedIndex.nextNode;
    nodeBeforeWantedIndex.nextNode = newNode;

    nodesNumber++;
    return true;
  }


  public bool RemoveNodeAtIndex(int wantedIndex)
  {
    if (wantedIndex >= nodesNumber)
    {
      return RemoveLastNode();
    }
    else if (wantedIndex == 0)
    {
      return RemoveFirstNode();
    }

    int currentIndex = -1;

    // nodeBeforeWantedIndex is the node before the wanted index node
    SinglyNode<T> nodeBeforeWantedIndex = HEAD;
    while (nodeBeforeWantedIndex.nextNode != null)
    {
      if (currentIndex == wantedIndex - 1) break;

      nodeBeforeWantedIndex = nodeBeforeWantedIndex.nextNode;
      currentIndex++;
    }


    nodeBeforeWantedIndex.nextNode = nodeBeforeWantedIndex.nextNode?.nextNode;
    nodesNumber--;

    return true;
  }

  public SinglyNode<T> GetNode(int wantedIndex)
  {

    int currentIndex = -1;

    SinglyNode<T> currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentIndex == wantedIndex) break;

      currentNode = currentNode.nextNode;
      currentIndex++;
    }


    return currentNode;
  }

  public int GetFirstNodeIndexIfExist(T wantedNodeData)
  {

    int currentIndex = -1;

    SinglyNode<T> currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentNode.data == null) throw new Exception("in SinglyLinkedList.GetFirstNodeIndexIfExist method the currentNode.data is null");

      if (currentNode.data.Equals(wantedNodeData)) return currentIndex;

      currentNode = currentNode.nextNode;
      currentIndex++;
    }

    return -1;
  }

  public bool IsEmpty()
  {
    return HEAD.nextNode == null || nodesNumber == -1;
  }

  public string Drop()
  {
    HEAD.nextNode = null;
    HEAD.data = default;
    nodesNumber++;

    return "Linked list is empty now";
  }

  public void PrintAllNodes()
  {
    SinglyNode<T>? currentNode = HEAD;
    while (currentNode != null)
    {
      Console.WriteLine(currentNode.data);
      currentNode = currentNode.nextNode;
    }
  }

  public int CountNodes()
  {
    return nodesNumber;
  }
}

