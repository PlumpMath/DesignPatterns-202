using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern
{
    public abstract class Sorter
    {
        protected Sorter(int numberofInput,string algorithmName)
        {
            NumberofInput = numberofInput;
            AlgorithmName = algorithmName;
        }
        protected int NumberofInput { get; set; }
        protected string AlgorithmName { get; set; }
        protected abstract ISortingAlgorithm SortingAlgorithm { get;}
        protected abstract void ReadInput();
        protected abstract void SortData();
        protected abstract void PrintData();

        // This is our Template Method 
        public void Sort()
        {
            ReadInput();
            SortData();
            PrintData();
        }
    }
}
