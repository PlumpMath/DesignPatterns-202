using System;
using TemplateMethodPattern.Sorting_Algorithms;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Data Type to sort? type 'int' for ineteger data and 'string' for string data");
                var sortType = Console.ReadLine();
                Console.WriteLine("Enter the algorithm you want to sort with. " + '\n' +
                                  "Please type 'quick' for quick Sort and 'merge' for MergeSort");
                var sortingAlgorithmName = Console.ReadLine();
                Console.WriteLine("Enter the Number of Elements you want to sort");
                var numberOfElements = Convert.ToInt32(Console.ReadLine());
                var sorter = GetSorter(sortType, numberOfElements, sortingAlgorithmName);

                if (sorter == null)
                {
                    Console.WriteLine("Invalid Choice Entered");
                }
                else
                {
                    sorter.Sort();
                }
            }
        }

        /// <summary>
        /// Gets the appropriate Sorter for Relevant Data Tyo
        /// </summary>
        /// <param name="type"></param>
        /// <param name="numberofElements"></param>
        /// <param name="algorithmName"></param>
        /// <returns></returns>
        public static Sorter GetSorter(string type, int numberofElements, string algorithmName)
        {
            switch (type)
            {
                case "int":
                    return new IntegerSorter(numberofElements, algorithmName);
                case "string":
                    return new StringSorter(numberofElements, algorithmName);
                default:
                    return null;
            }
        }
    }
}
