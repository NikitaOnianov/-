using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Разделение_массива_на_два
{
    internal class Program
    {
        static void Main()
        {
            int[] arry = { 7, 2, 3, 4, 11, 33, 9, 10 };
            MergeSort(arry);


        }


        public static void MergeSort(int [] arry)
        {
            int N = arry.Length;
            if (N > 0)
            {
                int middle = N / 2;
                int leftLength = middle;
                int rightLength = N - leftLength;
                int[] left = new int[leftLength];
                int[] right = new int[rightLength];
                for (int i = 0; i < middle; i++)
                {
                    left[i] = arry[i];
                }
                int rightIndex = 0;
                for (int i = middle; i < N; i++)
                {
                    right[rightIndex] = arry[i];
                    rightIndex++;
                }
                MergeSort(left);
                MergeSort(right);
                Merge(arry, left, right);
            }
        }




        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j]) arr[k++] = left[i++];
                else arr[k++] = right[j++];
            }
            while (i < left.Length) arr[k++] = left[i++];
            while (j < right.Length) arr[k++] = right[j++];
            Console.Write("Вывод результата: ");
            Console.WriteLine(arr);


        }
    }
}
