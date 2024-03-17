using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BinarySearch_prince
{
    public static class BinarySearch
    {
        // Iterative binary search method
        public static int IterativeBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        // Recursive binary search method
        public static int RecursiveBinarySearch(int[] array, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    return RecursiveBinarySearch(array, target, mid + 1, right);
                else
                    return RecursiveBinarySearch(array, target, left, mid - 1);
            }

            return -1;
        }
    }
}
