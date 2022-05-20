using System;

namespace Otus.DataStructures.FourthHomework.Logic
{
    public class SingleArray<T> : IArray<T>
    {
        private object[] _array;

        public SingleArray()
        {
            _array = new object[0];
        }

        public int GetSize()
        {
            return _array.Length;
        }

        public void Add(T item)
        {
            resize();
            _array[GetSize() - 1] = item;
        }

        public T Get(int index)
        {
            return (T) _array[index];
        }

        private void resize()
        {
            var newArray = new object[GetSize() + 1];
            Array.Copy(_array, 0, newArray, 0, GetSize());
            //        for (int j = 0; j < GetSize(); j ++)
            //            newArray[j] = array[j];
            _array = newArray;
        }
    }
}
