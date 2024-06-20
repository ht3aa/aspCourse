namespace DAS;

class SinglyLinkedListNode<T>
{
  public T? data { get; set; }
  public SinglyLinkedListNode<T>? nextNode { get; set; }

  public SinglyLinkedListNode(T data = default(T)!)
  {
    this.data = data;
    this.nextNode = null;
  }
}

class SinglyLinkedList<T>
{
  public SinglyLinkedListNode<T> HEAD = new SinglyLinkedListNode<T>();
  public SinglyLinkedListNode<T> TAIL = new SinglyLinkedListNode<T>();
  public int nodesNumber = -1;


  public bool InsertNodeAtTheStart(T data)
  {
    SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(data);

    newNode.nextNode = HEAD;
    HEAD = newNode;

    nodesNumber++;

    return true;
  }


  public bool ReverseLinkedList()
  {

    SinglyLinkedListNode<T> currentNode = HEAD;
    SinglyLinkedListNode<T>? prevNode = null;
    SinglyLinkedListNode<T>? currentNextNode = null;


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
    SinglyLinkedListNode<T> currentNode = HEAD;

    if (currentNode.nextNode == null) throw new Exception("in SinglyLinkedList.RemoveFirstNode method the currentNode.nextNode is null");

    HEAD = currentNode.nextNode;

    nodesNumber--;
    return true;
  }

  public bool RemoveLastNode()
  {

    SinglyLinkedListNode<T> currentNode = HEAD;

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

    SinglyLinkedListNode<T> currentNode = HEAD;
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

    SinglyLinkedListNode<T> currentNode = HEAD;

    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      str = $"{str} {currentNode.data}";
    }

    return str;
  }

  public bool InsertNodeAtTheEnd(T data)
  {
    SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>();
    newNode.data = data;

    SinglyLinkedListNode<T> currentNode = HEAD;
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

    SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>();
    newNode.data = data;

    int currentIndex = -1;

    // nodeBeforeWantedIndex is the node before the wanted index node
    SinglyLinkedListNode<T> nodeBeforeWantedIndex = HEAD;
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
    SinglyLinkedListNode<T> nodeBeforeWantedIndex = HEAD;
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

  public SinglyLinkedListNode<T> GetNode(int wantedIndex)
  {

    int currentIndex = -1;

    SinglyLinkedListNode<T> currentNode = HEAD;
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

    SinglyLinkedListNode<T> currentNode = HEAD;
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
    SinglyLinkedListNode<T>? currentNode = HEAD;
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

