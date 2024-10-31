using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }
    }
    internal class GenericLinkedList<T>
    {
        public int cnt = 0;
        Node<T> First;
        Node<T> Last;
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>();
            if (First == null)
            {
                Console.WriteLine("Created a Node");
                First = Last = node;
                node.data = data;
                cnt++;
                return;
            }
            node.next = First;
            First = node;
            cnt++;
            node.data = data;
            Console.WriteLine("Added node successfully");
        }
        public void AddLast(T data)
        {
            Node<T> node = new Node<T>();
            if (First == null)
            {
                AddFirst(data);
                return;
            }
            Last.next = node;
            Last = node;
            Console.WriteLine("Added node successfully");
            cnt++;
            node.data = data;
        }
        public void Add(T data, int target)
        {
            Node<T> node = new Node<T>();
            if (target < 0 || target > cnt)
            {
                Console.WriteLine("the target bigger than or smaller than the list, try again");
                return;
            }
            if (First == null)
            {
                AddFirst(data);
                return;
            }
            if (target == cnt)
            {
                AddLast(data);
                return;
            }
            Node<T> temp = new Node<T>();
            temp = First;
            while (temp.next != Last)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            node.data = data;
            cnt++;
            Console.WriteLine("added successfully!");
        }

        public void RemoveFirst()
        {
            if (First == null) { Console.WriteLine("it doesn't have any nodes"); return; }
            First = First.next;
            cnt--;
            Console.WriteLine("Removed successfully!");
        }
        public void RemoveLast()
        {
            if (First == null) { Console.WriteLine("it doesn't have any nodes"); return; }
            Node<T> temp = new Node<T>();
            temp = First;
            while (temp.next != Last)
            {
                temp = temp.next;
            }
            Last = temp;
            cnt--;
            Console.WriteLine("Removed from last successfully!");
        }

        public void Remove(T value)
        {
            if (First == null) { Console.WriteLine("it doesn't have any nodes"); return; }
            if (First.data.Equals(value))
            { RemoveFirst(); return; }
            Node<T> temp = First;
            while (temp != null && !temp.next.data.Equals(value))
            {
                temp = temp.next;
            }
            if (temp.next == null) { Console.WriteLine("value not found"); return; }
            temp.next = temp.next.next;
            if (temp.next == null) Last = temp;
            Console.WriteLine("Removed successfully!");
        }

        public void Print()
        {
            if (First == null)
            {
                Console.WriteLine("nothing to print");
                return;
            }
            Node<T> temp = First;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
