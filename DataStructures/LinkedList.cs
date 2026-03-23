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
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            if(index > count || index < 0)
            {
                throw new NullReferenceException();
            }
            Node? previous = null;
            Node? current = first;

            while(current != null)
            {

            }
        }

        public int Size()
        {
            return count;
        }

        //TODO
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
