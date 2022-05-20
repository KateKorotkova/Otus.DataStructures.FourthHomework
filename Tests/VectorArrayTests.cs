using NUnit.Framework;
using Otus.DataStructures.FourthHomework.Logic;

namespace Tests
{
    public class VectorArrayTests
    {
        [Test]
        public void Inserting_To_The_End()
        {
            var customArray = new VectorArray<int>();
            FillArray(customArray);
            customArray.Add(3, 3);

            Assert.That(customArray.Get(0), Is.EqualTo(0));
            Assert.That(customArray.Get(1), Is.EqualTo(1));
            Assert.That(customArray.Get(2), Is.EqualTo(2));
            Assert.That(customArray.Get(3), Is.EqualTo(3));
        }

        [Test]
        public void Inserting_In_The_Middle()
        {
            var customArray = new VectorArray<int>();
            FillArray(customArray);
            customArray.Add(3, 2);

            Assert.That(customArray.Get(0), Is.EqualTo(0));
            Assert.That(customArray.Get(1), Is.EqualTo(1));
            Assert.That(customArray.Get(2), Is.EqualTo(3));
            Assert.That(customArray.Get(3), Is.EqualTo(2));
        }

        [Test]
        public void Inserting_With_Resizing()
        {
            var customArray = new VectorArray<int>();
            FillArray(customArray);
            customArray.Add(3, 2);
            customArray.Add(4, 3);

            Assert.That(customArray.Get(0), Is.EqualTo(0));
            Assert.That(customArray.Get(1), Is.EqualTo(1));
            Assert.That(customArray.Get(2), Is.EqualTo(3));
            Assert.That(customArray.Get(3), Is.EqualTo(4));
            Assert.That(customArray.Get(4), Is.EqualTo(2));
        }


        #region Helpers

        private static void FillArray(IArray<int> customArray)
        {
            customArray.Add(0);
            customArray.Add(1);
            customArray.Add(2);
        }

        #endregion
    }
}