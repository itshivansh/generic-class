using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericEx
{
    public class MyStack<T>
    {
        public int Count { get; set; }
        List<T> list = new List<T>();
        public void Push(T obj)
        {
            list.Add(obj);
            Count = list.Count;
        }
        public T Pop()
        {
            T element = list[0];
            list.Remove(list[0]);
            Count = list.Count;
            return element;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<object> myStack = new MyStack<object>();
            myStack.Push("shivansh");
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Count);
        }
    }
}
