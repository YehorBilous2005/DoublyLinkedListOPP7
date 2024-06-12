public class Doubly_Linked_List
{
    public Doubly_Linked_List_Node? Head { get; private set; } 
    public Doubly_Linked_List_Node? Tail { get; private set; }
    public int Count { get; private set; }

    public Doubly_Linked_List()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }
    public Doubly_Linked_List(params double[] elements)
    {
        Count = 0;
        Tail = null;
        Head = null;
        AddArrayAfterTail(elements);
    }

    public void AddBeforeHead(double element)
    {
        var NewNode = new Doubly_Linked_List_Node(element);
        if (Head == null)
        {
            Head = NewNode;
            Tail = Head;
        }
        else
        {
            NewNode.Next = Head;
            Head.Previous = NewNode;
            Head = NewNode;
        }
        Count++;
    }
    public void AddAfterTail(double element)
    {
        var NewNode = new Doubly_Linked_List_Node(element);
        if (Tail == null)
        {
            Head = NewNode;
            Tail = Head;
        }
        else
        {
            Tail.Next = NewNode;
            NewNode.Previous = Tail;
            Tail = NewNode;
        }
        Count++;
    }

    public void AddArrayBeforeHead(params double[] elements)
    {
        for (int i = elements.Length - 1; i >= 0; i--)
        {
            AddBeforeHead(elements[i]);
        }
    }
    public void AddArrayAfterTail(params double[] elements)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            AddAfterTail(elements[i]);
        }
    }

    public string ShowList()
    {
        var node = Head;
        string list = "";
        while (node != null)
        {
            list += node.Key.ToString() + ' ';
            node = node.Next;
        }
        return list;
    }

    public double? FindFirstPositive()
    {
        var node = Head;
        while (node != null)
        {
            if (node.Key > 0)
            {
                return node.Key;
            }
            node = node.Next;
        }
        return null;
    }

    public double AverageValue()
    {
        var node = Head;
        double sum = 0;
        while (node != null)
        {
            sum += node.Key;
            node = node.Next;
        }
        return sum / Count;
    }

    public int NumberOfElementsIsLessThanAverage()
    {
        var node = Head;
        double average = AverageValue();
        int counter = 0;
        while (node != null)
        {
            if (node.Key < average)
            {
                counter++;
            }
            node = node.Next;
        }
        return counter;
    }

    public Doubly_Linked_List ListOfElementsThatAreGreaterThanAverage()
    {
        var node = Head;
        double average = AverageValue();
        var new_list = new Doubly_Linked_List();
        while (node != null)
        {
            if (node.Key > average)
            {
                new_list.AddAfterTail(node.Key);
            }
            node = node.Next;
        }
        return new_list;
    }

    public double FindMaxValue()
    {
        if (Head != null)
        {
            var node = Head;
            double max = Head.Key;
            while (node != null)
            {
                if (max < node.Key)
                {
                    max = node.Key;
                }
                node = node.Next;
            }
            return max;
        }
        else
        {
            throw new ArgumentNullException(nameof(Head));
        }
    }

    public void DeleteAllElementsBeforeMax()
    { 
        if (Count >= 2)
        {
            double max = FindMaxValue();
            while (Head != null && Head.Key != max)
            {
                Head.Next.Previous = null;
                Head = Head.Next;
            }
        }
    }
}