public class Doubly_Linked_List_Node
{
    public double Key { get; set; }
    public Doubly_Linked_List_Node? Next { get; set; }
    public Doubly_Linked_List_Node? Previous { get; set; }
    
    public Doubly_Linked_List_Node(double element)
    {
        Key = element;
        Next = null;
        Previous = null;
    }
    ~Doubly_Linked_List_Node()
    {
        Console.WriteLine("Node is cleaned");
    }
}