using System;
using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern
{
    public class IntegerSorter : Sorter
    {
        private readonly int[] _myIntegerarray;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberofInput">The number of elements that needs to be sorted</param>
        /// <param name="algorithmName">The name of the algorithm we want to use</param>
        public IntegerSorter(int numberofInput, string algorithmName) : base(numberofInput,algorithmName)
        {
            _myIntegerarray = new int[NumberofInput];

        }
        protected override ISortingAlgorithm SortingAlgorithm => AlgorithmFactory.GetSortingAlgorithm(AlgorithmName);

        protected override void ReadInput()
        {
            Console.WriteLine("Reading input for Integer Data....");
            for (int i = 0; i < NumberofInput; i++)
            {
                Console.WriteLine("Enter Integer #{0} : ", i + 1);
                _myIntegerarray[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        protected override void SortData()
        {
            Console.WriteLine("Sorting integer Data");
            SortingAlgorithm.Sort(_myIntegerarray, 0, _myIntegerarray.Length - 1);
        }

        protected override void PrintData()
        {
            Console.WriteLine("Printing Sorted Integer Elements...");

            for (int i = 0; i < NumberofInput; i++)
            {
                Console.Write(_myIntegerarray[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
