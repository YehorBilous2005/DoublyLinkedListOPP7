internal class Program
{
    public static void Main()
    {
        double[] array = [-1, -2, -3, -4, -5, -6, -7, -8, -9, -10];

        var list = new Doubly_Linked_List(array);
        Console.WriteLine(list.ShowList());
        list.AddBeforeHead(-2);
        list.AddAfterTail(0);
        Console.WriteLine(list.ShowList());
        list.AddArrayBeforeHead(-2, -3, -4, -123);
        list.AddArrayAfterTail(-1000, 123, -124);
        Console.WriteLine(list.ShowList());
        Console.WriteLine(list.FindFirstPositive());
        Console.WriteLine("{0:F4}", list.AverageValue());
        Console.WriteLine(list.NumberOfElementsIsLessThanAverage());


        var list2 = list.ListOfElementsThatAreGreaterThanAverage();
        Console.WriteLine(list2.ShowList());
        Console.WriteLine(list2.FindMaxValue());
        list2.AddArrayAfterTail(1, 2, 3, 4);
        list2.DeleteAllElementsBeforeMax();
        Console.WriteLine(list2.ShowList());

        /*var list3 = new Doubly_Linked_List();
        list2.AddArrayBeforeHead(2, 5, 1, 89, 123, 120304);
        Console.WriteLine(list2.ShowList());*/
    }
}