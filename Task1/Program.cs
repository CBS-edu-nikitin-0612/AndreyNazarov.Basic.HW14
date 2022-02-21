using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
