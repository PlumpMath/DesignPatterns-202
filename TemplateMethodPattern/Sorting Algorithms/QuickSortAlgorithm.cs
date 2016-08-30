using System;

namespace TemplateMethodPattern.Sorting_Algorithms
{
    public class QuickSortAlgorithm<T> : SortingAlgorithm<T> where T : IComparable<T>
    {
        protected override int Partition(T[] arr, int low, int high)
        {
            T pivot = arr[high];
            T temp;
            int i = (low - 1); // index of smaller element
            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (arr[j].CompareTo(pivot) <= 0)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            return i + 1;
        }

        protected override void ProcessLeftSideSubary(T[] arr, int low, int high)
        {
            Sort(arr, low, high - 1);
        }

        protected override void ProcessRightSideSubary(T[] arr, int low, int high)
        {
            Sort(arr, low + 1, high);
        }
    }
}
