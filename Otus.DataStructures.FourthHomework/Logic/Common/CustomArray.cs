namespace Otus.DataStructures.FourthHomework.Logic.Common
{
    public class CustomArray <T>
    {
        protected void AddItemWithShiftLeft(object[] arrayCopyTo, object[] arrayCopyFrom, T newItem, int index)
        {
            var arrayCopyFromCounter = 0;

            var upperBound = arrayCopyTo.Length == arrayCopyFrom.Length
                ? arrayCopyFrom.Length
                : arrayCopyFrom.Length + 1;

            for (var i = 0; i < upperBound; i++)
            {
                if (i == index) 
                    continue;

                arrayCopyTo[i] = arrayCopyFrom[arrayCopyFromCounter];
                arrayCopyFromCounter++;
            }

            arrayCopyTo[index] = newItem;
        }

        protected T RemoveItemWithShiftLeft(ref object[] array, int index)
        {
            var counter = 0;
            var newArray = new object[array.Length - 1];
            object removedElement = null;

            for (var i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    removedElement = array[i];
                }
                else
                {
                    newArray[counter] = array[i];
                    counter++;
                }
            }

            array = newArray;

            return (T) removedElement;
        }
    }
}
