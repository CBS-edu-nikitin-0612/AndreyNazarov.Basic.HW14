using System.Collections;
using System.Collections.Generic;

namespace Task3
{
    internal class MyDictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        private int current = -1;
        private KeyValuePair<TKey, TValue>[] array;
        public MyDictionary()
        {
            array = new KeyValuePair<TKey, TValue>[5];
        }
        public int Count { get; private set; } = 0;
        public object Current => array[current];

        public TValue this[TKey index]
        {
            get
            {
                foreach (var item in array)
                {
                    if (Equals(item.Key, index))
                    {
                        return item.Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set
            {
                foreach (var item in array)
                {
                    if (Equals(item.Key, index))
                    {
                        item.Value = value;
                    }
                }
                throw new KeyNotFoundException();
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (Count >= array.Length)
                throw new MyDictionaryIsFullException("MyDictionary is full");
            array[Count] = new KeyValuePair<TKey, TValue> { Key = key, Value = value };
            Count++;
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (current < Count - 1)
            {
                current++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            current = -1;
        }
    }
}

