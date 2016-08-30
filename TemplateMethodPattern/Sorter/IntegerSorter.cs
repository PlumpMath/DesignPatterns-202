using System;
using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern.Sorter
{
    public class IntegerSorter : AbstractSorter
    {
        private readonly int[] _myIntegerarray;
        private readonly SortingAlgorithm<int> _integerSortingAlgorithm;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberofInput">The number of elements that needs to be sorted</param>
        /// <param name="algorithmName">The name of the algorithm we want to use</param>
        public IntegerSorter(int numberofInput, string algorithmName) : base(numberofInput)
        {
            _myIntegerarray = new int[NumberofInput];
            _integerSortingAlgorithm = AlgorithmFactory<int>.GetSortingAlgorithm(algorithmName);

        }

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
            _integerSortingAlgorithm.Sort(_myIntegerarray, 0, _myIntegerarray.Length - 1);
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
