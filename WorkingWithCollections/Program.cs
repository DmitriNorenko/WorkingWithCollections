using System.Diagnostics;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch1 = Stopwatch.StartNew();
            List.ReadList();
            Console.WriteLine("\n Время: " + stopWatch1.Elapsed.TotalMilliseconds);
            Console.ReadKey();
            var stopWatch2 = Stopwatch.StartNew();
            LinkedList.ReadLinkedList();
            Console.WriteLine("\n Время: " + stopWatch2.Elapsed.TotalMilliseconds);
            Console.ReadKey();
            List.SearchWord();
            Console.ReadKey();
        }
    }
}