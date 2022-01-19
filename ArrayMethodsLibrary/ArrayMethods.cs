using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethodsLibrary
{
    public class ArrayMethods
    {
        public static int[] CreateRandomArray(int n, int minValue = -10, int maxValue = 10)
        {
            int [] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(minValue, maxValue);
            }
            return arr;
        }
        public static int SumOfNegElements(int [] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    sum += array[i]; 
                }
            }
            return sum;
        }
        public static int MaxAmongEven(int [] array, int minValue = -10)
        {
            int maxElement = minValue++;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] > maxElement)
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        public static int DobOfElementsWithEvenIndex(int []array)
        {
            int dob = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    dob *= array[i]; 
                }
            }
            return dob;
        }
        public static int IndexOfMaxElement(int [] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[index])
                {
                    index = i;
                }
            }
            return index;
        }
        public static int MaxAbsElement(int [] array, int minValue = -10)
        {
            int maxAbsElement = minValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i])> maxAbsElement)
                {
                    maxAbsElement = Math.Abs(array[i]);
                }
            }
            return maxAbsElement;
        }
        public static int IndexSum(int[] array)
        {
            int indexSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    indexSum += i;
            }
            return indexSum;
        }
        public static int CountOfOddElements(int[] array)
        {
            int countOfElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    countOfElement++;
            }
            return countOfElement;
        }
    }
}
