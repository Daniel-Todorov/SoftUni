using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CustomLinkedList;

namespace CustmLinkedListTests
{
    [TestClass]
    public class CustomLikedListTests
    {
        private DynamicList<int> customList;

        [TestInitialize]
        public void InitializeEmptyDynamicListOfIntegers()
        {
            this.customList = new DynamicList<int>();
        }

        [TestMethod]
        public void AddElementToListShouldReturnCountOne()
        {
            this.customList.Add(1);

            Assert.AreEqual(1, this.customList.Count, string.Format("After added one element the dynamic list should have 1 element but has {0} instead.", this.customList.Count));
        }

        [TestMethod]
        public void PropertyCountShouldReturnTwoWhenTwoElementsAreAdded()
        {
            this.customList.Add(1);
            this.customList.Add(2);

            Assert.AreEqual(2, this.customList.Count, string.Format("Property Count should return 2 but returns {0} instead", customList.Count));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Setting a negative index should throw ArgumentOutOfRangeException")]
        public void SetValueToNegativeIndexShouldReturnArgumentOutOfRangeException()
        {
            this.customList[-1] = 1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Setting an index greater than the count of the dynamic list - 1 should throw ArgumentOutOfRangeException")]
        public void SetValueToOutOfRangeIndexShouldReturnArgumentOutOfRangeException()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList[this.customList.Count + 1] = 1;
        }

        [TestMethod]
        public void SetValueToIndexShouldReturnTheAddedValue()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList[1] = 1;

            Assert.AreEqual(1, this.customList[1], "The element at position 1 should be equal to 1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Getting a negative index should throw ArgumentOutOfRangeException")]
        public void GetValueWithNegativeIndexShouldReturnTheAddedValue()
        {
            int testingValue = this.customList[-1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Getting an index greater than the count of the dynamic list - 1 should throw ArgumentOutOfRangeException")]
        public void GetValueWithOutOfRangeIndexShouldReturnArgumentOutOfRangeException()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            int testingValue = this.customList[this.customList.Count + 1];
        }

        [TestMethod]
        public void RemovingElementShouldReturnItsIndex()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(3);

            Assert.AreEqual(1, this.customList.Remove(2), "Removing value 2 from the dynamic list should return index 1");
        }

        [TestMethod]
        public void RemovingNotExistingElementShouldRetunMinusOne()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(3);

            Assert.AreEqual(-1, this.customList.Remove(4), "Removing value 4 from the dynamic list should return -1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Removing an index greater than the count of the dynamic list - 1 should throw ArgumentOutOfRangeException")]
        public void RemovingElementWithOutOfRangeIndexShouldReturnArgumentOutOfRangeException()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.RemoveAt(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Removing at a negative index should throw ArgumentOutOfRangeException")]
        public void RemovingElementWithNegativeIndexShouldReturnArgumentOutOfRangeException()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.RemoveAt(-1);
        }

        [TestMethod]
        public void RemovingElementAtCertainIndexShouldReturnTheElement()
        {
            this.customList.Add(1);
            this.customList.Add(2);

            Assert.AreEqual(2, this.customList.RemoveAt(1), "Removing the element at position 1 should return value 2.");
        }

        [TestMethod]
        public void GetIndexOfExistingElementShouldReturnTheIndexOfElement()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(1);

            Assert.AreEqual(1, this.customList.IndexOf(2), string.Format("Should return 1, instead returns {0}", this.customList.IndexOf(2)));
        }

        [TestMethod]
        public void GetIndexOfTwoExistingElementsShouldReturnTheIndexOfFIrstElement()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(1);

            Assert.AreEqual(0, this.customList.IndexOf(1), string.Format("Should return 0, instead returns {0}", this.customList.IndexOf(2)));
        }

        [TestMethod]
        public void GetIndexOfNonExistingElementShouldReturnMinusOne()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(1);

            Assert.AreEqual(-1, this.customList.IndexOf(3), string.Format("Should return -1, instead returns {0}", this.customList.IndexOf(2)));
        }

        [TestMethod]
        public void CheckingForEcistingElementExistsShouldReturnTrue()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(3);

            Assert.IsTrue(this.customList.Contains(1));
        }

        [TestMethod]
        public void CheckingNonEcistingElementExistsSHouldReturnTrue()
        {
            this.customList.Add(1);
            this.customList.Add(2);
            this.customList.Add(3);

            Assert.IsFalse(this.customList.Contains(4));
        }
    }
}
