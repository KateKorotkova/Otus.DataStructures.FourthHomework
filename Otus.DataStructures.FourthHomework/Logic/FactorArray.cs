using System;

namespace Otus.DataStructures.FourthHomework.Logic
{
    public class FactorArray<T> : IArray<T>
    {
        private object[] _array;
        private readonly int _factor;
        private int _size;

        public FactorArray(int factor, int initLength)
        {
            _factor = factor;
            _array = new object[initLength];
            _size = 0;
        }

        public FactorArray() : this(50, 10)
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
            Object[] newArray = new Object[_array.Length + _array.Length * _factor / 100];
            Array.Copy(_array, 0, newArray, 0, _array.Length);
            _array = newArray;
        }
    }
}
