// See https://aka.ms/new-console-template for more information
class Program
{
    static void  Main()
    {
        //Lists
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("List:");
        foreach (int i in list)
        {
            Console.WriteLine(i + " ");
            
        }
        Console.WriteLine();
        list.RemoveAt(0);
        list.RemoveAt(list.Count - 1);
        Console.WriteLine("List after removing the first and last elements:");
        foreach (int i in list)
        {
            Console.WriteLine(i + " ");
        }
        //Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "Alice", 10 },
            { "mateo", 20},
            { "Charlie", 30 },
            { "Fer", 40 },
            { "Davi", 50 }
        };
        Console.WriteLine("Student grades:");
        foreach (KeyValuePair<string, int> student in dictionary)
        {
            Console.WriteLine(student.Key + " " + student.Value);
        }

        dictionary["Charlie"] = 91;
        dictionary.Remove("Alice");
        Console.WriteLine("Student grades after the changes:");
        foreach (KeyValuePair<string, int> student in dictionary)
        {
            Console.WriteLine(student.Key + " " + student.Value);

        }
        //queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Alice");
        queue.Enqueue("mateo");
        queue.Enqueue("Charlie");
        queue.Enqueue("Fer");
        queue.Enqueue("Davi");

        Console.WriteLine("Queue customers:");
        foreach (string customer in queue)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine("Queue customers after removing the first customer:");
        queue.Dequeue();
        foreach (string customer in queue)
        {
            Console.WriteLine(customer);
        }
        //stacks
        Stack<string> books = new Stack<string>();
        books.Push("book1");
        books.Push("book2");
        books.Push("book3");

        Console.WriteLine("Books in the stack:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }


    }
}

