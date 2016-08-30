using System;

namespace TemplateMethodPattern.Sorting_Algorithms
{
    public static class AlgorithmFactory<T> where T : IComparable<T>
    {
        public static SortingAlgorithm<T> GetSortingAlgorithm(string algorithmName)
        {
            switch (algorithmName)
            {
                case "merge":
                    return new MergeSortAlgorithm<T>();
                case "quick":
                    return new QuickSortAlgorithm<T>();
                default:                       // default sorting algorithm will be Quick Sort
                    return new QuickSortAlgorithm<T>();
            }
        }
    }
}
