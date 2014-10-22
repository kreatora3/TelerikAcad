using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericClass
{
    /* 05.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
     Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
     Implement methods for adding element, accessing element by index, removing element by index, inserting element at
     given position, clearing the list, finding element by its value and ToString(). Check all input parameters to 
     avoid accessing elements at invalid positions.*/

    /* 06.Implement auto-grow functionality: when the internal array is full, 
     create a new array of double size and move all elements to it.*/

    /* 07.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
     You may need to add a generic constraints for the type T.*/
    public class GenericList<T>
         where T : IComparable
    {
        private const int InitialSize = 4;
        private  int lastIndex;
        private T[] array;        
        private uint size;

        public GenericList() 
            :this(InitialSize)
        {
            
        }

        public GenericList(uint size)
        {
            if (size < 2)
            {
                throw new IndexOutOfRangeException("The initial size of the list should consists of at least 2 elements");
            }
            this.array = new T[size];
            this.lastIndex = 0;
            this.size = size;
        }

       // indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return array[index];
            }

            set
            {
                if (index < 0 || index >= size)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                this.array[index] = value;
            }
        }

        // Auto grow
        private void AutoGrow()
        {
            T[] newArray = new T[this.array.Length * 2];
            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }

        // Add element to list
        public void AddElements(T value)
        {
            if (this.lastIndex == this.array.Length)
            {
                AutoGrow();
            }
            array[lastIndex] = value;
            lastIndex++;
        }

        // Deleting element at given position
        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            T[] tempArray = new T[array.Length - 1];
            lastIndex--;
            Array.Copy(array, 0, tempArray, 0, index);
            Array.Copy(array, index + 1, tempArray, index, array.Length - 1 - index);
            array = tempArray;
        }

        // Insert element at given position
        public void InsertAtIndex(T value, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            T[] tempArray = new T[array.Length + 1];
            lastIndex++;
            Array.Copy(array, 0, tempArray, 0, index);
            tempArray[index] = value;
            Array.Copy(array, index, tempArray, index + 1, array.Length - index);
            array = tempArray;
        }

        // Finds the index of first occurance of given element
        public int FindElement(T element)
        {
            return Array.IndexOf(array, element);
        }

        // ToString() overrided
        public override string ToString()
        {
            if (lastIndex == 0)
            {
                return "List is empty"; 
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.AppendFormat("At position {0} we have {1} \r\n", i, array[i]);
            }
            return sb.ToString();
        }

        // Clear
        public void Clear()
        {
            lastIndex = 0;
        }

        public T Min()
        {
            T minElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (minElement.CompareTo(array[i]) > 0)
                {
                    minElement = array[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            T maxElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (maxElement.CompareTo(array[i]) < 0)
                {
                    maxElement = array[i];
                }
            }

            return maxElement;
        }
    }
}
