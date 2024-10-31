using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> list = new GenericLinkedList<int>();
            Console.WriteLine("1-Add to first \t 2-Add to last \t 3-Add into \t 4-Remove from first \t 5-Remove from last \t 6-Remove \t 7-Print");
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                while (n < 0 || n > 7)
                {
                    Console.WriteLine("That's not an option");
                    n = int.Parse(Console.ReadLine());
                }
                switch (n)
                {
                    case 1:
                        Console.WriteLine("enter what do you want to add");
                        int number = int.Parse(Console.ReadLine());
                        list.AddFirst(number);
                        break;
                    case 2:
                        Console.WriteLine("enter what do you want to add");
                        number = int.Parse(Console.ReadLine());
                        list.AddLast(number);
                        break;
                    case 3:
                        Console.WriteLine("enter what do you want to add");
                        number = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the target");
                        int target = int.Parse(Console.ReadLine());
                        list.Add(number, target);
                        break;
                    case 4:
                        list.RemoveFirst();
                        break;
                    case 5:
                        list.RemoveLast();
                        break;
                    case 6:
                        Console.WriteLine("enter the value of the thing you want to Remove");
                        int value = int.Parse(Console.ReadLine());
                        list.Remove(value);
                        break;
                    case 7:
                        list.Print();
                        break;
                }
            }
        }
    }
}
