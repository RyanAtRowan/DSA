using System;

namespace DSA.Arrays 
{
    public class Array 
    {
        private int[] _elements;
        private int _size;

        public Array(int capacity) 
        {
            _elements = new int[capacity];
            _size = 0;
        }

        /// <summary>
        /// Inserts an element at a specified index
        /// </summary>
        /// <param name="index">Index at which to insert the element.</param>
        /// <param name="value">The value to insert.</param>
        public void Insert(int index, int value) 
        {
            // Insert logic here
        }

        /// <summary
        /// Gets the element at the specified index.
        /// </summary>
        /// <param name="index">Index of the element to retrieve.</param>
        /// <returns>The element at the specified index.</returns>
        public int Get(int index)
        {
            // Get logic here
            return 0;
        }

        /// <summary>
        /// Deletes an element at the specified index.
        /// </summary>
        /// <param name="index">Index of the element to delete.</param>
        public void Delete(int index)
        {
            // Delete logic here
        }

        /// <summary>
        /// Gets the current number of elements in the array.
        /// </summary>
        /// <returns>The total number of elements int he array.</returns>
        public int Size() 
        {
            // Size logic here
            return 0;
        }
        

    }
}