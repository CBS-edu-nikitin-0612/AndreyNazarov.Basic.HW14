using System;
using Task2;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var array = myList.GetArray<int>();

            Console.WriteLine(array[3]);
        }
    }
}
