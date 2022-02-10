using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vars = MyClass<bool>.FactoryMethod();
            Console.WriteLine(vars.Item1.GetType().Name);
            Console.WriteLine(vars.Item2.GetType().Name);
            Console.ReadKey();
        }
    }
    class MyClass<T>
    where T : new()
    {
        public static (T, T) FactoryMethod()
        {
            return (new T(), new T());
        }
    }

}