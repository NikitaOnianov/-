using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static int BinarySearch(int[] array, int search)
        {
            int left = 0;
            int right = array.Length - 1;

            int middle = (left + right) / 2;


            while (left <= right)
            {
                if (array[middle] < search)
                {
                    left = middle + 1;
                }
                else if (array[middle] > search)
                {
                    right = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
        }
    }
}
