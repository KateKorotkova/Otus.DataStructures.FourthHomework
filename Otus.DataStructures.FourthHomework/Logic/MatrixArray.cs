using System;
using Otus.DataStructures.FourthHomework.Logic.Common;

namespace Otus.DataStructures.FourthHomework.Logic
{
    public class MatrixArray<T> : IArray<T>
    {
        private int _size;
        private readonly int _vector;
        private IArray<IArray<T>> _array;

        public MatrixArray(int vector)
        {
            _vector = vector;
            _array = new SingleArray<IArray<T>>();
            _size = 0;
        }

        public MatrixArray() : this(2)
        {

        }

        public int GetSize()
        {
            return _size;
        }

        public void Add(T item)
        {
            if (_size == _array.GetSize() * _vector)
                _array.Add(new VectorArray<T>(_vector));

            _array.Get(_size / _vector).Add(item);
            
            _size++;
        }

        public void Add(T item, int index)
        {
            var resultIndex = index % _vector;

            if (_size == _array.GetSize() * _vector)
            {
                _array.Add(new VectorArray<T>(_vector));
                resultIndex = 0;
            }

            _array.Get(_size / _vector).Add(item, resultIndex);

            _size++;
        }

        public T Remove(int index)
        {
            throw new NotImplementedException();
        }

        public T Get(int index)
        {
            return _array.Get(index / _vector).Get(index % _vector);
        }
    }
}
