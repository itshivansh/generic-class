using System;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public int Count { get; set; }
        List<T> list = new List<T>();

        public void AddFirst(T obj)
        {
            list.Insert(0, obj);
            Count = list.Count;
        }
        public void AddLast(T objct)
        {
            list.Add(objct);
            Count = list.Count;
        }
        public void RemoveFirst()
        {
            list.RemoveAt(0);
            Count--;
        }
        public void RemoveLast()
        {
            list.RemoveAt(Count - 1);
            Count--;
        }
    }
        class Program
        {
            public static void Main(string[] args)
            {
                DoublyLinkedList<object> doublyLinkedList = new DoublyLinkedList<object>();
                doublyLinkedList.AddFirst("shivansh");
                doublyLinkedList.AddLast("Tiwari");
                doublyLinkedList.RemoveFirst();
                doublyLinkedList.RemoveLast();
            }
        }
    
}
