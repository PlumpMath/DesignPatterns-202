using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern.Sorter
{
    public abstract class AbstractSorter
    {
        protected AbstractSorter(int numberofInput)
        {
            NumberofInput = numberofInput;
        }
        protected int NumberofInput { get; set; }
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
