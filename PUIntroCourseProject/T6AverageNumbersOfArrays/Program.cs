using System;
using System.Collections.Generic;
using System.Linq;

namespace T6AverageNumbersOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Задача 408. " +
                "1. Да се направят два метода:" +
                "а) за въвеждане на едномерен масив от реални числа:" +
                "б) за изчисляване на средноаритметичното на тези елементи на масива, които принадлежат " +
                "на интервала [-100,100]." +
                "2. В главния метод въведете цяло число n и три едномерни масива A[n], В[n] и С[n]. За всеки масив изчислете " +
                "и отпечатайте стойноста на средноаритметичното по точка 1б. Намерете и отпечатайте максималната от трите средноаритметични стойности." +
                "3. Преизчислете елементите на масива С по следния начин:" +
                "(a + (n2 + 1)b, a + ((n-1)2 + 1)b...");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Enter the length of the array: ");
            int k = int.Parse(Console.ReadLine());
            int[] nums = new int[k];

            T6Utils.PrintArrayItems(nums);

            Console.Write("The array is: ");
            T6Utils.PrintArray(nums);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("The average number of these numbers which are in an interval of -100 to 100 is: " + T6Utils.GetAverageNumber(nums));
            
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("Enter the length of the three arrays A, B and C:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers of the array A: ");
            int[] A = new int[n];

            T6Utils.PrintArrayItems(A);

            Console.Write("The average number of the array A is: " + T6Utils.GetAverageNumber(A));


            Console.WriteLine();

            Console.WriteLine("Enter the numbers of the second array B: ");

            int[] B = new int[n];

            T6Utils.PrintArrayItems(B);

            Console.Write("The average number of the array B is: " + T6Utils.GetAverageNumber(B));


            Console.WriteLine();

            Console.WriteLine("Enter the numbers of the third array C: ");

            int[] C = new int[n];

            T6Utils.PrintArrayItems(C);

            Console.Write("The average number of the array C is: " + T6Utils.GetAverageNumber(C));
            Console.WriteLine();
            Console.WriteLine();

            if (T6Utils.GetAverageNumber(A) > T6Utils.GetAverageNumber(B) && T6Utils.GetAverageNumber(A) > T6Utils.GetAverageNumber(C))
            {
                Console.WriteLine("The max average number from the three arrays is: " + T6Utils.GetAverageNumber(A));
            }
            else if (T6Utils.GetAverageNumber(B) > T6Utils.GetAverageNumber(A) && T6Utils.GetAverageNumber(B) > T6Utils.GetAverageNumber(C))
            {
                Console.WriteLine("The max average number from the three arrays is: " + T6Utils.GetAverageNumber(B));
            }
            else if (T6Utils.GetAverageNumber(C) > T6Utils.GetAverageNumber(A) && T6Utils.GetAverageNumber(C) > T6Utils.GetAverageNumber(B))
            {
                Console.WriteLine("The max average number from the three arrays is: " + T6Utils.GetAverageNumber(C));
            }
            else
            {
                Console.WriteLine("The average numbes are equal.");
            }

            double recalculation = 0;
            for (int i=0; i < C.Length;i++)
            {
                Array.Sort(C);
                double a = C[i];
                double b = C[1] - C[0];
                recalculation = a + (Math.Pow(n, 2) + 1) * b;
            }
            Console.WriteLine("The recalculation of the elements of the array is: " + recalculation);
        }
    }
}
