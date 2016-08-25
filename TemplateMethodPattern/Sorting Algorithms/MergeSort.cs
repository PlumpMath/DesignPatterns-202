using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Sorting_Algorithms
{
    public class MergeSort : ISortingAlgorithm
    {
        public void MainMerge<T>(T[] numbers, int left, int mid, int right) where T : IComparable<T>
        {
            var temp = new T[25];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left].CompareTo(numbers[mid]) <= 0)
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public void Sort<T>(T[] numbers, int left, int right) where T : IComparable<T>
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, (mid + 1), right);

                MainMerge(numbers, left, (mid + 1), right);
            }
        }

    }
}
