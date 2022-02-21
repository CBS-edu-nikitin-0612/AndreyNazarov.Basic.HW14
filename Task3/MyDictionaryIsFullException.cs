using System;

namespace Task3
{
    internal class MyDictionaryIsFullException : Exception
    {
        public MyDictionaryIsFullException(string message) : base(message)
        {
        }
    }
}

