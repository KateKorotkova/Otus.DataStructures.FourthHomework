using Otus.DataStructures.FourthHomework.Logic.Common;

namespace Otus.DataStructures.FourthHomework.Logic
{
    public class MatrixArray<T> : IArray<T>
    {
        private int _size;
        private readonly int _vector;
        private readonly IArray<IArray<T>> _array;

        private bool IsSizeExceeded => _size == _array.GetSize() * _vector;


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
            if (IsSizeExceeded)
                _array.Add(new VectorArray<T>(_vector));

            var resultArray = GetInitialArray();
            resultArray.Add(item);
            
            _size++;
        }

        public void Add(T item, int index)
        {
            var resultIndex = GetResultIndex(index);

            if (IsSizeExceeded)
            {
                _array.Add(new VectorArray<T>(_vector));
                resultIndex = 0;
            }

            var resultArray = GetInitialArray();
            resultArray.Add(item, resultIndex);

            _size++;
        }

        public T Remove(int index)
        {
            var resultArray = GetInitialArray(index);
            var resultIndex = GetResultIndex(index);
            
            return resultArray.Remove(resultIndex);
        }

        public T Get(int index)
        {
            var resultArray = GetInitialArray(index);
            var resultIndex = GetResultIndex(index);
            
            return resultArray.Get(resultIndex);
        }


        #region Support Methods

        private IArray<T> GetInitialArray()
        {
            return _array.Get(_size / _vector);
        }

        private IArray<T> GetInitialArray(int index)
        {
            return _array.Get(index / _vector);
        }

        private int GetResultIndex(int index)
        {
            return index % _vector;
        }

        #endregion
    }
}
