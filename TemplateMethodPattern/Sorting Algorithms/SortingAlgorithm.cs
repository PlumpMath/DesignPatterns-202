using System;

namespace TemplateMethodPattern.Sorting_Algorithms
{
    public abstract class SortingAlgorithm<T> where T : IComparable<T>
    {
        protected abstract int Partition(T[] arr, int low, int high);

        protected virtual void Combine(T[] arr, int l, int m, int r)
        {
        }
        protected abstract void ProcessLeftSideSubary(T[] arr, int low, int high);

        protected abstract void ProcessRightSideSubary(T[] arr, int low, int high);

        // This is the template Method for Sorting Algorithm
        public void Sort(T[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);
                ProcessLeftSideSubary(arr, low, pivot);
                ProcessRightSideSubary(arr, pivot, high);
                Combine(arr, low, pivot, high);
            }

        }
    }
}
