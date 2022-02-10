using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[5] { 5, 8, 9, 10, 12 };
            Mylist<int> mylist = new Mylist<int>();
            Console.Write("Ви хочете добавити масив в колекцію?");
            string answer = Console.ReadLine();
            if (answer == "так")
            {
                mylist.AddElement(massive);
                Console.WriteLine("Добавленно! ");
            }
            else
            {
                Console.WriteLine("Завершення");
            }
            Console.Write("\n");
            Console.Write("Ви хочете видалити число із колекції?");
            string answer1 = Console.ReadLine();
            if (answer == "так")
            {
                Console.Write("Введіть елемент..");
                int element = Convert.ToInt32(Console.ReadLine());
                mylist.RemoveElement(element);
            }
            else
            {
                Console.WriteLine("Завершення");
            }
            Console.Write("\n");

            Console.WriteLine($"Кількість елементів = {mylist.Count}");
            Console.Write("\n");
            mylist.MethodOut();
            Console.ReadKey();

        }
    }
    interface IInterface<T>
    {
        void AddElement(T[] arg1);
        void RemoveElement(T someArgument);
        int Count { get; }
    }
    class Mylist<T> : IInterface<T>
    {
        List<T> myList = new List<T>();
        public void AddElement(T[] arg1)
        {
            myList.AddRange(arg1);
        }
        public void RemoveElement(T someArgument)
        {
            myList.Remove(someArgument);
        }
        public void MethodOut()
        {
            foreach (var item in myList)
            {
                Console.WriteLine(item);
                Console.Write("\n");
            }
        }
        public int Count { get => myList.Count; }

    }

}