using System;
using Otus.DataStructures.FourthHomework.Logic;

namespace Otus.DataStructures.FourthHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleArray = new SingleArray<DateTime>();
            var vectorArray = new FactorArray<DateTime>();
            var factorArray = new FactorArray<DateTime>();
            var matrixArray = new MatrixArray<DateTime>();

            TestAddArray(singleArray, 10_000);
            TestAddArray(vectorArray, 100_000);
            TestAddArray(factorArray, 100_000);
            TestAddArray(matrixArray, 100_000);
        }

        private static void TestAddArray(IArray<DateTime> data, int total)
        {
            var start = DateTime.Now.Ticks;

            for (var j = 0; j < total; j++)
                data.Add(new DateTime());

            Console.WriteLine(data + " TestAddArray: " + (DateTime.Now.Ticks - start));
        }
    }
}
