using System;

namespace Lab2
{
	public class MaxHeap<T> where T: IComparable<T>
	{
        private T[] array;
        private const int initialSize = 8;

        public int Count { get; private set; }

        public int Capacity => array.Length;

        public bool IsEmpty => Count == 0;


        public MaxHeap(T[] initialArray = null)
        {
            array = new T[initialSize];

            if (initialArray == null)
            {
                return;
            }

            foreach (var item in initialArray)
            {
                Add(item);
            }

        }

        /// <summary>
        /// Returns the min item but does NOT remove it.
        /// Time complexity: O(?).
        /// </summary>
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Empty Heap");
            }

            return array[0];
        }

        // TODO
        /// <summary>
        /// Adds given item to the heap.
        /// Time complexity: O(?).
        /// </summary>
        public void Add(T item)
        {
            int nextEmptyIndex = Count;

            array[nextEmptyIndex] = item;

            TrickleUp(nextEmptyIndex);

            Count++;

            // resize if full
            if (Count == Capacity)
            {
                DoubleArrayCapacity();
            }

        }

        public T Extract()
        {
            return ExtractMax();
        }

        // TODO
        /// <summary>
        /// Removes and returns the max item in the min-heap.
        /// Time complexity: O( N ).
        /// </summary>
        public T ExtractMax()
        {
            // linear search
            if (IsEmpty)
            {
                throw new Exception("Empty Heap");
            }

            T max = array[0];

            // swap root (first) and last element
            Swap(0, Count - 1);

            // "remove" last
            Count--;

            // trickle down from root (first)
            TrickleDown(0);

            return max;
        }

        // TODO
        /// <summary>
        /// Removes and returns the min item in the min-heap.
        /// Time ctexity: O( log(n) ).
        /// </summary>
        public T ExtractMin()
        {
            // linear search
        }

        // TODO
        /// <summary>
        /// Returns true if the heap contains the given value; otherwise false.
        /// Time complexity: O( N ).
        /// </summary>
        public bool Contains(T value)
        {
            // linear search

            foreach (var item in array)
            {
                if (item.CompareTo(value) == 0)
                {
                    return true;
                }
            }

            return false;

        }

        // TODO
        // Time Complexity: O( log(n) )
        private void TrickleUp(int index)
        {


        }

        // TODO
        // Time Complexity: O( log(n) )
        private void TrickleDown(int index)
        {

        }

        // TODO
        /// <summary>
        /// Gives the position of a node's parent, the node's position in the heap.
        /// </summary>
        private static int Parent(int position)
        {

        }

        // TODO
        /// <summary>
        /// Returns the position of a node's left child, given the node's position.
        /// </summary>
        private static int LeftChild(int position)
        {
        }

        // TODO
        /// <summary>
        /// Returns the position of a node's right child, given the node's position.
        /// </summary>
        private static int RightChild(int position)
        {
        }

        private void Swap(int index1, int index2)
        {
            var temp = array[index1];

            array[index1] = array[index2];
            array[index2] = temp;
        }

        private void DoubleArrayCapacity()
        {
            Array.Resize(ref array, array.Length * 2);
        }


    }
}
}

