using System;
using Otus.DataStructures.FourthHomework.Logic.Common;

namespace Otus.DataStructures.FourthHomework.Logic
{
    public class FactorArray<T> : CustomArray<T>, IArray<T>
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

        public FactorArray() : this(2, 2)
        {
        }


        public int GetSize()
        {
            return _size;
        }

        public void Add(T item)
        {
            if (GetSize() == _array.Length)
                Resize();

            _array[_size] = item;
            _size++;
        }

        public void Add(T item, int index)
        {
            if (GetSize() == _array.Length)
            {
                var newArray = new object[_array.Length * _factor];

                AddItemWithShiftLeft(newArray, _array, item, index);

                _array = newArray;
            }
            else
            {
                AddItemWithShiftLeft(_array, _array, item, index);
            }

            _size++;
        }

        public T Remove(int index)
        {
            return RemoveItemWithShiftLeft(ref _array, index);
        }

        public T Get(int index)
        {
            return (T) _array[index];
        }


        #region Support Methods

        private void Resize()
        {
            var newArray = new object[_array.Length * _factor];
            Array.Copy(_array, 0, newArray, 0, _array.Length);
            _array = newArray;
        }

        #endregion
    }
}
