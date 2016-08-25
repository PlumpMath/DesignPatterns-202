namespace TemplateMethodPattern.Sorting_Algorithms
{
    public static class AlgorithmFactory
    {
        public static ISortingAlgorithm GetSortingAlgorithm(string algorithmName)
        {
            switch (algorithmName)
            {
                case "merge":
                    return new MergeSort();
                case "quick":
                    return new QuickSort();
                default:                       // default sorting algorithm will be Quick Sort
                    return new QuickSort();
            }
        }
    }
}
