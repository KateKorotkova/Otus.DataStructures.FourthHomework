namespace Otus.DataStructures.FourthHomework.Logic
{
    public interface IArray<T>
    {
        int GetSize();
        void Add(T item);
        T Get(int index);

        //HW
        void Add(T item, int index);
        T Remove(int index);
    }
}
