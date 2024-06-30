namespace DAS;

public enum SortOrder
{
  Ascending = -1,
  Descending = 1,
}

class Stack<T> : HelpFullMethods
{
  private SinglyNode<T> TOPNODE = new SinglyNode<T>();
  private int nodesNumber = -1;


  public void Push(T value)
  {
    SinglyNode<T> newNode = new SinglyNode<T>();
    newNode.data = value;

    if (nodesNumber == -1)
    {
      TOPNODE = newNode;
    }
    else
    {
      newNode.nextNode = TOPNODE;
      TOPNODE = newNode;
    }

    nodesNumber++;
    return;
  }

  public void Pop()
  {
    if (TOPNODE.nextNode == null)
    {
      TOPNODE = new SinglyNode<T>();
      Console.WriteLine("stack is empty");
    }
    else
    {
      TOPNODE = TOPNODE.nextNode;
    }

    nodesNumber--;
    return;
  }


  public SinglyNode<T> GetTopNode()
  {
    return TOPNODE;
  }

  public string IsStackEmpty()
  {
    return nodesNumber == -1 ? "Stack is empty" : "Stack is not empty";
  }


  public void PrintNodesValue()
  {
    SinglyNode<T> currentNode = TOPNODE;

    while (currentNode.nextNode != null)
    {
      Console.WriteLine(currentNode.data);
      currentNode = currentNode.nextNode;
    }
    Console.WriteLine(currentNode.data);

  }


  private void UsingSelectionSort(SortOrder sortOrder)
  {

    SinglyNode<T> topNode = TOPNODE;
    SinglyNode<T> currentNode = TOPNODE;
    SinglyNode<T> highiestNode = new SinglyNode<T>();

    while (topNode != null)
    {
      highiestNode = topNode;
      currentNode = topNode;
      while (currentNode != null)
      {
        if (Comparer<T>.Default.Compare(currentNode.data, highiestNode.data) == (int) sortOrder)
        {
          highiestNode = currentNode;
        }
        currentNode = currentNode.nextNode;
      }
      Swap(ref topNode.data, ref highiestNode.data);
      topNode = topNode.nextNode;
    }

  }

  private void SortInAscendingOrder()
  {
    UsingSelectionSort(SortOrder.Ascending);
  }

  private void SortInDescendingOrder()
  {
    UsingSelectionSort(SortOrder.Descending);
  }

  public void Sort(bool sortInAscendingOrder = true)
  {
    if (sortInAscendingOrder)
      SortInAscendingOrder();
    else
      SortInDescendingOrder();
  }

}
