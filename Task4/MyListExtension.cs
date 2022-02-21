using System.Collections;
using System.Collections.Generic;

namespace Task4
{
    internal static class MyListExtension
    {
        public static T[] GetArray<T>(this IEnumerable list)
        {
            // Как тут можно обойтись без этого? Мы не знаем сколько элементов в list, как нам создать масси нужного размера?
            var result = new List<T>();
            foreach (T item in list)
            {
                result.Add(item);
            }
            return result.ToArray();
        }
    }
}
