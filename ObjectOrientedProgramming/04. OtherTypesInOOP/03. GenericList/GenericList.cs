//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
//•	Keep the elements of the list in an array with a certain capacity, which is given as an optional parameter in the class constructor. 
//Declare the default capacity of 16 as constant.
//•	Implement methods for:
//o	adding an element 
//o	accessing element by index
//o	removing element by index
//o	inserting element at given position
//o	clearing the list
//o	finding element index by given value
//o	checking if the list contains a value
//o	printing the entire list (override ToString()). 
//•	Check all input parameters to avoid accessing elements at invalid positions.
//•	Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//•	Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
//You may need to add generic constraints for the type T to implement IComparable<T>.

namespace _03.GenericList
{
    using System;

    [Version(1,0)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int count;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new InvalidOperationException("Invalid index.");
                }

                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new InvalidOperationException("Invalid index.");
                }

                this.elements[index] = value;
            }
        }

        public T Max()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot find minimal value of empty list.");
            }

            T maxValue = this.elements[0];

            foreach (var item in this.elements)
            {
                if (maxValue.CompareTo(item) < 0)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }

        public T Min()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Cannot find minimal value of empty list.");
            }

            T minValue = this.elements[0];

            foreach (var item in this.elements)
            {
                if (minValue.CompareTo(item) > 0)
                {
                    minValue = item;
                }
            }

            return minValue;
        }

        public bool Contains(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "Value cannot be null.");
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(value) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetIndex(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }

            throw new ArgumentException("No such value in the list");
        }

        public void Clear()
        {
            this.elements = new T[DefaultCapacity];
            this.Count = 0;
        }

        public void InsertAt(int index, T value)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new InvalidOperationException("Invalid index.");
            }
            if (this.Count + 1 > this.elements.Length)
            {
                this.Resize();
            }

            T[] newArray = new T[this.elements.Length];

            for (int i = 0, j = 0; i < this.Count; i++)
            {
                if (i != index)
                {
                    newArray[j] = this.elements[i];
                    j++;
                }
                else
                {
                    newArray[index] = value;
                    i--;
                }
            }

            this.Count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new InvalidOperationException("Invalid index.");
            }

            T[] newArray = new T[this.elements.Length];

            for (int i = 0, j = 0; i < this.Count; i++)
            {
                if (i != index)
                {
                    newArray[j] = this.elements[i];
                    j++;
                }
            }
            this.elements = newArray;
            this.Count--;
        }

        public void Add(T element)
        {
            if (count >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public override string ToString()
        {
            return string.Join(", ", this.elements);
        }

        private void Resize()
        {
            int newSize;

            if (this.Count >= int.MaxValue)
            {
                throw new OverflowException("The length of the list is maxed out.");
            }

            try
            {
                newSize = this.Count * 2;
            }
            catch (OverflowException)
            {
                newSize = int.MaxValue;
            }

            T[] newArray = new T[newSize];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[i];
            }

            this.elements = newArray;
        }
    }
}
