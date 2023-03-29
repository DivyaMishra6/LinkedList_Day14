using System.Collections.Generic;

namespace LinkedListDay14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist problem!");
            Console.WriteLine("**********************************");

            CheckSequenceUC2 list = new CheckSequenceUC2();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
