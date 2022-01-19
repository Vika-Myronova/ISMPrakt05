using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayMethodsLibrary;

namespace ArrayConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr = ArrayMethods.CreateRandomArray(n);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
            int sum = ArrayMethods.SumOfNegElements(arr);
            Console.WriteLine($"\nСума від'ємних елементів масиву = {sum}");

            int max = ArrayMethods.MaxAmongEven(arr);
            Console.WriteLine($"Максимальне серед парних елементів = {max}");

            int dob = ArrayMethods.DobOfElementsWithEvenIndex(arr);
            Console.WriteLine($"Добуток елементів з парними індексами = {dob}");

            int index = ArrayMethods.IndexOfMaxElement(arr);
            Console.WriteLine($"\nІндекс максимального елемента масиву = {index}");

            int maxAbsElement = ArrayMethods.MaxAbsElement(arr);
            Console.WriteLine($"Максимальний за модулем елемент масиву = {maxAbsElement}");

            int indexSum = ArrayMethods.IndexSum(arr);
            Console.WriteLine($"Сума індексів додатних елементів = {indexSum}");

            int count = ArrayMethods.CountOfOddElements(arr);
            Console.WriteLine($"Кількість непарних елементів масиву = {count}\n");

        }
    }
}
