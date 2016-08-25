using System;
using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern
{
    public class StringSorter : Sorter
    {
        private readonly string[] _myStringArray;
        public StringSorter(int numberofInput, string algorithmName) : base(numberofInput, algorithmName)
        {
            _myStringArray = new string[NumberofInput];
        }

        protected override ISortingAlgorithm SortingAlgorithm => AlgorithmFactory.GetSortingAlgorithm(AlgorithmName);

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
            SortingAlgorithm.Sort(_myStringArray, 0, _myStringArray.Length - 1);
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
