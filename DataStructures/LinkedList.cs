using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSmara.DataStructures.LinkedList
{
    public class LinkedList<T> : IList<T>
    {
        public Node? first;
        public int count;

        public int Add(T element)
        {
            if(first == null)
            {
                first = new Node(element);
                return count++;
            }
            Node current = first;
            while(current.next != null)
            {
                current = current.next;
            }

            current.SetNext(new Node(element));

            return count++;
        }
        public void Clear()
        {
            count = 0;
            first = null;
        }

        public int Find(T element)
        {
            if (first == null || count == 0)
            {
                throw new NullReferenceException();
            }
            int counter = 0;
            Node current = first;
            while(current.next != null)
            {
                if (current.value!.Equals(element))
                {
                    break;
                }
                current = current.next;
                counter++;
               
            }
            return counter;
        }

        public int Find(T element, int startAt)
        {
            if (first == null || count == 0)
            {
                throw new NullReferenceException();
            }
            Node current = first;
            while (current.next != null)
            {
                if (current.value!.Equals(element))
                {
                    break;
                }
                current = current.next;
                startAt++;

            }
            return startAt + 1;
        }

        public T Get(int index)
        {
            if (first == null || count == 0 || index > count)
            {
                throw new NullReferenceException();
            }

            Node? current = first;
            for(int i = 0; i < index; i++)
            {
                current = current.next!;
            }
            return current.value;
        }

        public void Insert(T element, int index)
        {
            if (index >= count || index < 0)
            {
                throw new NullReferenceException();
            }

            Node? previous = null;
            Node? nodeToAdd = new Node(element);
            Node? current = first;

            if (index == 0)
            {
                first = nodeToAdd;
                count++;
                return;
            }

        
            int counter = 0;

            while (current != null)
            {
                previous = current;
                current = current.next;
                counter++;

                if (counter == index)
                {
                    nodeToAdd.next = current;
                    previous.next = nodeToAdd;
                    count++;
                    return;
                }

            }
        }

        public void Remove(int index)
        {
            if(index >= count || index < 0)
            {
                throw new NullReferenceException();
            }

            if(index == 0)
            {
                first = first?.next;
                count--;
                return;
            }

            Node? previous = null;
            Node? current = first;
            int counter = 0;

            while(current != null)
            {
                previous = current;
                current = current.next;
                counter++;

                if(counter == index)
                {
                    previous.next = current?.next;
                    count--;
                    return;
                }
            }
        }

        public int Size()
        {
            return count;
        }

        public void ShowAllNodes()
        {
            Console.WriteLine("Node Value Links :");
            Console.WriteLine(first.value);
            Node current = first;
            while(current.next != null)
            {
                current = current.next;
                Console.WriteLine(current.value);
            }

        }

        public class Node
        {
            public T value;
            public Node? next;

            public Node(T value,Node next = null)
            {
                this.next = next;
                this.value = value;
            }

            public void SetValue(T value)
            {
                this.value = value;
            }

            public void SetNext(Node next)
            {
                this.next = next;
            }
        }
    }
}
