using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var collection = GetCollection(array);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetCollection(int[] array)
        {
            foreach (var item in array)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }
    }
}
