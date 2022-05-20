namespace Otus.DataStructures.FourthHomework.Logic
{
    public class CustomArray <T>
    {
        protected void ShiftLeft(object[] arrayCopyTo, object[] arrayCopyFrom, T newItem, int index)
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
    }
}
