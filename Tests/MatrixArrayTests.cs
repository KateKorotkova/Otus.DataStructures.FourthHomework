using NUnit.Framework;
using Otus.DataStructures.FourthHomework.Logic;
using Otus.DataStructures.FourthHomework.Logic.Common;

namespace Tests
{
    public class MatrixArrayTests
    {
        [Test]
        public void Inserting_To_The_End()
        {
            var customArray = new MatrixArray<int>();
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
            var customArray = new MatrixArray<int>();
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
            var customArray = new MatrixArray<int>();
            FillArray(customArray);
            customArray.Add(3, 2);
            customArray.Add(4, 3);

            Assert.That(customArray.Get(0), Is.EqualTo(0));
            Assert.That(customArray.Get(1), Is.EqualTo(1));
            Assert.That(customArray.Get(2), Is.EqualTo(3));
            Assert.That(customArray.Get(3), Is.EqualTo(2));
            Assert.That(customArray.Get(4), Is.EqualTo(4));
        }

        [Test]
        public void Removing_From_The_End()
        {
            var customArray = new MatrixArray<int>();
            FillArray(customArray);

            var removedElement = customArray.Remove(2);

            Assert.That(removedElement, Is.EqualTo(2));
            Assert.That(customArray.Get(0), Is.EqualTo(0));
            Assert.That(customArray.Get(1), Is.EqualTo(1));
        }

        [Test]
        public void Removing_From_The_Middle()
        {
            var customArray = new MatrixArray<int>();
            FillArray(customArray);

            var removedElement = customArray.Remove(1);

            Assert.That(removedElement, Is.EqualTo(1));
            Assert.That(customArray.Get(0), Is.EqualTo(0));
            Assert.That(customArray.Get(2), Is.EqualTo(2));
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