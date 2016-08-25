using System;

namespace TemplateMethodPattern.Sorting_Algorithms
{
    public interface ISortingAlgorithm
    {
        void Sort<T>(T[] elements, int left, int right) where T : IComparable<T>;
    }
}
