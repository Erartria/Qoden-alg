using System;
using System.Collections;

namespace task1
{
    public class Array<T>
    {
        public T[] objects { get; private set; }
        public Array(int length)
        {
            this.objects = new T[length];
        }
    }
}