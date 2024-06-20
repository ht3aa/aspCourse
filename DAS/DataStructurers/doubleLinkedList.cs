namespace DAS;

class DoublyLinkedListNode<T>
{
  public T? data { get; set; }
  public DoublyLinkedListNode<T>? nextNode { get; set; }
  public DoublyLinkedListNode<T>? prevNode { get; set; }

  public DoublyLinkedListNode(T data = default(T)!)
  {
    this.data = data;
    this.nextNode = null;
    this.prevNode = null;
  }
}


class DoublyLinkedList<T>
{

  public DoublyLinkedListNode<T> HEAD = new DoublyLinkedListNode<T>();
  public DoublyLinkedListNode<T> TAIL = new DoublyLinkedListNode<T>();
  public int nodesNumber = -1;



  public bool InsertNodeAtTheStart(T data)
  {
    DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(data);

    newNode.nextNode = HEAD;
    HEAD.prevNode = newNode;
    HEAD = newNode;

    nodesNumber++;

    return true;
  }


  public bool RemoveFirstNode()
  {
    DoublyLinkedListNode<T> currentNode = HEAD;

    if (currentNode.nextNode == null) throw new Exception("in DoublyLinkedList.RemoveFirstNode method the currentNode.nextNode is null");
    HEAD = currentNode.nextNode;

    nodesNumber--;
    return true;
  }

  public bool RemoveLastNode()
  {

    DoublyLinkedListNode<T> currentNode = HEAD;

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

    DoublyLinkedListNode<T> currentNode = HEAD;
    int index = -1;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      if (currentNode.data == null) throw new Exception("in DoublyLinkedList.ConvertToArray method the currentNode.data is null");
      arr[index] = currentNode.data;
    }

    return arr;
  }

  public string ConvertToString()
  {
    string str = "";

    DoublyLinkedListNode<T> currentNode = HEAD;

    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
      str = $"{str} {currentNode.data}";
    }

    return str;
  }

  public bool InsertNodeAtTheEnd(T data)
  {
    DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>();
    newNode.data = data;

    DoublyLinkedListNode<T> currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      currentNode = currentNode.nextNode;
    }

    if (nodesNumber == -1)
    {
      HEAD = newNode;
      TAIL = newNode;
    }
    else
    {
      currentNode.nextNode = newNode;
      newNode.prevNode = currentNode;
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
    DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>();
    newNode.data = data;
    int currentIndex = -1;

    // nodeBeforeWantedIndex is the node before the wanted index node
    DoublyLinkedListNode<T> nodeBeforeWantedIndex = HEAD;
    while (nodeBeforeWantedIndex.nextNode != null)
    {
      if (currentIndex == wantedIndex - 1) break;

      nodeBeforeWantedIndex = nodeBeforeWantedIndex.nextNode;
      currentIndex++;
    }

    newNode.nextNode = nodeBeforeWantedIndex.nextNode;
    if (nodeBeforeWantedIndex.nextNode == null) throw new Exception("in DoublyLinkedList.InsertNodeAtIndex method the nodeBeforeWantedIndex.nextNode is null");
    nodeBeforeWantedIndex.nextNode.prevNode = newNode;
    nodeBeforeWantedIndex.nextNode = newNode;
    newNode.prevNode = nodeBeforeWantedIndex;

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
    DoublyLinkedListNode<T> nodeBeforeWantedIndex = HEAD;
    while (nodeBeforeWantedIndex.nextNode != null)
    {
      if (currentIndex == wantedIndex - 1) break;

      nodeBeforeWantedIndex = nodeBeforeWantedIndex.nextNode;
      currentIndex++;
    }

    if (nodeBeforeWantedIndex.nextNode == null || nodeBeforeWantedIndex.nextNode.nextNode == null) throw new Exception("in DoublyLinkedList.RemoveNodeAtIndex method the nodeBeforeWantedIndex.nextNode or  nodeBeforeWantedIndex.nextNode.nextNode is null");
    nodeBeforeWantedIndex.nextNode.nextNode.prevNode = nodeBeforeWantedIndex;
    nodeBeforeWantedIndex.nextNode = nodeBeforeWantedIndex.nextNode?.nextNode;

    nodesNumber--;

    return true;
  }

  public DoublyLinkedListNode<T> GetNode(int wantedIndex)
  {

    int currentIndex = -1;

    DoublyLinkedListNode<T> currentNode = HEAD;
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

    DoublyLinkedListNode<T> currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      if (currentNode.data == null) throw new Exception("in DoublyLinkedList.GetFirstNodeIndexIfExist method the currentNode.data is null");
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
    DoublyLinkedListNode<T>? currentNode = HEAD;
    while (currentNode.nextNode != null)
    {
      Console.WriteLine(currentNode.data);
      currentNode = currentNode.nextNode;
    }
    Console.WriteLine(currentNode.data);

    while (currentNode.prevNode != null)
    {

      Console.WriteLine(currentNode.data);
      currentNode = currentNode.prevNode;
    }
    Console.WriteLine(currentNode.data);
  }

  public int CountNodes()
  {
    return nodesNumber;
  }

}
