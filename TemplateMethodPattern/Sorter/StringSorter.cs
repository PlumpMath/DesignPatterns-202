using System;
using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern.Sorter
{
    public class StringSorter : AbstractSorter
    {
        private readonly string[] _myStringArray;
        private readonly SortingAlgorithm<string> _stringSortingAlgorithm;
        public StringSorter(int numberofInput, string algorithmName) : base(numberofInput)
        {
            _myStringArray = new string[NumberofInput];
            _stringSortingAlgorithm = AlgorithmFactory<string>.GetSortingAlgorithm(algorithmName);
        }

        protected override void ReadInput()
        {
            Console.WriteLine("Reading input for String Data");
            for (var i = 0; i < NumberofInput; i++)
            {
                Console.WriteLine("Enter  string no # {0}: ", i + 1);
                _myStringArray[i] = Console.ReadLine();

            }
        }

        protected override void SortData()
        {
            Console.WriteLine("Sorting String Data elements... ");
            _stringSortingAlgorithm.Sort(_myStringArray, 0, _myStringArray.Length - 1);
        }

        protected override void PrintData()
        {
            Console.WriteLine("Printing Sorted String Elements...");

            for (int i = 0; i < NumberofInput; i++)
            {
                Console.Write(_myStringArray[i] + " ");
            }
            Console.WriteLine("");
        }


    }
}
