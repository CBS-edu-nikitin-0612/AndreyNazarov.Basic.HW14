using System.Collections;

namespace Task2
{
    public class MyList<T> : IEnumerable, IEnumerator
    {
        private T[] array;
        private int current = -1;
        public MyList()
        {
            array = new T[10];
        }

        public int Count { get; private set; } = 0;

        object IEnumerator.Current => array[current];

        public void Add(T item)
        {
            array[Count] = item;
            Count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            if (current < Count - 1)
            {
                current++;
                return true;
            }
            ((IEnumerator)this).Reset();
            return false;
        }

        void IEnumerator.Reset()
        {
            current = -1;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
