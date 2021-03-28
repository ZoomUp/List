using List;
using NUnit.Framework;

namespace ArrayListTests2
{
    public class Tests
    {
        [TestCase(5, new int[] { -10, -6, 1 }, new int[] { -10, -6, 1, 5 })]
        [TestCase(5, new int[] { }, new int[] { 5 })]
        [TestCase(5, new int[] { -10 }, new int[] { -10, 5 })]

        public void Add_Test(int value, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.Add(value);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { -10, -6, 1 }, new int[] { 5, -10, -6, 1 })]
        [TestCase(5, new int[] { }, new int[] { 5 })]
        [TestCase(5, new int[] { -10 }, new int[] { 5, -10 })]

        public void AddToTheBeginning_Test(int value, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddToTheBeginning(value);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 5, -10, -6, 1 }, new int[] { 5, -10, -6 })]
        [TestCase(2, new int[] { 5, -10, -6, 1 }, new int[] { 5, -10 })]
        [TestCase(4, new int[] { 5, -10, -6, 1 }, new int[] { })]

        public void RemoveFromTheEnd_Test(int amount, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFromTheEnd(amount);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 5, -10, -6, 1 }, new int[] { -10, -6, 1 })]
        [TestCase(2, new int[] { 5, -10, -6, 1 }, new int[] { -6, 1 })]
        [TestCase(4, new int[] { 5, -10, -6, 1 }, new int[] { })]

        public void RemoveFromTheBeginning_Test(int amount, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveFromTheBeginning(amount);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, new int[] { 5, -10, -6, 1 }, new int[] { -10, -6, 1 })]
        [TestCase(1, 2, new int[] { 5, -10, -6, 1 }, new int[] { 5, 1 })]
        [TestCase(0, 4, new int[] { 5, -10, -6, 1 }, new int[] { })]

        public void RemoveByIndex_Test(int index, int amount, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.RemoveByIndex(index, amount);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 5, -10, -6, 1 }, 0)]
        [TestCase(-10, new int[] { 5, -10, -6, 1 }, 1)]
        [TestCase(1, new int[] { 5, -10, -6, 1 }, 3)]

        public void GetIndexByValue_Test(int value, int[] array, int expected)
        {
            ArrayList actualArr = new ArrayList(array);
            int actual = actualArr.GetIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, -10, -6, 1 }, new int[] { 1, -6, -10, 5 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 7, -3 }, new int[] { -3, 7 })]
        [TestCase(new int[] { }, new int[] { })]

        public void ReversList_Test(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.ReversList();
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, -10, -6, 1 }, 5)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 7, -3 }, 7)]

        public void GetMaxElement_Test(int[] array, int expected)
        {
            ArrayList actualArr = new ArrayList(array);
            int actual = actualArr.GetMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, -10, -6, 1 }, -10)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 7, -3 }, -3)]

        public void GetMinElement_Test(int[] array, int expected)
        {
            ArrayList actualArr = new ArrayList(array);
            int actual = actualArr.GetMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, -10, -6, 1 }, 0)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 7, -3 }, 0)]

        public void GetIndexOfMaxElement_Test(int[] array, int expected)
        {
            ArrayList actualArr = new ArrayList(array);
            int actual = actualArr.GetIndexOfMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, -10, -6, 1 }, 1)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { 7, -3 }, 1)]

        public void GetIndexOfMinElement_Test(int[] array, int expected)
        {
            ArrayList actualArr = new ArrayList(array);
            int actual = actualArr.GetIndexOfMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, -6, 5, -10 }, new int[] { -10, -6, 1, 5 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void AscendingSort_Test(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.AscendingSort();
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, -6, 5, -10 }, new int[] { 5, 1, -6, -10 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        public void DescendingSort_Test(int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            actual.DescendingSort();
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, -6, 5, -10 }, -6, new int[] { 1, 5, -10 }, 1)]
        [TestCase(new int[] { 1, -6, 1, -10 }, 1, new int[] { -6, 1, -10 }, 0)]
        [TestCase(new int[] { }, 6, new int[] { }, -1)]
        [TestCase(new int[] { 1 }, 5, new int[] { 1 }, -1)]
        public void RemoveFirstByValue_Test(int[] array, int value, int[] expectedArray, int expectedIndex)
        {
            ArrayList actual = new ArrayList(array);
            int actualIndex;
            actualIndex = actual.RemoveFirstByValue(value);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(new int[] { 1, -6, 5, -10 }, -6, new int[] { 1, 5, -10 }, 1)]
        [TestCase(new int[] { 1, -6, 1, -10 }, 1, new int[] { -6, -10 }, 2)]
        [TestCase(new int[] { }, 6, new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 5, new int[] { 1 }, 0)]
        public void RemoveAllByValue_Test(int[] array, int value, int[] expectedArray, int expectedCount)
        {
            ArrayList actual = new ArrayList(array);
            int actualCount;
            actualCount = actual.RemoveAllByValue(value);
            ArrayList expected = new ArrayList(expectedArray);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 9 }, new int[] { 1, 5, -10 }, new int[] { 1, 9, 1, 5, -10 })]
        [TestCase(new int[] { 1, -6, 1, -10 }, new int[] { }, new int[] { 1, -6, 1, -10 })]
        [TestCase(new int[] { }, new int[] { 1, -6, 1, -10 }, new int[] { 1, -6, 1, -10 })]
        public void AddListToTheEnd_Test(int[] array, int[] addedArray, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList added = new ArrayList(addedArray);
            ArrayList expected = new ArrayList(expectedArray);
            actual.AddListToTheEnd(added);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 9 }, new int[] { 1, 5, -10 }, new int[] { 1, 5, -10, 1, 9 })]
        [TestCase(new int[] { 1, -6, 1, -10 }, new int[] { }, new int[] { 1, -6, 1, -10 })]
        [TestCase(new int[] { }, new int[] { 1, -6, 1, -10 }, new int[] { 1, -6, 1, -10 })]
        public void AddListToTheBeggining_Test(int[] array, int[] addedArray, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList added = new ArrayList(addedArray);
            ArrayList expected = new ArrayList(expectedArray);
            actual.AddListByIndex(added);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, 0, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, 1, new int[] { 1, 3, 4, 5, 2 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, 2, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, -6, 1, -10 }, new int[] { }, 2, new int[] { 1, -6, 1, -10 })]
        [TestCase(new int[] { }, new int[] { 1, -6, 1, -10 }, 0, new int[] { 1, -6, 1, -10 })]
        public void AddListByIndex_Test(int[] array, int[] addedArray, int index, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList added = new ArrayList(addedArray);
            ArrayList expected = new ArrayList(expectedArray);
            actual.AddListByIndex(added, index);
            Assert.AreEqual(expected, actual);
        }



        // Негативные тесты

        [TestCase(-1, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(-6, new int[] { 3 })]
        [TestCase(-10, new int[] { })]
        public void RemoveFromTheEnd_Exception(int number, int[] array)
        {
            try
            {
                ArrayList actual = new ArrayList(array);
                actual.RemoveFromTheEnd(number);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(-1, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(-6, new int[] { 3 })]
        [TestCase(-10, new int[] { })]
        public void RemoveFromTheBeginning_Exception(int number, int[] array)
        {
            try
            {
                ArrayList actual = new ArrayList(array);
                actual.RemoveFromTheBeginning(number);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(-1, 2, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase( 2, 1, new int[] { 3 })]
        [TestCase( 1, 1, new int[] { })]
        [TestCase(0, 1, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(0, 2, new int[] { 3 })]
        [TestCase(3, 2, new int[] { })]
        public void RemoveByIndex_Exception(int index, int number, int[] array)
        {
            try
            {
                ArrayList actual = new ArrayList(array);
                actual.RemoveByIndex(index, number);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(0, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(-1, new int[] { 3 })]
        [TestCase(1, new int[] { })]
        public void GetIndexByValue_Exception(int value, int[] array)
        {
            try
            {
                ArrayList actual = new ArrayList(array);
                actual.GetIndexByValue(value);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(new int[] { })]

        public void GetMaxElement_Exception(int[] array)
        {
            try
            {
                ArrayList actualArr = new ArrayList(array);
                int actual = actualArr.GetMaxElement();
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(new int[] { })]

        public void GetMinElement_Exception(int[] array)
        {
            try
            {
                ArrayList actualArr = new ArrayList(array);
                int actual = actualArr.GetMinElement();
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(new int[] { })]

        public void GetIndexOfMaxElement_Exception(int[] array)
        {
            try
            {
                ArrayList actualArr = new ArrayList(array);
                int actual = actualArr.GetIndexOfMaxElement();
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(new int[] { })]

        public void GetIndexOfMinElement_Exception(int[] array)
        {
            try
            {
                ArrayList actualArr = new ArrayList(array);
                int actual = actualArr.GetIndexOfMinElement();
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, 2)]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, -1)]
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, -2)]
        [TestCase(new int[] { 1, -6, 1, -10 }, new int[] { }, 12)]
        [TestCase(new int[] { }, new int[] { 1, -6, 1, -10 }, 0)]
        public void AddListByIndex_Exception(int[] array, int[] addedArray, int index)
        {
            try
            {
                ArrayList actual = new ArrayList(array);
                ArrayList added = new ArrayList(addedArray);

                actual.AddListByIndex(added, index);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }
    }
}