using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollSys
{
    public class Utility
    {

        /// <summary>
        /// Generic linear search 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>index location of match : returns -1</returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            if (array == null)
            {
                Console.WriteLine("Error: Array cannot be null.");
                return -1; 
            }

            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].CompareTo(target) == 0)
                        return i;
                }
                return -1; // -1 is returned when not found
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during linear search: {ex.Message}");
                return -1;
            }
            
            
        }

        /// <summary>
        /// Generic binary search 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>index location of match : returns -1</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            if (array == null)
            {
                Console.WriteLine("Error: Array cannot be null.");
                return -1;
            }
            try
            {
                int min = 0;
                int max = array.Length - 1;
                int mid;
                int compare;
                while (min <= max)
                {
                    mid = (min + max) / 2;
                    compare = array[mid].CompareTo(target);

                    if (compare == 0)
                        return mid;
                    if (compare < 0)
                        min = mid + 1;
                    else
                        max = mid - 1;
                }
                return -1; // -1 is returned when not found

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred during binary search: {ex.Message}");
                return -1; 
            }
            
        }


        /// <summary>
        /// Quick Sort
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void QuickSort<T>(T[] array, int start, int end) where T : IComparable<T>
        {
            int i = start, j = end;
            var pivot = array[(start + end) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (start < j) QuickSort(array, start, j);
            if (i < end) QuickSort(array, i, end);
        }

        public static void QuickSortAscending<T>(T[] array) where T : IComparable<T>
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public static void QuickSortDescending<T>(T[] array) where T : IComparable<T>
        {
            QuickSortAscending(array);
            Array.Reverse(array);
        }


    }
}
