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
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The array is: ");
            PrintArray(nums);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("The average number of these numbers which are in an interval of -100 to 100 is: " + GetAverageNumber(nums));
            
            Console.WriteLine("**********************************************************************");





            Console.WriteLine("Enter the length of the three arrays A, B and C:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the numbers of the array A: ");
            int[] A = new int[n];

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The average number of the array A is: " + GetAverageNumber(A));


            Console.WriteLine();

            Console.WriteLine("Enter the numbers of the second array B: ");

            int[] B = new int[n];

            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                B[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The average number of the array B is: " + GetAverageNumber(B));


            Console.WriteLine();

            Console.WriteLine("Enter the numbers of the third array C: ");

            int[] C = new int[n];

            for (int i = 0; i < C.Length; i++)
            {
                Console.WriteLine("Num[" + i + "]= ");
                C[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The average number of the array C is: " + GetAverageNumber(C));
            Console.WriteLine();
            Console.WriteLine();

            if (GetAverageNumber(A) > GetAverageNumber(B) && GetAverageNumber(A) > GetAverageNumber(C))
            {
                Console.WriteLine("The max average number from the three arrays is: " + GetAverageNumber(A));
            }
            else if (GetAverageNumber(B) > GetAverageNumber(A) && GetAverageNumber(B) > GetAverageNumber(C))
            {
                Console.WriteLine("The max average number from the three arrays is: " + GetAverageNumber(B));
            }
            else if (GetAverageNumber(C) > GetAverageNumber(A) && GetAverageNumber(C) > GetAverageNumber(B))
            {
                Console.WriteLine("The max average number from the three arrays is: " + GetAverageNumber(C));
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

        public static double GetAverageNumber(int[]numbers)
        {
         
            List<int> numbersInRange = new List<int>(numbers); //Правя си List от масива, за да мога да включа числата от интервала.
            double averageNum = 0;
            foreach (int num in numbers)
            {

                if (num > -100 && num < 100)
                {
                    numbersInRange.Add(num);
                }
  
            }
            averageNum = numbersInRange.Sum() / numbersInRange.Count();
            return averageNum;
            
        }

        public static void PrintArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write(i + "  ");
            }
        }
    }
}
