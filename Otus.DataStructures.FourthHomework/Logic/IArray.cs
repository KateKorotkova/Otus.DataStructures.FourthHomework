namespace Otus.DataStructures.FourthHomework.Logic
{
    interface IArray<T>
    {
        int GetSize();
        void Add(T item);
        T Get(int index);

        // HW
        // void Add(T item, int index); // with shift to tail
        // T remove(int index); // return deleted element
    }
}
