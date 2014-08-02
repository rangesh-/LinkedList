using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l=new List<int>(){1,2,3,4,5};
            SinglyLinkedList<int> obj =new SinglyLinkedList<int>();

            Node N2=new Node(){Value = 2,NextPointer = null};
            Node n1 = new Node() {Value = 1, NextPointer = N2};
            Node n = n1;
            bool stop = true;
           

            foreach (int VARIABLE in l)
            {
               obj.AddToList(VARIABLE); 
            }
            obj.delete(2);
            obj.PrintList();
        }
    }

    public class SinglyLinkedList<T>
    {
        private Node Head;

        public void AddToList(T data)
        {
            if (Head == null)
            {
                Head =new Node {Value = data, NextPointer = null};
            }
            else
            {
                var nextNode = new Node { Value = data, NextPointer = null };
                nextNode.NextPointer = Head;
                Head = nextNode;

            }
        }

        public void AddToLast(T data)
        {
            if (Head == null)
            {
                Head = new Node { Value = data, NextPointer = null };
            }
            else
            {
                var NewNodeToAdd = new Node() {Value = data, NextPointer = null};
                Node Tempnode = Head;

                while (Tempnode.NextPointer!=null)
                {
                    Tempnode = Tempnode.NextPointer;
                }
                Tempnode.NextPointer = NewNodeToAdd;
            }
        }

        public void PrintList()
        {
            Node Current = Head;
            while (Current!=null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.NextPointer;
            }
        }

        public void removeduplicatesUnsortedList(SinglyLinkedList<T> list )
        {

        }

        public void delete(T data)
        {
            Node CurrentNode = Head;
            if (Head.Value.Equals(data))
            {
                Head = Head.NextPointer;
            }
            else
            {


                while (CurrentNode != null)
                {
                    if (data.Equals(CurrentNode.NextPointer.Value))
                    {
                        CurrentNode.NextPointer = CurrentNode.NextPointer.NextPointer;
                        break;
                    }

                    CurrentNode = CurrentNode.NextPointer;
                }

            }
        }

        public Node ReturnList()
        {
            return Head;
        }
    }

    public class Node
    {
        public Node NextPointer;
        public object Value;
    }

}
