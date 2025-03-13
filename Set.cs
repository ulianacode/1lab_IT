using System;
using System.Collections.Generic;

namespace SetApp
{
    public class Set<T>
    {
        private HashSet<T> elements;

        public Set()
        {
            elements = new HashSet<T>();
        }

        public int Count => elements.Count;

        public bool IsEmpty => elements.Count == 0;

        public void Add(T element)
        {
            elements.Add(element);
        }

        public void Remove(T element)
        {
            elements.Remove(element);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public T[] ToArray()
        {
            T[] array = new T[elements.Count];
            elements.CopyTo(array);
            return array;
        }

        public bool Contains(T element)
        {
            return elements.Contains(element);
        }
    }
}
