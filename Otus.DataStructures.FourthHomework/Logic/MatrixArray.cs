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

        public MatrixArray() : this(10)
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

        public T Get(int index)
        {
            return _array.Get(index / _vector).Get(index % _vector);
        }
    }
}
