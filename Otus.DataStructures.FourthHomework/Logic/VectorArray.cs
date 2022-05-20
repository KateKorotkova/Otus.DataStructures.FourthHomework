using System;

namespace Otus.DataStructures.FourthHomework.Logic
{
    public class VectorArray<T> : IArray<T>
    {
        private object[] _array;
        private readonly int _vector;
        private int _size;

        public VectorArray(int vector)
        {
            _vector = vector;
            _array = new object[0];
            _size = 0;
        }

        public VectorArray() : this(10)
        {
        }

        public int GetSize()
        {
            return _size;
        }

        public void Add(T item)
        {
            if (GetSize() == _array.Length)
                resize();
            _array[_size] = item;
            _size++;
        }

        public T Get(int index)
        {
            return (T) _array[index];
        }

        private void resize()
        {
            var newArray = new object[_array.Length + _vector];

            Array.Copy(_array, 0, newArray, 0, _array.Length);
            
            _array = newArray;
        }
    }
}
