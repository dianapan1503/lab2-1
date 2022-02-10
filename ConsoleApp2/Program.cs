using System;
using System.Collections.Generic;

namespace ConsoleApp2
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            try
            {
                Console.WriteLine("Введіть перший ключ: ");
                int key1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть перше значення: ");
                string value1 = Console.ReadLine();
                Console.Write("\n");
                Console.WriteLine("Введіть другий ключ: ");
                int key2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть друге значення: ");
                string value2 = Console.ReadLine();

                myDictionary.Add(key1, value1, key2, value2);
                Console.Write("\n");
                myDictionary.Method();
                Console.Write("\n");
                Console.WriteLine($"Кількість елементів колекції = {myDictionary.Count}");
            }
            catch
            {
                Console.WriteLine("Помилка вводу даних...");
            }
            Console.ReadLine();
        }
    }
    class MyDictionary<TKey, TValue>
    {
        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();
        public void Add(TKey arg1, TValue arg2, TKey arg3, TValue arg4)
        {
            dict.Add(arg1, arg2);
            dict.Add(arg3, arg4);
        }

        public int Count { get => dict.Count; }

        public void Method()
        {
            foreach (KeyValuePair<TKey, TValue> keyValuePair in dict)
            {
                Console.WriteLine(keyValuePair.Key + "-" + keyValuePair.Value);
            }
        }
    }
}